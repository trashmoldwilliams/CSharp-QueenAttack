using System.Collections.Generic;
using System;

namespace QueenAttackNS.Objects
{
  public class QueenAttack
  {
    private int _x;
    private int _y;

    public QueenAttack(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public int GetX() { return _x; }
    public int GetY() { return _y; }

    public bool CanAttack()
    {
      return true;
    }

  } // end class
} // end namespace
