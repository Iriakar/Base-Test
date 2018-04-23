using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace baseGame_Test_1
{
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}

		protected override void Initialize()
		{
			base.Initialize(); IsMouseVisible = true;
			this.graphics.PreferredBackBufferHeight = 720;
			this.graphics.PreferredBackBufferWidth = 1280;
			this.graphics.ApplyChanges();
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);
			ScreenManager.LoadContent(Content);
		}

		protected override void UnloadContent() { }

		protected override void Update(GameTime gameTime)
		{
			ScreenManager.Update();
			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
			ScreenManager.Draw(spriteBatch);
			base.Draw(gameTime);
		}
	}
}
