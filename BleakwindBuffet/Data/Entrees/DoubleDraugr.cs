/*
* Author: Hunter Ruskanen
* Class name: DoubleDraugr.cs
* Purpose: To add a Double Draugr to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class DoubleDraugr
    {
        ///Common 
        double Price { get; } = 7.32;
        uint Calories { get; } = 843;
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

        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                SpecialInstructions.Add("Hold Tomato");
            }
        }

        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                SpecialInstructions.Add("Hold Lettuce");
            }
        }

        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                SpecialInstructions.Add("Hold Mayo");
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
