using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
	abstract class Screen
	{
		public virtual void LoadContent() { }
		public virtual void Update() { }
		public virtual void Draw(SpriteBatch spriteBatch) { }
	}
}
