using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
	class dataClass
	{
		public static Texture2D Square;

		public static void LoadContent(ContentManager content) {
			Square = content.Load<Texture2D>("Square");
		}
	}
}
