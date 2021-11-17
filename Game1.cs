using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_2___Scaling_Using_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectTexture;
        Rectangle rectRectangle;

        Texture2D circTexture;
        Rectangle circRectangle;

        SpriteFont textFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 600;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            rectRectangle = new Rectangle(10, 10, 50, 50);
            circRectangle = new Rectangle(10, 200, 50, 50);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectTexture = Content.Load<Texture2D>("rectangle");
            circTexture = Content.Load<Texture2D>("circle");
            textFont = Content.Load<SpriteFont>("TextFont");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);


            // TODO: Add your drawing code here
            _spriteBatch.Begin();




            _spriteBatch.Draw(rectTexture, new Rectangle(0, 700, 800, 800), Color.Ivory);




            //body
            _spriteBatch.Draw(rectTexture, new Rectangle(100, 150, 400, 450), Color.Yellow);
            
            //pants
            _spriteBatch.Draw(rectTexture, new Rectangle(100, 500, 400, 100), Color.Brown);
            // eye and pupil
            _spriteBatch.Draw(circTexture, new Rectangle(125, 200, 150, 150), Color.White);
            _spriteBatch.Draw(circTexture, new Rectangle(150, 225, 100, 100), Color.CornflowerBlue);
            _spriteBatch.Draw(circTexture, new Rectangle(175, 250, 50, 50), Color.Black);
            _spriteBatch.Draw(circTexture, new Rectangle(165, 245, 20, 20), Color.White);

            //eye and pupil 2
            _spriteBatch.Draw(circTexture, new Rectangle(325, 200, 150, 150), Color.White);
            _spriteBatch.Draw(circTexture, new Rectangle(350, 225, 100, 100), Color.CornflowerBlue);
            _spriteBatch.Draw(circTexture, new Rectangle(375, 250, 50, 50), Color.Black);
            _spriteBatch.Draw(circTexture, new Rectangle(365, 245, 20, 20), Color.White);
            //mouth
            _spriteBatch.Draw(rectTexture, new Rectangle(200, 410, 200, 10), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(300, 420, 30, 30), Color.White);
            _spriteBatch.Draw(rectTexture, new Rectangle(260, 420, 30, 30), Color.White);
            //sponge holes
            _spriteBatch.Draw(circTexture, new Rectangle(400, 165, 30, 30), Color.DarkGoldenrod);
            _spriteBatch.Draw(circTexture, new Rectangle(400, 350, 30, 30), Color.DarkGoldenrod);
            _spriteBatch.Draw(circTexture, new Rectangle(200, 160, 30, 30), Color.DarkGoldenrod);
            _spriteBatch.Draw(circTexture, new Rectangle(150, 450, 30, 30), Color.DarkGoldenrod);
            _spriteBatch.Draw(circTexture, new Rectangle(110, 400, 30, 30), Color.DarkGoldenrod);
            _spriteBatch.Draw(rectTexture, new Rectangle(200, 600, 10, 100), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(400, 600, 10, 100), Color.Black);



            _spriteBatch.DrawString(textFont, "Spongebab", new Vector2(100, 100), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
