using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class DataClass
	{
		public static Texture2D Square;
		public static SpriteFont Text;

		public static void LoadContent(ContentManager content) {
			Square = content.Load<Texture2D>("Square");
			Text = content.Load<SpriteFont>("Text");
		}
	}

	class Enumerations
	{
		public enum EntityType { Square }
	}
}
