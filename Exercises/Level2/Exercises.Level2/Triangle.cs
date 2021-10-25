using System;

namespace Exercises.Level2
{
    public class Triangle
    {
        /// <summary>
        /// Note: compleete half trangle first
        /// 
        /// The program:
        ///  You must create a triangle. 
        ///  n is the number of lines a triangle will have.
        ///  Triangle body has to be made out of "*",
        ///  so result should for 3 be like:
        ///  * 
        /// ***
        ///*****
        /// 
        /// Example of 5:
        /// 
        ///    *
        ///   ***
        ///  *****
        /// *******
        ///*********
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] GetTRiangle(int n)
        {
            var stringArray = new string[n];
            string spaces = "";
            string stars = "";

            for (int i = 0; i < n; i++)
            {
                spaces = spaces + " ";
            }

			for (int i = 0; i < n; i++)
			{
                if (i == 0)
                {
                    stars = "*";
                }
                else
                {
                    stars = stars + "**";
                }
                spaces = spaces.Substring(0, spaces.Length - 1);
                stringArray[i] = spaces + stars;
            }
            return stringArray;
        }
    }
}
