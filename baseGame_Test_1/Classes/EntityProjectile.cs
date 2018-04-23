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
	class EntityProjectile : Entity
	{
		private Vector2 MousePos { get; set; }
		private Vector2 Temp;
		private float Offset { get; set; }
		public override void Initialize() {
			this.EntityType = Enumerations.EntityType.Projectile;
			this.Offset = 48;
		}
		public override void Update() {
			//Placeholder: Assign the position of the projectile to be the length of Offset away from
			//EntitySquare towards the position of MousePos

			MousePos = Mouse.GetState().Position.ToVector2();
			Pos = EntityFunctions.Entities[0].Pos 
				+ new Vector2(EntityFunctions.Entities[0].Sprite.Width/4, EntityFunctions.Entities[0].Sprite.Height/4) 
				+ Offset * Vector2.Normalize(Vector2.Subtract(MousePos, EntityFunctions.Entities[0].Pos));
		}

		public override void Draw(SpriteBatch spriteBatch) {
			spriteBatch.Draw(Sprite, Pos, Color.White);
			spriteBatch.DrawString(DataClass.Text, Temp.ToString(), new Vector2(0, 0), Color.White);
		}
	}
}
