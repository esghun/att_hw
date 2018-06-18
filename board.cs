using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_hw
{
    class CBoard
    {
        public readonly int width;
        public readonly int height;

        private readonly int[] ma_pixels;
        private readonly int mn_BLACK;

        public CBoard(decimal _width, decimal _height)
        {
            width  = (int)_width;
            height = (int)_height;

            ma_pixels = new int[width * height];

            mn_BLACK = Color.Black.ToArgb();
        }

        public Color get_pixel_color(int x, int y)
        {
            return Color.FromArgb( ma_pixels[ pixel_ind(x, y) ] );
        }

        public bool is_black_pixel(int x, int y)
        {
            int n_pixel_ind = pixel_ind(x, y);
            int n_pixel_value = ma_pixels[ n_pixel_ind ];
            bool b_is_same = mn_BLACK == n_pixel_value;
            return b_is_same;
        }

        public void set_pixel_color(int x, int y, int n_color)
        {
            set_pixel_color( pixel_ind(x, y), n_color );
        }

        public void set_pixel_color(int n_pixel_ind, int n_color)
        {
            if ( default(int) == ma_pixels[n_pixel_ind] )
            {
                ma_pixels[ n_pixel_ind ] = n_color;
                return;
            }

            if ( mn_BLACK != ma_pixels[ n_pixel_ind ] )
                throw new Exception("Only black pixels can be recolored");

            ma_pixels[ n_pixel_ind ] = n_color;
        }

        public void get_all_pixels(IntPtr p_dst)
        {
            System.Runtime.InteropServices.Marshal.Copy(ma_pixels, 0, p_dst, ma_pixels.Length);
        }

        private int pixel_ind(int x, int y)
        {
            return y * width + x;
        }

    } // class CBoard

} // namespace att_hw
