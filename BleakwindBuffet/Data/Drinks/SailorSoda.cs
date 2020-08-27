/*
* Author: Hunter Ruskanen
* Class name: SailorSoda.cs
* Purpose: To add a Sailor Soda to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {
        ///Common 
        double Price = 1.42;
        uint Calories = 117;
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
                if(Size.Small == value)
                {
                    Price = 1.42;
                    Calories = 117;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.74;
                    Calories = 153;
                }
                else if (Size.Large == value)
                {
                    Price = 2.07;
                    Calories = 205;
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


        ///Unique
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }


        public override string ToString()
        {
            return  Size + " " + flavor + " Sailor Soda";
        }
    }
}
