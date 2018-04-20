using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class Screen
	{
		public virtual void LoadContent(ContentManager content) { }
		public virtual void Update() { }
		public virtual void Draw(SpriteBatch spriteBatch) { }
	}
}
