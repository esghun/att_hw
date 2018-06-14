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

            for ( int i = 0; i < m_board.width; i++ )
                for ( int j = 0; j < m_board.height; j++ )
                {
                    CPixel _pixel = m_board.pixel(i, j);

                    if ( 0 == m_rndm.Next(n_white_black_ratio+1) )
                        _pixel.color = Color.Black;
                    else
                        _pixel.color = Color.White;
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
            
            for ( int i = 0; i < m_board.width; i++ )
                for ( int j = 0; j < m_board.height; j++ )
                {
                    CPixel _pixel = m_board.pixel(i, j);
                    _bmp.SetPixel(i, j, _pixel.color);
                }

            PbImage.Image = _bmp;
        }

    }
}
