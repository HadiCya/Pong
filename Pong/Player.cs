using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Pong
{
    public class Player
    {
        public Rectangle rect;
        int playerNumber;
        float moveSpeed = 500f;

        public Player(int playerNumber) 
        {
            this.playerNumber = playerNumber;
            rect = new Rectangle((this.playerNumber == 0 ? 80 : 520), 140, 40, 200);
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kstate = Keyboard.GetState();
            if (this.playerNumber == 0)
            {
                if (kstate.IsKeyDown(Keys.W))
                {
//                    Debug.WriteLine("Up!");
                    if(rect.Y >0)
                    rect.Y -= (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
                }
                if (kstate.IsKeyDown(Keys.S))
                {
                    if(rect.Y <  Globals.HEIGHT - rect.Height)
                    rect.Y += (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
                }
            } else 
            {
                if (kstate.IsKeyDown(Keys.Up))
                {
                    if (rect.Y > 0)
                        rect.Y -= (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
                }
                if (kstate.IsKeyDown(Keys.Down))
                {
                    if (rect.Y < Globals.HEIGHT - rect.Height)
                        rect.Y += (int)(moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
                }
            }
        }

        public void Draw()
        {
            Globals.spriteBatch.Draw(Globals.pixel, rect, Color.White);
        }
    }

    


}
