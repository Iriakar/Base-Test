using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseGame_Test_1
{
	class EntityFunctions
	{
		public static List<Entity> Entities;

		public static void LoadContent() { Entities = new List<Entity>(); }

		public static void LoadEntity(Entity entity, Vector2 pos) {
			Entities.Add(entity);
			entity.Initialize();
			entity.Pos = pos;

			if (entity.EntityType == Enumerations.EntityType.Square) {
				entity.Sprite = DataClass.Square;
			}
		}
	}
}
