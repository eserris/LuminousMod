using Terraria.ModLoader;

namespace LuminousMod
{
	class LuminousMod : Mod
	{
		public LuminousMod()
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
