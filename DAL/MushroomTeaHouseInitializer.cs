using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MushroomTeaHouse.Models;

namespace MushroomTeaHouse.DAL
{
    public class MushroomTeaHouseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MushroomTeaHouseContext>
    {
        protected override void Seed(MushroomTeaHouseContext context)
        {
            var items = new List<Item>
            {
                new Item{ItemId=01, Name="All Day Breakfast", Description="Breakfast", Price=118, Category="FOOD", Visible=true},
                new Item{ItemId=02, Name="Greek Yogurt Berries Pancake", Description="Pancake", Price=68, Category="FOOD", Visible=true},
                new Item{ItemId=03, Name="White Anchovy Caesar Salad", Description="Salad", Price=58, Category="FOOD", Visible=true},
                new Item{ItemId=04, Name="Parma Ham Bagel", Description="Bagel", Price=62, Category="FOOD", Visible=true},
                new Item{ItemId=05, Name="Earl Grey", Description="Tea", Price=48, Category="DRINK", Visible=true},
                new Item{ItemId=06, Name="English Breakfast", Description="Tea", Price=48, Category="DRINK", Visible=true},
                new Item{ItemId=07, Name="Caffè Latte", Description="Coffee", Price=58, Category="DRINK", Visible=true},
                new Item{ItemId=08, Name="Original Chocolato", Description="Chocolato", Price=44, Category="DRINK", Visible=true},
                new Item{ItemId=09, Name="Apple Juice", Description="Fruit Juice", Price=40, Category="DRINK", Visible=true},
                new Item{ItemId=10, Name="Sparkling Water", Description="Water", Price=30, Category="DRINK", Visible=true}

            };

            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
                new Order{OrderId=01, UserId=001, Total=166, CreateDate=DateTime.Parse("2020-01-09")},
                new Order{OrderId=02, UserId=002, Total=102, CreateDate=DateTime.Parse("2020-01-10")},
                new Order{OrderId=03, UserId=003, Total=92, CreateDate=DateTime.Parse("2020-01-11")}
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
            var orderItems = new List<OrderItem>
            {
                new OrderItem{OrderItemId=01, OrderId=01, ItemId=01, Quantity=1, Price=118},
                new OrderItem{OrderItemId=02, OrderId=01, ItemId=06, Quantity=1, Price=48},
                new OrderItem{OrderItemId=03, OrderId=02, ItemId=03, Quantity=1, Price=58},
                new OrderItem{OrderItemId=04, OrderId=02, ItemId=08, Quantity=1, Price=44},
                new OrderItem{OrderItemId=05, OrderId=03, ItemId=04, Quantity=1, Price=62},
                new OrderItem{OrderItemId=06, OrderId=03, ItemId=10, Quantity=1, Price=30}
            };
            orderItems.ForEach(s => context.OrderItems.Add(s));
            context.SaveChanges();
        }
    }
}
