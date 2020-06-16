using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Craft.Net.Client.Events
{
    public class HealthAndFoodEventArgs : EventArgs
    {
        public float OldHealth { get; set; }
        public int OldFood { get; set; }
        public float OldFoodSaturation { get; set; }
        public float Health { get; set; }
        public int Food { get; set; }
        public float FoodSaturation { get; set; }

        internal bool IsChanged()
        {
            return OldHealth != Health || OldFood != Food || OldFoodSaturation != FoodSaturation;
        }

        public HealthAndFoodEventArgs(float oldHealth, int oldFood, float oldFoodSaturation)
        {
            OldHealth = oldHealth;
            OldFood = oldFood;
            OldFoodSaturation = oldFoodSaturation;
        }
    }
}