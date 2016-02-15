using Nancy;
using QueenAttackNS.Objects;
using System.Collections.Generic;

namespace QueenAttackNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["queen.cshtml", "Tell me where your queen is"];
      };

      Get["/queen/{x}/{y}"] = parameters => {
        string output = "Choose a square to attack.";
        QueenAttack queenAttack = new QueenAttack(parameters.x, parameters.y);
        queenAttack.message = output;
        return View["canattack.cshtml", queenAttack];
      };

      Get["/attack/{x}/{y}"] = parameters => {
        string output = "Cannot attack!";
        QueenAttack currentQueenAttack = QueenAttack.GetQueen();
        if (currentQueenAttack.CanAttack(parameters.x, parameters.y)) {
          output = "Take the piece!";
        }
        currentQueenAttack.message = output;
        return View["canattack.cshtml", currentQueenAttack];
      };
    }
  }
}
