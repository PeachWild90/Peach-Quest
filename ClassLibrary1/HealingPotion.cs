using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item //adding the colon and Item class name after is how we show that HealingPotion has a base class of Item
                                      //Sim all the public properties and methods from the Item class now automatically show up in the HealingPotion class, even after we delete t he lines for the ID, Name, and NamePLural Properties
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string NamePlural { get; set; }
        public int AmountToHeal { get; set; }

        //**HealingPotion is now a CHILD CLASS, or DERIVED CLASS, from the Item class

        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }

        //Notice that the HealingPotion constructor has parameters for the one property it has (AmountToHeal) and the three properties it uses
        //from the base class (ID, Name, and Name-Plural)
        //Inside the construcot, it sets the AmountToHeal property to the value that was passed through the amountToHeal parameter
        //Notice after teh constructor has a list of its parameters ====
        //What this does is take the values from the parameters in the HealingPotion constructor (id, name, and namePlural) and passes them
        //on to the constructor of the Item class. This is how we get parameters into the BASE CLASS, when isntantiating a derived class
    }
}
