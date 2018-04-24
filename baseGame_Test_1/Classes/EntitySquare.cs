using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class EntitySquare : Entity
	{
		private float SprintFactor;

		public override void Initialize() {
			EntityType = Enumerations.EntityType.Square;
			Speed = 1;
		}

		public override void Update() {
			if (InputHandler.IsKeyPress(Keys.LeftShift)) { SprintFactor = 3.5f; }
			else { SprintFactor = 1; }

			if (InputHandler.IsKeyPress(Keys.S)) {
				NewPos.Y += Speed*SprintFactor;
			}
			if (InputHandler.IsKeyPress(Keys.W))
			{
				NewPos.Y -= Speed * SprintFactor;
			}
			if (InputHandler.IsKeyPress(Keys.A))
			{
				NewPos.X -= Speed * SprintFactor;
			}
			if (InputHandler.IsKeyPress(Keys.D))
			{
				NewPos.X += Speed * SprintFactor;
			}
			Pos = NewPos;
		}

		public override void Draw(SpriteBatch spriteBatch) {
			spriteBatch.Draw(Sprite, Pos, Color.White);
		}
	}
}
