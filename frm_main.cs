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

        private const int mn_WHITE_BLACK_RATIO = 4;

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
            
            for ( int i = 0; i < m_board.width; i++ )
                for ( int j = 0; j < m_board.height; j++ )
                {
                    if ( 0 == m_rndm.Next(mn_WHITE_BLACK_RATIO+1) )
                        m_board.pixel(i, j).color = Color.Black;
                    else
                        m_board.pixel(i, j).color = Color.White;
                }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            m_board = new CBoard(NudWidth.Value, NudHeight.Value);
        }
    }
}
