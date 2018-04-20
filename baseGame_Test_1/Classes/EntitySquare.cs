using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class EntitySquare : Entity
	{
		public override void Initialize() {
			this.EntityType = Enumerations.EntityType.Square;
		}

		public override void Update() {

		}

		public override void Draw(SpriteBatch spriteBatch) {
			spriteBatch.Draw(Sprite, Pos, Color.White);
		}
	}
}
