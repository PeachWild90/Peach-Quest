using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item //INHERITANCE -- We are making ITEM the BASE CLASS for HealingPotion and Weapon since they have the same properties that are in the item class
                       //THEN we are going to create a new LivingCreature base class, to hold the shared CurrentHitPoints and MaximumHitPoints properties of the Monster and Player classes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        public Item(int id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
