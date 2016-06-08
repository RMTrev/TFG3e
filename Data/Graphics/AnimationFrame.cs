using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Graphics
{
    public class AnimationFrame
    {
        private int m_TileNum;
        public int TileNum
        {
            get
            {
                return m_TileNum;
            }
        }

        private int m_Duration;
        public int Duration
        {
            get
            {
                return m_Duration;
            }
        }

        private Color m_FilterColor;
        public Color FilterColor
        {
            get
            {
                return m_FilterColor;
            }
        }

        public AnimationFrame(int tileNum, int duration, Color filterColor)
        {
            m_TileNum = tileNum;
            m_Duration = duration;
            m_FilterColor = filterColor;
        }
    }
}
