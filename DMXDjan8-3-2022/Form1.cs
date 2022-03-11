using TheDLL;

namespace DMXDjan8_3_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Helpers Helpers = new Helpers();
        private void Form1_Load(object sender, EventArgs e)
        {
            int r = Helpers.RandomNumber(1, 12);
        }

        private void tcbRed_Scroll(object sender, EventArgs e)
        {
            if (tcbRed.Value != 0 && tcbGreen.Value !=0 )
            {
                pnlColor.BackColor = Helpers.GetRgb(tcbRed.Value, tcbGreen.Value, tcbBlue.Value);
            }

            if (tcbRed.Value !=0 && tcbBlue.Value !=0)
            {
                pnlColor.BackColor = Helpers.GetRgb(tcbRed.Value, tcbGreen.Value, tcbBlue.Value);
            }

        }

        private void tcbGreen_Scroll(object sender, EventArgs e)
        {
            if (tcbGreen.Value != 0 && tcbBlue.Value != 0)
            {
                pnlColor.BackColor = Helpers.GetRgb(tcbRed.Value, tcbGreen.Value, tcbBlue.Value);
            }

            if (tcbGreen.Value != 0 && tcbRed.Value != 0)
            {
                pnlColor.BackColor = Helpers.GetRgb(tcbRed.Value, tcbGreen.Value, tcbBlue.Value);
            }


        }

        private void tcbBlue_Scroll(object sender, EventArgs e)
        {
            if (tcbBlue.Value != 0 && tcbGreen.Value != 0)
            {
                pnlColor.BackColor = Helpers.GetRgb(tcbRed.Value, tcbGreen.Value, tcbBlue.Value);
            }

            if (tcbBlue.Value != 0 && tcbRed.Value != 0)
            {
                pnlColor.BackColor = Helpers.GetRgb(tcbRed.Value, tcbGreen.Value, tcbBlue.Value);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tcbBlue.Value = 0;
            tcbRed.Value = 0;
            tcbGreen.Value = 0;

            pnlColor.BackColor = Color.Transparent;
        }
    }
}