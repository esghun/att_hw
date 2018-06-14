using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att_hw
{
    class CIslandPainter
    {
        private static readonly Tuple<int, int>[] ma_neighbours;

        static CIslandPainter()
        {
            ma_neighbours = new Tuple<int, int>[]
            {
                new Tuple<int, int>(-1, -1),
                new Tuple<int, int>(-1,  0),
                new Tuple<int, int>(-1,  1),
                new Tuple<int, int>( 0,  1),
                new Tuple<int, int>( 1,  1),
                new Tuple<int, int>( 1,  0),
                new Tuple<int, int>( 1, -1),
                new Tuple<int, int>( 0, -1),
            };
        }

        public static int paint(CBoard _board, CColorGenerator _color_generator)
        {
            int n_isle_count = 0;

            for ( int x = 0; x < _board.width; x++ )
                for ( int y = 0; y < _board.height; y++ )
                {
                    CPixel _pixel = _board.pixel(x, y);
                    if ( !_pixel.is_black )
                        continue;

                    n_isle_count++;

                    paint_isle(x, y, _color_generator.generate_color(), _board);
                }

            return n_isle_count;
        }


        private static void paint_isle(int n_src_x, int n_src_y, Color _color, CBoard _board)
        {        
            Stack<CPathNode> _path = new Stack<CPathNode>();

            paint_n_push(n_src_x, n_src_y, _color, _board, _path);

            while ( 0 != _path.Count )
            {
                bool b_is_painted = false;

                CPathNode _path_node = _path.Peek();
                int n_center_x = _path_node.x;
                int n_center_y = _path_node.y;

                for ( int i = _path_node.next_neighbour_ind; i < ma_neighbours.Length; i++ )
                {
                    int n_neighbour_x = n_center_x + ma_neighbours[_path_node.next_neighbour_ind].Item1;
                    int n_neighbour_y = n_center_y + ma_neighbours[_path_node.next_neighbour_ind].Item2;

                    _path_node.next_neighbour_ind++;

                    if ( 0 > n_neighbour_x || _board.width <= n_neighbour_x )
                        continue;
                    if ( 0 > n_neighbour_y || _board.height <= n_neighbour_y )
                        continue;
                    
                    CPixel _neighbour = _board.pixel(n_neighbour_x, n_neighbour_y);
                    if ( _neighbour.is_black )
                    {
                        paint_n_push(n_neighbour_x, n_neighbour_y, _color, _board, _path);
                        b_is_painted = true;
                        break;
                    }
                }

                if ( b_is_painted )
                    continue;
                
                _path.Pop();
            }

        } // paint_isle()


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int x: 
            int y: 
            Color _color: 
            CBoard _board: 
            Stack<CPathNode> _path: 
        \* --------------------------------------------------------------------------------- */
        private static void paint_n_push(int x, int y, Color _color, CBoard _board, Stack<CPathNode> _path)
        {
            _board.pixel(x, y).color = _color;
            _path.Push( new CPathNode(x, y) );
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        class CPathNode
        {
            public readonly int x;
            public readonly int y;

            public int next_neighbour_ind = 0;

            public CPathNode(int n_x, int n_y)
            {
                x = n_x;
                y = n_y;
            }
        }

    } // class CIslandPainter

} // namespace att_hw
