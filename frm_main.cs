using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace att_hw
{
    public partial class FrmMain : Form
    {
        private CBoard m_board = null;
        private Random m_rndm = null;
        private Bitmap m_bmp = null;

        private CColorGenerator m_color_gnrtr = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRandomize_Click(object sender, EventArgs e)
        {
            if ( null == m_board )
            {
                MessageBox.Show( "Board is not initialized" );
                return;
            }

            Cursor = Cursors.WaitCursor;

            m_board.reset();

            if ( null == m_rndm )
                m_rndm = new Random();

            int n_white_black_ratio = (int)(NudWhiteBlackRatio.Value);

            int n_white = Color.White.ToArgb();
            int n_black = Color.Black.ToArgb();

//            int n_seed = (int)((DateTime.Now - DateTime.Today).TotalMilliseconds);
//            Parallel.For(0, m_board.height, 
//                (j) =>
//                {
//                    Random _rndm = new Random(n_seed + j);
//                    for ( int i = 0; i < m_board.width; i++ )
//                    {
//                        if ( 0 == _rndm.Next(n_white_black_ratio+1) )
//                            m_board.set_pixel_color(i, j, n_black);
//                        else
//                            m_board.set_pixel_color(i, j, n_white);
//                    }
//                } );

            for ( int i = 0; i < m_board.width*m_board.height; i++ )
            {
                if ( 0 == m_rndm.Next(n_white_black_ratio+1) )
                    m_board.set_pixel_color(i, n_black);
                else
                    m_board.set_pixel_color(i, n_white);
            }

            draw_board();

            Cursor = Cursors.Default;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            m_board = new CBoard(NudWidth.Value, NudHeight.Value);
            m_color_gnrtr = new CColorGenerator();

            PnlInit.Enabled = false;

            draw_board();

            Cursor = Cursors.Default;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int n_isle_count = CIslandPainter.paint(m_board, m_color_gnrtr);
            draw_board();

            LblRes.Text = $"Found {n_isle_count} islands";

            Cursor = Cursors.Default;
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
        \* --------------------------------------------------------------------------------- */
        private void draw_board()
        {
            m_bmp = new Bitmap(m_board.width, m_board.height);

            Rectangle _rect = new Rectangle(0, 0, m_bmp.Width, m_bmp.Height);
            System.Drawing.Imaging.BitmapData _bmp_data = m_bmp.LockBits
            (
                _rect,
                System.Drawing.Imaging.ImageLockMode.ReadWrite,
                m_bmp.PixelFormat
            );

            m_board.get_all_pixels(_bmp_data.Scan0);

            m_bmp.UnlockBits(_bmp_data);

            PbImage.Image = m_bmp;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblRes.Text = "";

            m_board.reset();
            draw_board();
        }

        private void PbImage_MouseClick(object sender, MouseEventArgs e)
        {
            draw_pixel(e.X, e.Y);
        }

        private void PbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if ( MouseButtons != MouseButtons.Left )
                return;

            draw_pixel(e.X, e.Y);
        }


        /* --------------------------------------------------------------------------------- *\
          Description: 
            
          Parameters:
            int x: 
            int y: 
        \* --------------------------------------------------------------------------------- */
        private void draw_pixel(int x, int y)
        {
            if ( null == m_bmp )
                return;

            if ( m_board.width <= x || m_board.height <= y || 0 > x || 0 > y )
                return;

            m_board.set_pixel_color( x, y, Color.Black.ToArgb() );

            m_bmp.SetPixel(x, y, Color.Black);

            PbImage.Image = m_bmp;
        }

    } // class FrmMain

} // namespace att_hw
