using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bottles
{
    class Song
    {
        public string CountBottles(int bottles)
        {
            string songText = "";

            for (int i = bottles; i >= 0; i--)
            {
                if (i == 0)
                {
                    songText += " No more bottles of beer on the wall.";
                }
                else if (i == 1)
                {
                    songText += i + " bottle of beer on the wall. "
                        + i + " bottle of beer."
                        + " Take one down and pass it around.";
                }
                else if (i == 2)
                {
                    songText += i + " bottles of beer on the wall. "
                        + i + " bottles of beer."
                        + " Take one down and pass it around. "
                        + "1 bottle of beer on the wall. ";
                }
                else
                {
                    songText += i + " bottles of beer on the wall. "
                        + i + " bottles of beer."
                        + " Take one down and pass it around. "
                        + (i - 1) + " bottles of beer on the wall. ";
                }
            }

            return songText;
        }
    }
}
