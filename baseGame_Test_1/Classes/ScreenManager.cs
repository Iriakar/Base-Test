using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class ScreenManager
	{
		public static List<Screen> Screens;
		public static void LoadContent(ContentManager content) {
			DataClass.LoadContent(content);
			Screens = new List<Screen>() { new ScreenGame() };
			Screens[Screens.Count() - 1].LoadContent(content);
		}
		public static void Update() {
			Screens[Screens.Count() - 1].Update();
		}
		public static void Draw(SpriteBatch spriteBatch) {
			spriteBatch.Begin();
			Screens[Screens.Count() - 1].Draw(spriteBatch);
			spriteBatch.End();
		}
	}
}
