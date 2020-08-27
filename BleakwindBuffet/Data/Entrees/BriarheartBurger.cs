/*
* Author: Hunter Ruskanen
* Class name: BriarheartBurger.cs
* Purpose: To add a Briarheart Burger to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class BriarheartBurger
    {
        ///Common 
        double Price { get; } = 6.32;
        uint Calories { get; } = 743;
        List<string> SpecialInstructions { get; }


        ///Unique
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                SpecialInstructions.Add("Hold Bun");
            } 
        }

        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                SpecialInstructions.Add("Hold Ketchup");
            }
        }

        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                SpecialInstructions.Add("Hold Mustard");
            }
        }

        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                SpecialInstructions.Add("Hold Pickle");
            }
        }

        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                SpecialInstructions.Add("Hold Cheese");
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
