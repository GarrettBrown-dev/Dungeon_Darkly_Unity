using System.Collections.Generic;

namespace Dungeon_Darkly
{
  public partial class Action
  {
    public static void ViewEquip()
    {
      Dictionary<string, Item[]> equipped = TerminalManager.game.Players[0].Equip;
      Interpreter.DisplayOutput("Equipment:");
      foreach (KeyValuePair<string, Item[]> entry in equipped)
      {
        string equip = "";
        if (entry.Value[0] != null)
        {
          equip = entry.Value[0].Name;
        }
        else
        {
          equip = "<color=red>empty</color>";
        }
        Interpreter.DisplayOutput($"<color=yellow>{entry.Key}</color>: {equip}");
      }
    }
  }
}
