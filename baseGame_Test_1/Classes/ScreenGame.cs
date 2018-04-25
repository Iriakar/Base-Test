using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class ScreenGame : Screen
	{
		public override void LoadContent(ContentManager content) {
			EntityFunctions.LoadContent();
			//EntityFunctions.LoadEntity(new EntityPlayer(), new Vector2(0, 0));
			EntityFunctions.LoadEntity(new EntityBouncer(), new Vector2(0, 0));
		}

		public override void Update() {
			InputHandler.UpdateStates();
			foreach (Entity entity in EntityFunctions.Entities) {
				entity.Update();
			}
		}

		public override void Draw(SpriteBatch spriteBatch) {
			foreach (Entity entity in EntityFunctions.Entities) {
				entity.Draw(spriteBatch);
			}
			//spriteBatch.DrawString(DataClass.Text, EntityFunctions.Entities.Count.ToString(), new Vector2(0, 60), Color.White);
			//spriteBatch.DrawString(DataClass.Text, EntityFunctions.Entities[0].Pos.ToString(), new Vector2(0, 0), Color.White);
		}
	}
}
