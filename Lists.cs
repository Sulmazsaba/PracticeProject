using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
  public  class Lists
    {

        public SortedList<int,string> CreateStoredList()
        {

            SortedList<int,string> sortedList=new SortedList<int, string>();
            sortedList.Add(1,"jdfdjf");
            sortedList.Add(1,"dkjfbb");
            return sortedList;
        }

    }
}
