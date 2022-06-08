using System.Collections.Generic;

using Divine.Entity.Entities.Units.Heroes.Components;
using Divine.Input;
using Divine.Menu.Items;
using Divine.Numerics;
using Divine.Renderer;

namespace betterautopick
{
    public class menu_handler
    {
        public RootMenu BaseMenu { get; set; }

        public menu_handler(betterautopick main)
        {
            Factory = Divine.Menu.MenuManager.CreateRootMenu("Techies Crappahilation");
            Factory.SetFontColor(Color.Violet);
        }
}