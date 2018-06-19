using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_hw
{
    // The class holds an entire board as a single dimentional array of integers
    class CBoard
    {
        public readonly int width;
        public readonly int height;

        private readonly int[] ma_pixels;
        private readonly int mn_BLACK;
        private readonly int mn_WHITE;


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            decimal _width: 
            decimal _height: 
        \* --------------------------------------------------------------------------------- */
        public CBoard(decimal _width, decimal _height)
        {
            width  = (int)_width;
            height = (int)_height;

            mn_BLACK = Color.Black.ToArgb();
            mn_WHITE = Color.White.ToArgb();

            ma_pixels = new int[width * height];

            reset();
        }


        /* --------------------------------------------------------------------------------- *\
          Description: Clear a board
        \* --------------------------------------------------------------------------------- */
        public void reset()
        {
            for ( int i = 0; i < ma_pixels.Length; i++ )
                ma_pixels[i] = mn_WHITE;
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int x: 
            int y: 
        
          Returns Color:
        \* --------------------------------------------------------------------------------- */
        public Color get_pixel_color(int x, int y)
        {
            return Color.FromArgb( ma_pixels[ pixel_ind(x, y) ] );
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int x: 
            int y: 
        
          Returns bool:
        \* --------------------------------------------------------------------------------- */
        public bool is_black_pixel(int x, int y)
        {
            int n_pixel_ind = pixel_ind(x, y);
            int n_pixel_value = ma_pixels[ n_pixel_ind ];
            bool b_is_same = mn_BLACK == n_pixel_value;
            return b_is_same;
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int x: 
            int y: 
            int n_color: 
        \* --------------------------------------------------------------------------------- */
        public void set_pixel_color(int x, int y, int n_color)
        {
            set_pixel_color( pixel_ind(x, y), n_color );
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int n_pixel_ind: 
            int n_color: 
        \* --------------------------------------------------------------------------------- */
        public void set_pixel_color(int n_pixel_ind, int n_color)
        {
            if ( mn_WHITE == ma_pixels[n_pixel_ind] )
            {
                ma_pixels[ n_pixel_ind ] = n_color;
                return;
            }

            if ( mn_BLACK != ma_pixels[ n_pixel_ind ] )
                throw new Exception("Only black pixels can be recolored");

            ma_pixels[ n_pixel_ind ] = n_color;
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            IntPtr p_dst: 
        \* --------------------------------------------------------------------------------- */
        public void get_all_pixels(IntPtr p_dst)
        {
            System.Runtime.InteropServices.Marshal.Copy(ma_pixels, 0, p_dst, ma_pixels.Length);
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int x: 
            int y: 
        
          Returns int:
        \* --------------------------------------------------------------------------------- */
        private int pixel_ind(int x, int y)
        {
            return y * width + x;
        }

    } // class CBoard

} // namespace att_hw
