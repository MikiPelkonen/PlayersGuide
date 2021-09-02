using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using TileDrawTest.Noise;

namespace TileDrawTest
{
    public class Tile
    {
        Texture2D _texture;
        GraphicsDevice _graphicsDevice;
        TileType _type;

        int _currentUpdate;
        int _updatesPerFrame;


        public Tile(GraphicsDevice gd, TileType ttype)
        {
            _graphicsDevice = gd;
            _type = ttype;
            _texture = new Texture2D(_graphicsDevice, 64, 64);
            _updatesPerFrame = ttype switch
            {
                TileType.Grass => 20,
                TileType.Water => 10
            };
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime, Vector2 position)
        {
            spriteBatch.Draw(_texture, position, Color.White);
        }

        public void Update(GameTime gameTime)
        {
            _currentUpdate++;
            if (_currentUpdate == _updatesPerFrame)
            {
                _texture.SetData(UpdateColorData(_type));
                _currentUpdate = 0;
            }

            
            
        }

        Color[] UpdateColorData(TileType ttype)
        {
            Random _random = new Random();
            Color[] colorData = new Color[64 * 64];
            switch (ttype)
            {
                case TileType.Grass:
                    for (int i = 0; i < 4096; i++)
                    {
                        int random = 2;
                        if (i % 5 == 0)
                            random = _random.Next(1, 5);

                        colorData[i] = random switch
                        {
                            1 => Color.GreenYellow,
                            2 => Color.Green,
                            3 => Color.DarkGreen,
                            4 => Color.ForestGreen
                        };
                    }
                    break;
                case TileType.Water:
                    for (int row = 0; row < 64; row++)
                    {
                        for (int column = 0; column < 64; column++)
                        {
                            int index = row * 64 + column;
                            int random = _random.Next(1, 5);
                            if (row % 3 == 0)
                                random = 2;

                            if (column < _random.Next(10) || column > _random.Next(54, 65))
                            {
                                colorData[index] = random switch
                                {
                                    1 => Color.GreenYellow,
                                    2 => Color.Green,
                                    3 => Color.DarkGreen,
                                    4 => Color.ForestGreen
                                };
                            }
                            else
                            {
                                colorData[index] = random switch
                                {
                                    1 => Color.Aquamarine,
                                    2 => Color.Blue,
                                    3 => Color.Navy,
                                    4 => Color.DarkOliveGreen
                                };
                            }
                        }
                    }
                    break;
            }
            return colorData;
        }
    }
    public enum TileType { Grass, Water }
}
