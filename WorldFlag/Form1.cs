using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorldFlag
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初期表示
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Button[] btns = { btnAustria, btnBelgium, btnCameroon, btnChile, btnChina,
                                btnColombia, btnFrance, btnGermany, btnIndonesia,
                                btnIreland, btnIsrael, btnItaly, btnJapan, btnMyanmar,
                                btnNetherland, btnNigeria, btnPoland, btnRomania,
                                btnRussia, btnSenegal, btnSweden, btnUae, btnUkraine,
                                btnUnitedState, btnVietnam};
            //マウスイベント設定
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].MouseEnter += OnMouseEnter;
                btns[i].MouseLeave += OnMouseLeave;
            }
        }

        /// <summary>
        /// マウスイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Gold;
        }

        /// <summary>
        /// マウスイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ButtonFace;
        }

        /// <summary>
        /// Myanmarボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyanmar_Click(object sender, System.EventArgs e)
        {
            Form form = new MyanmarFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Japanボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJapan_Click(object sender, System.EventArgs e)
        {
            Form form = new JapanFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Chinaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChina_Click(object sender, System.EventArgs e)
        {
            Form form = new ChinaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Austriaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAustria_Click(object sender, System.EventArgs e)
        {
            Form form = new AustriaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Belgiumボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBelgium_Click(object sender, System.EventArgs e)
        {
            Form form = new BelgiumFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Cameroonボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCameroon_Click(object sender, System.EventArgs e)
        {
            Form form = new CameroonFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Chilleボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChile_Click(object sender, System.EventArgs e)
        {
            Form form = new ChileFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Colombiaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColombia_Click(object sender, System.EventArgs e)
        {
            Form form = new ColombiaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Franceボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrance_Click(object sender, System.EventArgs e)
        {
            Form form = new FranceFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Germanyボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGermany_Click(object sender, System.EventArgs e)
        {
            Form form = new GermanyFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Indonesiaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndonesia_Click(object sender, System.EventArgs e)
        {
            Form form = new IndonesiaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Irelandボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIreland_Click(object sender, System.EventArgs e)
        {
            Form form = new IrelandFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Italyボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItaly_Click(object sender, System.EventArgs e)
        {
            Form form = new ItalyFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Israelボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIsrael_Click(object sender, System.EventArgs e)
        {
            Form form = new IsraelFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Netherlandボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNetherland_Click(object sender, System.EventArgs e)
        {
            Form form = new NetherlandFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Nigeriaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNigeria_Click(object sender, System.EventArgs e)
        {
            Form form = new NigeriaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Polandボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoland_Click(object sender, System.EventArgs e)
        {
            Form form = new PolandFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Romaniaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRomania_Click(object sender, System.EventArgs e)
        {
            Form form = new RomaniaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Russiaボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRussia_Click(object sender, System.EventArgs e)
        {
            Form form = new RussiaFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Senegalボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSenegal_Click(object sender, System.EventArgs e)
        {
            Form form = new SenegalFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Swedenボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSweden_Click(object sender, System.EventArgs e)
        {
            Form form = new SwedenFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// United States ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnitedStates_Click(object sender, System.EventArgs e)
        {
            Form form = new UnitedStatesFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Vietnamボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVietnam_Click(object sender, System.EventArgs e)
        {
            Form form = new VietnamFlag();
            form.ShowDialog();
        }

        /// <summary>
        /// Ukraineボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUkraine_Click(object sender, System.EventArgs e)
        {
            Form form = new UkraineFlag();
            form.ShowDialog();
        }
        
        /// <summary>
        /// UAEボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUae_Click(object sender, System.EventArgs e)
        {
            Form form = new UAEFlag();
            form.ShowDialog();
        }
    }
}
