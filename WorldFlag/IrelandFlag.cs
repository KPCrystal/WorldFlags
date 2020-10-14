using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorldFlag
{
    public partial class IrelandFlag : Form
    {
        /// <summary>
        /// 初期表示
        /// </summary>
        public IrelandFlag()
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
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            float height = 10 * width / 19;
            // 緑色の四角を作成
            g.FillRectangle(greenBrush, x0, y0, width / 3, height);
            // 白色の四角を作成
            g.FillRectangle(whiteBrush, x0 + 2 * 1 * width / 6,
                y0, width / 3, height);
            // オレンジ色の四角を作成
            g.FillRectangle(orangeBrush, x0 + 2 * 1 * width / 3,
                y0, width / 3, height);
            
            greenBrush.Dispose();
            whiteBrush.Dispose();
            orangeBrush.Dispose();
        }
    }
}
