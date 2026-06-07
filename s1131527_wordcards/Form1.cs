using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace s1131527_wordcards
{
    public partial class frmWordCards : Form
    {
        
        WordCollection _WordList = new WordCollection();
        
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        string strWordFile = "WordCards.txt"; // 單字檔名
        
        bool isPlay = false;
        public frmWordCards()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {

        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
