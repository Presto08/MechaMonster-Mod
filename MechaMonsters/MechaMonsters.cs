using Terraria.ModLoader;

namespace MechaMonsters
{
	class MechaMonsters : Mod
	{

		public MechaMonsters()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}
	}
}
