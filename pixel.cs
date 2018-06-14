using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_hw
{
    class CPixel
    {
        
        private Color m_color;

        public Color color
        {
            get { return m_color; }
            set
            {
                if ( m_color.IsEmpty )
                {
                    m_color = value;
                    return;
                }

                if ( Color.Black != m_color )
                    throw new Exception("Only black pixels can be recolored");

                m_color = value;
            }
        }

        public bool is_black { get { return Color.Black == m_color; } }

    } // class CPixel

} // namespace att_hw
