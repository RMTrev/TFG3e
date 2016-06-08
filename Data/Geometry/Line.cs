using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Geometry
{
    public class Line
    {
        private float m_X1;
        public float X1
        {
            get
            {
                return m_X1;
            }
        }

        private float m_Y1;
        public float Y1
        {
            get
            {
                return m_Y1;
            }
        }

        private float m_X2;
        public float X2
        {
            get
            {
                return m_X2;
            }
        }

        private float m_Y2;
        public float Y2
        {
            get
            {
                return m_Y2;
            }
        }

        public Line(float x1, float y1, float x2, float y2)
        {
            m_X1 = x1;
            m_Y1 = y1;
            m_X2 = x2;
            m_Y2 = y2;
        }
    }
}
