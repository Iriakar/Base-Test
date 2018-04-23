using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class Entity
	{
		public Enumerations.EntityType EntityType { get; set; }
		public Texture2D Sprite { get; set; }
		public Vector2 Pos, NewPos;
		public float Speed { get; set; }

		public virtual void Initialize() { }
		public virtual void Update() { }
		public virtual void Draw(SpriteBatch spriteBatch) { }
		
	}
}
