using System.Collections.Generic;
using System;

namespace QueenAttackNS.Objects
{
  public class QueenAttack
  {
    private int _x;
    private int _y;
    private static QueenAttack _currentQueenAttack;
    public string message;

    public QueenAttack(int x, int y)
    {
      _x = x;
      _y = y;
      _currentQueenAttack = this;
    }
  
    public int GetX() { return _x; }
    public int GetY() { return _y; }

    public static QueenAttack GetQueen() {
      return _currentQueenAttack;
    }

    public bool CanAttack(int x, int y)
    {
      return _x == x || _y == y || Math.Abs(x - _x) == Math.Abs(y - _y);
    }

  } // end class
} // end namespace
