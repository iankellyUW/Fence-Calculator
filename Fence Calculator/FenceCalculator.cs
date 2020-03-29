using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fence_Calculator
{
    public class FenceCalculator
    {
        //Extra percent for materials
        bool extraTen = false;
        int customExtra = 0;


        //number of posts needed
        //input
        int fenceLength { get; set; }
        int postDistance { get; set; }
        //output
        int numberPosts { get; set; }
        int numberSections { get; set; }

        //number of pickets needed
        //input
        int picketWidth { get; set; }
        int picketSpace { get; set; }
        //output
        int numberPickets { get; set; }

        //number of rails needed
        //input
        int railsSection { get; set; }
        //output
        int numberRails { get; set; }

        //gate materials needed
        //input 
        int number3ftGates { get; set; }
        int number8ftGates { get; set; }
        //output
        int latches { get; set; }
        int hinges { get; set; }
        int caneBolts { get; set; }



       public FenceCalculator getFenceVars()
        {
            return this;
        }

        public void setFenceLength(int fenceLength)
        {
            this.fenceLength = fenceLength;
        }
        public void setPostDistance(int postDistance)
        {
            this.postDistance = postDistance;
        }

        public void setPicketWidth(int picketWidth)
        {
            this.picketWidth = picketWidth;
        }
        public void setPicketSpace(int picketSpace)
        {
            this.picketSpace = picketSpace;
        }

        public void setRails(int railsSection)
        {
            this.railsSection = railsSection;
        }

        public void set3Gates(int number3ftGates)
        {
            this.number3ftGates = number3ftGates;
        }

        public void set8Gates(int number8ftGates)
        {
            this.number8ftGates = number8ftGates;
        }

        public int toInches(int feet)
        {
            return feet * 12;
        }

        public int getNumberPosts()
        {
            return numberPosts;
        }
        public int getNumberSections()
        {
            return numberSections;
        }
        public int getNumberRails()
        {
            return numberRails;
        }
        public int getNumberPickets()
        {
            return numberPickets;
        }
        public int getLatches()
        {
            return latches;
        }
        public int getCaneBolts()
        {
            return caneBolts;
        }
        public int getHinges()
        {
            return hinges;
        }

        public bool getTen()
        {
            return extraTen;
        }
        public void setTen(bool ten)
        {
            extraTen = ten;
        }

        public int getExtra()
        {
            return customExtra;
        }

        public void setExtra(int extra)
        {
            customExtra = extra;
        }

        public void calculate()
        {
            //calculate posts and sections
            if (fenceLength != 0 && postDistance != 0)
            {
                numberPosts = (int)Math.Ceiling( ((decimal)fenceLength / (decimal)postDistance) + 1);
            }

            if (numberPosts != 0)
            {
                numberSections = numberPosts - 1;
            }

            //calculate the number of pickets
            if (fenceLength != 0 && picketWidth != 0)
            {
                numberPickets = (int)Math.Ceiling((double)(toInches(fenceLength)) / (( ((double)(picketWidth)) /8.0) + (((double)(picketSpace)) / 8.0)) );
            }
            //number of rails plus rails for gates
            numberRails = (numberSections * railsSection) + (4 * number3ftGates) + (8 * number8ftGates);

            //add in gate materials
            caneBolts = number8ftGates;
            
            hinges = (2 * number3ftGates) + (4 * number8ftGates);

            latches = number3ftGates + number8ftGates;

        }
    }
}
