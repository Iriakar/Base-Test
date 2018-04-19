using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
	class ScreenGame : Screen
	{
		KeyboardState lastState, currState;
		Texture2D square;
		Vector2 sPos;
		float multiplier = 1;

		public override void LoadContent() {
			square = dataClass.Square;
			sPos = new Vector2(0, 0);

			lastState = currState = new KeyboardState();
		}

		public override void Update()
		{
			lastState = currState;
			currState = Keyboard.GetState();

			if (currState.IsKeyDown(Keys.LeftShift))
			{
				multiplier = 4;
			}

			else { multiplier = 1; }

			if (currState.IsKeyDown(Keys.S)) {
				sPos.Y += 1*multiplier;
			}

			if (currState.IsKeyDown(Keys.W))
			{
				sPos.Y -= 1 * multiplier;
			}

			if (currState.IsKeyDown(Keys.A))
			{
				sPos.X -= 1 * multiplier;
			}

			if (currState.IsKeyDown(Keys.D))
			{
				sPos.X += 1 * multiplier;
			}
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Begin();
			spriteBatch.Draw(square, sPos, Color.White);
			spriteBatch.End();
		}
	}
}
