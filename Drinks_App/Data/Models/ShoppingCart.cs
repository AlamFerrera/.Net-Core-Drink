﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_App.Data.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetServices<IHttpContextAccessor>().First().HttpContext.Session;
                //services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session; //?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) {
                ShoppingCartId = cartId
            };
        }//"99def607-e900-495b-958d-4a34f08d9d1d"

        public void AddtoCart(Drink drink, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems
                                .SingleOrDefault(s => s.Drink.DrinkId == drink.DrinkId && 
                                                  s.ShoppingCartId == ShoppingCartId);
          
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Drink = drink,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Drink drink)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Drink.DrinkId == drink.DrinkId &&
                                                                   s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {

            return ShoppingCartItems ??
                    (ShoppingCartItems =
                        _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                            .Include(s => s.Drink)
                            .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                            .ShoppingCartItems
                            .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems
                        .Where(cart => cart.ShoppingCartId == ShoppingCartId)
                        .Select(c => c.Drink.Price * c.Amount)
                        .Sum();
            return total;
        }
    }
}
