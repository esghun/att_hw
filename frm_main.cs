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

BtnRandomize.Enabled = false;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            m_board = new CBoard(NudWidth.Value, NudHeight.Value);
            m_color_gnrtr = new CColorGenerator();
BtnCreate.Enabled = false;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            int n_isle_count = CIslandPainter.paint(m_board, m_color_gnrtr);
            draw_board();

            LblRes.Text = $"Found {n_isle_count} islands";
BtnSolve.Enabled = false;
        }

        private void draw_board()
        {
            Bitmap _bmp = new Bitmap(m_board.width, m_board.height);

            Rectangle _rect = new Rectangle(0, 0, _bmp.Width, _bmp.Height);
            System.Drawing.Imaging.BitmapData _bmp_data = _bmp.LockBits
            (
                _rect,
                System.Drawing.Imaging.ImageLockMode.ReadWrite,
                _bmp.PixelFormat
            );

            m_board.get_all_pixels(_bmp_data.Scan0);

            _bmp.UnlockBits(_bmp_data);

            if ( null != PbImage.Image )
                PbImage.Image.Dispose();

            PbImage.Image = _bmp;
        }

    }
}
