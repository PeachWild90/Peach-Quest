using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; set; } //We cant to store more complex stuff in our Location class
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; } //Now we have properties to hold these values for each location
                                                     //Because we need to store an Item object in the ItemRequiredToEnter property, its datatype is Item

        public Location(int id, string name, string description,
            Item itemRequiredToEnter = null, //Notice null, some locations DONT require an item, quest, or monster. So it lets them know not to pass values when constructor is called
                Quest questAvailableHere = null,
                    Monster monsterLivingHere = null) //this is our CONSTRUCTOR CODE for the location class
        {                                                   //public bc we want to be able to createa a new Location object from ANYWHERE IN THE SOLUTION
            ID = id;                                       //These are our PARAMETERS
            Name = name;                                  //When you run a function, or method (like a constructor), it can ACCEPT VALUES - called PARAMETERS
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
                                                        //In C#, you need to declare teh datatype of the parameter and its name.
        }                                              //In this constructor, there are 3 (id -int name -string description -string
                                                      //SO : when u call the Location constructor, you'll NEED to pass in these three values
                                                     //Between the curly braces we assign the values of the params to the properties in the class
                                                    //parameters on the right, properties on the left, value on right gets assigned to property, left, DUH
    }
}
