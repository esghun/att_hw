using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_hw
{

    // Class fore generating random unique color
    class CColorGenerator
    {
        private readonly HashSet<Color> mhs_colors = new HashSet<Color>();
        private readonly Random m_rndm = new Random();

        public CColorGenerator()
        {
            mhs_colors.Add( Color.White );
            mhs_colors.Add( Color.Black );
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
        
          Returns int:
        \* --------------------------------------------------------------------------------- */
        public int generate_color()
        {
            if ( mhs_colors.Count >= 0x1000000 )
                throw new Exception("Max possible number of colors reached");

            while (true)
            {
                Color _color = Color.FromArgb(m_rndm.Next(256), m_rndm.Next(256), m_rndm.Next(256));

                if ( mhs_colors.Add(_color) )
                    return _color.ToArgb();
            }
        }

    } // class CColorGenerator

} // namespace att_hw
