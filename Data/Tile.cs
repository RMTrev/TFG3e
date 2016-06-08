using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    class Tile
    {
        private bool m_Passable;
        public bool Passable
        {
            get
            {
                return m_Passable;
            }
        }

        private Texture2D m_Texture;
        public Texture2D Texture
        {
            get
            {
                return m_Texture;
            }
        }

        private Rectangle m_Rect;
        public Rectangle Rect
        {
            get
            {
                return m_Rect;
            }
        }

        public Tile()
        {

        }
    }
}
