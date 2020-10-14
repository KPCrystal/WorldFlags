using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorldFlag
{
    public partial class JapanFlag : Form
    {
        /// <summary>
        /// 初期表示
        /// </summary>
        public JapanFlag()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.Width = 510;
            this.Height = 320;
            this.BackColor = Color.LightBlue;
        }

        /// <summary>
        /// OnPaintイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // フラグを作成
            DrawFlag(g, 20, 20, this.Width - 60);
            g.Dispose();
        }

        /// <summary>
        /// フラグを作成する
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="width"></param>
        private void DrawFlag(Graphics g, float x0, float y0, float width)
        {
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            float height = 10 * width / 19;
            // 白色の四角を作成
            g.FillRectangle(whiteBrush, x0, y0, width, height);

            // 楕円形を作成
            DrawEllipse(g);

            whiteBrush.Dispose();
        }

        /// <summary>
        /// 楕円形を作成する
        /// </summary>
        /// <param name="g"></param>
        private void DrawEllipse(Graphics g)
        {
            // 楕円形を作成。X Position, Y Position, 幅、縦を設定
            Rectangle rect = new Rectangle(this.Width/4, this.Height/10, 250, 215);

            g.FillEllipse(Brushes.Red, rect);
        }
    }
}
