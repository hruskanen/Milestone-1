/*
* Author: Hunter Ruskanen
* Class name: SmokehouseSkeleton.cs
* Purpose: To add a Smokehouse Skeleton to the Entree menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class SmokehouseSkeleton
    {
        ///Common 
        double Price { get; } = 5.62;
        uint Calories { get; } = 602;
        List<string> SpecialInstructions { get; }

        ///Unique
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                sausageLink = value;
                SpecialInstructions.Add("Hold SausageLink");
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

        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                hashBrowns = value;
                SpecialInstructions.Add("Hold Hash Browns");
            }
        }

        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                SpecialInstructions.Add("Hold Egg");
            }
        }


        /// <summary>
        /// Prints all varibles of object
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
