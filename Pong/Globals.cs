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

namespace Pong
{
    class Globals
    {
        public static ContentManager content;
        public static SpriteBatch spriteBatch;
        public static Texture2D pixel;
        public static int WIDTH, HEIGHT;
        public static int player1_score=0;
        public static int player2_score = 0;
    }
}
