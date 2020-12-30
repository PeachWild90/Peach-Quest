using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Workbench // VARIABLES TEST SITE @@ IF STATEMENTS
    {
        //CLASS LEVEL VARIABLES
        public int classVariable1 = 3;  //VISIBLE TO OTHER CLASSES
        private int classVariable2 = 7; //ONLY VISIBLE TO THIS CLASS
        private int classVariable3; //DECLARATION WITH NO VALUE

        public void Function1()
        {
            int functionVariable1;

            if(classVariable1 < 5)
            {
                functionVariable1 = 1;

                int inerrVariable1;
            }

            if(classVariable1 >= 5)
            {
                functionVariable1 = 2;

                int innerVariable1;
            }
        }

        public void Function2()
        {
            int functionVariable1;

            if(classVariable2 < 5)
            {
                functionVariable1 = 3;

                int innerVariable1;
            }

            if(classVariable2 >= 5)
            {
                functionVariable1 = 4;

                int innerVariable1;
            }
        }

        public bool IsPlayerStillAlive1(int currentHitPoints)
        {
            if(currentHitPoints > 0)
            {
                return true;
            }

            return false; 
        }

        public bool IsPlayerStillAlive2(int currentHitPoints, bool hasResurrectionRing)
        {
            if((currentHitPoints > 0) || ((currentHitPoints == 0) && hasResurrectionRing))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ComputePlayerLevel(int experiencePoints)
        {
            if(experiencePoints < 100)
            {
                return 1; //Player is level 1
            }
            else if(experiencePoints < 250)
            {
                return 2; //Player is level 2
            }
            else if(experiencePoints < 500)
            {
                return 3;
            }
            else if (experiencePoints < 1000)
            {
                return 4; // Player is level 4
            }
            return 5; // The maximum level is 5, in this sample
        }

        //LINQ IN ACTION
        public void CalculateAverage()
        {
            //create and populate the list of numbers
            List<double> values = new List<double>();

            values.Add(1);
            values.Add(5);
            values.Add(21);

            //Calculating the average, using a foreach
            double total = 0;
            double counter = 0;

            foreach(double value in values)
            {
                total = (total + value);
                counter = (counter + 1);
            }

            double average = (total / counter);

            //Calculate the average, from a list, using LINQ
            double linqAverage = values.Average();
        }
    }
}
