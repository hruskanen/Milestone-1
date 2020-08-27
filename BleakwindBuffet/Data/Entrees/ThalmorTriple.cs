/*
* Author: Hunter Ruskanen
* Class name: ThalmorTriple.cs
* Purpose: To add a Thalmor Triple to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
        ///Common 
        double Price { get; } = 8.32;
        uint Calories { get; } = 943;
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

        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
                SpecialInstructions.Add("Hold Bacon ");
            }
        }

        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                SpecialInstructions.Add("Hold Egg");
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
