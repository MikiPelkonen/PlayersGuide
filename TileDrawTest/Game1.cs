using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TileDrawTest
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Tile _testTile;
        private Tile _testTileTwo;
        private Tile _testTileThree;
        private Tile _testTileFour;
        private Tile _testTileFive;
        private Tile _testTileSix;
        private Tile _testTileSeven;
        private Tile _testTileEight;
        private Tile _testTileNine;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferHeight = 400;
            _graphics.PreferredBackBufferWidth = 400;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            _testTile = new Tile(GraphicsDevice, TileType.Grass);
            _testTileTwo = new Tile(GraphicsDevice, TileType.Water);
            _testTileThree = new Tile(GraphicsDevice, TileType.Grass);
            _testTileFour = new Tile(GraphicsDevice, TileType.Grass);
            _testTileFive = new Tile(GraphicsDevice, TileType.Water);
            _testTileSix = new Tile(GraphicsDevice, TileType.Grass);
            _testTileSeven = new Tile(GraphicsDevice, TileType.Grass);
            _testTileEight = new Tile(GraphicsDevice, TileType.Water);
            _testTileNine = new Tile(GraphicsDevice, TileType.Grass);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _testTile.Update(gameTime);
            _testTileTwo.Update(gameTime);
            _testTileThree.Update(gameTime);
            _testTileFour.Update(gameTime);
            _testTileFive.Update(gameTime);
            _testTileSix.Update(gameTime);
            _testTileSeven.Update(gameTime);
            _testTileEight.Update(gameTime);
            _testTileNine.Update(gameTime);


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _testTile.Draw(_spriteBatch, gameTime, new Vector2(64, 64));
            _testTileTwo.Draw(_spriteBatch, gameTime, new Vector2(64 * 2, 64));
            _testTileThree.Draw(_spriteBatch, gameTime, new Vector2(64 * 3, 64));
            _testTileFour.Draw(_spriteBatch, gameTime, new Vector2(64, 64 * 2));
            _testTileFive.Draw(_spriteBatch, gameTime, new Vector2(64 * 2, 64 * 2));
            _testTileSix.Draw(_spriteBatch, gameTime, new Vector2(64 * 3, 64 * 2));
            _testTileSeven.Draw(_spriteBatch, gameTime, new Vector2(64, 64 * 3));
            _testTileEight.Draw(_spriteBatch, gameTime, new Vector2(64 * 2, 64 * 3));
            _testTileNine.Draw(_spriteBatch, gameTime, new Vector2(64 * 3, 64 * 3));
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
