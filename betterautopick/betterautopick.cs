using System.Linq;

using Divine.Entity;
using Divine.Entity.Entities.Abilities;
using Divine.Entity.Entities.Abilities.Components;
using Divine.Entity.Entities.Units.Heroes;
using Divine.Entity.Entities.Units.Heroes.Components;
using Divine.Service;

namespace betterautopick
{
    public sealed class betterautopick : Bootstrapper
    {
        public Hero Me { get; set; }
    }
}
