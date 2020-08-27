/*
* Author: Hunter Ruskanen
* Class name: GardenOrcOmelette.cs
* Purpose: To add a Garden Orc Omelette to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        ///Common 
        double Price { get; } = 4.57;
        uint Calories { get; } = 404;
        List<string> SpecialInstructions { get; }

        ///Unique
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
                SpecialInstructions.Add("Hold Broccoli");
            }
        }

        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
                SpecialInstructions.Add("Hold Mushrooms");
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

        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
                SpecialInstructions.Add("Hold Cheddar");
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
