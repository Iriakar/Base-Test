using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
	class ScreenManager
	{
		public static List<Screen> Screens = new List<Screen>();

		public static void Initialize() {
			Screens.Add(new ScreenGame());
			Screens[Screens.Count - 1].LoadContent();
		}

		public static void Update() {
			Screens[Screens.Count - 1].Update();
		}

		public static void Draw(SpriteBatch spriteBatch) {
			Screens[Screens.Count - 1].Draw(spriteBatch);
		}
	}
}
