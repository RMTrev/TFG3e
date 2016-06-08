using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Graphics
{
    public class Animation
    {
        private Texture2D m_Texture;

        private int m_TileWidth;
        private int m_TileHeight;

        private AnimationFrame[] m_Frames;

        private int m_CurrentFrame;
        private int m_TimeLeftOnFrame;
        private Vector2 m_Position;

        private bool m_Finished;
        public bool Finished
        {
            get
            {
                return m_Finished;
            }
        }

        public Animation(Texture2D texture, int tileWidth, int tileHeight, AnimationFrame[] frames)
        {
            m_Texture = texture;
            m_TileWidth = tileWidth;
            m_TileHeight = tileHeight;
            m_Frames = frames;
            m_CurrentFrame = 0;
            m_TimeLeftOnFrame = frames[0].Duration;
        }

        public void Update(bool loop)
        {
            if (m_Finished)
            {
                if(loop)
                {
                    m_Finished = false;
                    m_CurrentFrame = 0;
                    m_TimeLeftOnFrame = m_Frames[0].Duration;
                }
            }

            AnimationFrame currentFrame = m_Frames[m_CurrentFrame];

            if(m_TimeLeftOnFrame <= 0)
            {
                m_CurrentFrame++;
                currentFrame = m_Frames[m_CurrentFrame];
                m_TimeLeftOnFrame = currentFrame.Duration;
            }

            m_TimeLeftOnFrame--;

            if(m_TimeLeftOnFrame == 0 && m_CurrentFrame == m_Frames.Length - 1)
            {
                m_Finished = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Draw(spriteBatch, m_Position);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            AnimationFrame currentFrame = m_Frames[m_CurrentFrame];
            int curRow = currentFrame.TileNum / 16;
            int curCol = currentFrame.TileNum % 16;
            int minX = m_TileWidth * curCol;
            int minY = m_TileHeight * curRow;
            Rectangle rect = new Rectangle(minX, minY, m_TileWidth, m_TileHeight);

            spriteBatch.Draw(m_Texture, position, rect, currentFrame.FilterColor);
        }
    }
}
