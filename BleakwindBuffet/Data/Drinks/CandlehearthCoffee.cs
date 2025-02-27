﻿/*
* Author: Hunter Ruskanen
* Class name: CandlehearthCoffee.cs
* Purpose: To add a Candle hearth Coffee to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        ///Common 
        double Price = 0.75;
        uint Calories = 7;
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
                    Price = 0.75;
                    Calories = 7;
                }
                else if (Size.Medium == value)
                {
                    Price = 1.25;
                    Calories = 10;
                }
                else if (Size.Large == value)
                {
                    Price = 1.75;
                    Calories = 20;
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
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                SpecialInstructions.Add("Add Cream");
            }
        }

        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }


        public override string ToString()
        {
            return size + " Candlehearth Coffee";
        }
    }
}
