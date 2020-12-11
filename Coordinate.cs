using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
  public struct Coordinate
  {
      private int _x;
      private int _y;

      public int X
      {
          get => _x;
          set
          {
              _x = value;
              CoordinatesChanged(_x);
          }
      }

      public int Y
      {
          get => _y;
          set
          {
              _y = value;
              CoordinatesChanged(_y);
          }
      }

      public event Action<int> CoordinatesChanged ;

  }
}
