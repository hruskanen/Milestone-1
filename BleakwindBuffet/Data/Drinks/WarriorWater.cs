/*
* Author: Hunter Ruskanen
* Class name: WarriorWater.cs
* Purpose: To add a Warrior Water to the drink menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        ///Common 
        double Price = 0;
        uint Calories = 0;
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
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                SpecialInstructions.Add("Hold Lemon");
            }
        }



        public override string ToString()
        {
            return size + " Warrior Water";
        }
    }
}
