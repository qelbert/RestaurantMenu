using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{

    //menu is a list of dictionaries
            //menu class contains a method that creates the dictionary containing the values for each menu item
            // the value for some keys will be instance methods (i.e. category, new item, date added)
            //menu class contains a method that removes items from the menu list
            //menu class contains a method that allows the user to print a single menu list items as well as the full menu list

            //menu item class contains a method that instantiates objects from the selected dictionary items found in the menu list
            //menu item contains a method that compares menu objects to check to see if they're equal

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
