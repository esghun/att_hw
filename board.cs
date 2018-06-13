using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_hw
{
    class CBoard
    {
        private readonly CPixel[,] m_pixels;

        public CBoard(decimal _width, decimal _height)
        {
            m_pixels = new CPixel[(int)_width, (int)_height];

            for ( int i = 0; i < width; i++ )
                for ( int j = 0; j < height; j++ )
                    m_pixels[i, j] = new CPixel();
                    
        }

        public int width { get { return m_pixels.GetLength(0); } }
        public int height { get { return m_pixels.GetLength(1); } }

        public CPixel pixel(int x, int y)
        {
            return m_pixels[x, y];
        }

    } // class CBoard

} // namespace att_hw
