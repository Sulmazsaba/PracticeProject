using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
   public class IndexedNames 
   {
        public static int ArraySize = 10;
       public string[] NumList=new string[ArraySize];

        public IndexedNames()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                NumList[i] = "default value";
            }
        }

        public string this[int index]
        {
            get
            {
                string temp="";
                if (index >= 0 && index < ArraySize)
                    temp = NumList[index];

                return temp;
            }
            set
            {
                if (index >= 0 && index < ArraySize)
                    NumList[index] = value;

            }
        }

        public int this[string name]
        {
            get
            {
                int indexNum = 0;
                while (indexNum<ArraySize)
                {
                    if (NumList[indexNum] == name)
                    {
                        return indexNum;
                    }
                    indexNum++;
                }
                  
                

                return indexNum;
            }
        }

   }
}
