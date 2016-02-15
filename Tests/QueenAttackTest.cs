using Xunit;
using QueenAttackNS.Objects;

namespace QueenAttackNS
{
  public class QueenAttackTest
  {
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());

    }

    // Queen can attack on horizontal lines
    [Fact]
    public void CanAttack_Horizontally_true()
    {
      QueenAttack queen = new QueenAttack(8,2);
      Assert.Equal(true, queen.CanAttack(8,3));
    }

    // queen can attack on vertical lines
    [Fact]
    public void CanAttack_Vertically_true()
    {
      QueenAttack queen = new QueenAttack(8,2);
      Assert.Equal(true, queen.CanAttack(7,2));
    }

    // queen can attack diagonally
    [Fact]
    public void CanAttack_Diagonally_true()
    {
      QueenAttack queen = new QueenAttack(4, 4);
      Assert.Equal(true, queen.CanAttack(1,1));
      Assert.Equal(true, queen.CanAttack(8,8));
      Assert.Equal(true, queen.CanAttack(1,7));
      Assert.Equal(true, queen.CanAttack(7,1));
    }
    // queen can take letter coordinants
  }
}
