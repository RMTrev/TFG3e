using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Graphics;

namespace TFG3k
{
    class Hud
    {
        private bool m_Visible;
        public bool Visible
        {
            get
            {
                return m_Visible;
            }
        }

        private int m_Offset;
        public int Offset
        {
            get
            {
                return m_Offset;
            }
        }

        private int m_HealthMax;
        public int HealthMax
        {
            get
            {
                return m_HealthMax;
            }
            set
            {
                m_HealthMax = value;
            }
        }

        private int m_HealthCurrent;
        public int HealthCurrent
        {
            get
            {
                return m_HealthCurrent;
            }
            set
            {
                m_HealthCurrent = value;
            }
        }

        private Texture2D hudTexture;
        private Animation healthFullAnimation;
        private Animation healthEmptyAnimation;

        public Hud(ContentManager Content)
        {
            hudTexture = Content.Load<Texture2D>("hud");
            AnimationFrame[] frames = new AnimationFrame[]
            {
                new AnimationFrame(240, 10, Color.White),
                new AnimationFrame(241, 10, Color.White),
                new AnimationFrame(242, 10, Color.White),
                new AnimationFrame(243, 10, Color.White),
                new AnimationFrame(244, 10, Color.White),
                new AnimationFrame(243, 10, Color.White),
                new AnimationFrame(242, 10, Color.White),
                new AnimationFrame(241, 10, Color.White)
            };
            healthFullAnimation = new Animation(hudTexture, 16, 16, frames);

            frames = new AnimationFrame[]
            {
                new AnimationFrame(245, 10, Color.White)
            };
            healthEmptyAnimation = new Animation(hudTexture, 16, 16, frames);

            m_Visible = true;
            m_Offset = 0;
        }

        public void DrawHud(SpriteBatch spriteBatch)
        {
            if (!m_Visible) return;

            Vector2 drawPoint = Vector2.Zero;

            healthFullAnimation.Update(true);
            healthEmptyAnimation.Update(true);

            for(int i = 0; i < m_HealthMax; i++)
            {
                if (i < m_HealthCurrent)
                    healthFullAnimation.Draw(spriteBatch, drawPoint);
                else
                    healthEmptyAnimation.Draw(spriteBatch, drawPoint);

                drawPoint.X += 4;
            }
        }
    }
}
