using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class InputHandler
	{
		public static KeyboardState CurrKeyState, LastKeyState;

		public static void UpdateStates() {
			LastKeyState = CurrKeyState;
			CurrKeyState = Keyboard.GetState();
		}

		public static bool IsKeyPress(Keys key) {
			if (CurrKeyState.IsKeyDown(key)) { return true; }
			else return false;
		}
	}
}
