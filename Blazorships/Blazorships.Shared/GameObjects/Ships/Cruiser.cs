//From https://github.com/exceptionnotfound/BattleshipModellingPractice
using Blazorships.Shared.Helpers;

namespace Blazorships.Shared.GameObjects
{
  public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Width = 3;
            OccupationType = OccupationType.Cruiser;
        }
    }
}