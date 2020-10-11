using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private class MenuItem
        {
            private double price;
            public double Price
            {
                get { return price; }
                internal set { price = value; }
            }
            private string description;
            public string Description
            {
                get { return description; }
                internal set { description = value; }
            }
            private string category;
            public string Category
            {
                get { return category; }
                internal set { category = value; }
            }
            private string newItem;
            public static string NewItem
            {
                get { return newItem; }
                set { newItem = value; }
            }
            private string updated;
            public static string Updated
            {
                get { return updated; }
                internal set { updated = value; }
            }
        }

    }
}
