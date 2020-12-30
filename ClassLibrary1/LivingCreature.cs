using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature //we dont have a class with the properties we have in common with the Monster and Player classes
                                //si we create a new class, LivingCreature, with the properties, making it a new BASE CLASS
    {                           //Base classes let you SHARE FUNCTIONS so you dont duplicate code
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints; 
        }
    }
}
