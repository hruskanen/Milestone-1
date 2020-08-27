/*
* Author: Hunter Ruskanen
* Class name: MarkarthMilk.cs
* Purpose: To add a Markarth Milk to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class MarkarthMilk
    {
        ///Common 
        double Price = 1.05;
        uint Calories = 56;
        List<string> SpecialInstructions { get; }
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (Size.Small == value)
                {
                    Price = 1.05;
                    Calories = 56;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.11;
                    Calories = 72;
                }
                else if (Size.Large == value)
                {
                    Price = 1.22;
                    Calories = 93;
                }
            }
        }
        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                SpecialInstructions.Add("Hold Ice");
            }
        }


        public override string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}
