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
using System.ComponentModel;

namespace Pong
{
    public class Ball
    {
        Rectangle rect;
        //Is it going right?
        int isRight;
        // is it going to the top
        int isTop;

        public Ball()
        {
            rect = new Rectangle(Globals.WIDTH / 2 - 20, Globals.HEIGHT / 2 - 20, 40, 40);
            isRight = 1;
            isTop = 1;
            
        }

        public void Update(GameTime gameTime, Player player1, Player player2)
        {
            // TODO remove this lol 
            if (rect.X > Globals.WIDTH)
            {
                //Give point to Player 1
            }
            else if (rect.X < 0)
            {                
                //Give point to Player 2
            }
            else if (rect.Y > Globals.HEIGHT)
            {
                rect.X += isRight*-1;
                rect.Y += isTop*-1;
            }
            else if (rect.Y < 0)
            {
                rect.X += isRight;
                rect.Y += isTop;
            } else
            {
                rect.X += isRight;
                rect.Y += isTop;
            }

            //Colliding with a player
            if(player1.rect.Right > rect.Left && rect.Top > player1.rect.Top && rect.Bottom < player1.rect.Bottom)
            {
                isRight = 1;
                
            }

            if (player2.rect.Left < rect.Right && rect.Top > player2.rect.Top && rect.Bottom < player2.rect.Bottom)
            {
                isRight = -1;
            }
            
            // Colliding with screen
            if(rect.X < 0)
            {
                Globals.player1_score += 1;
                isRight *= -1;
            }
            if (rect.X > Globals.WIDTH - rect.Width)
            {
                Globals.player2_score += 1;
                isRight *= -1;
            }
            if (rect.Y < 0)
            {
                
                isTop *= -1;
            }
         
            if (rect.Y > Globals.HEIGHT - rect.Height)
            {
                isTop *= -1;
                
            }


        }

        public void Draw()
        {
            Globals.spriteBatch.Draw(Globals.pixel, rect, Color.White);
        }
    }




}
