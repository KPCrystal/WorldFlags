using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorldFlag
{
    public partial class IsraelFlag : Form
    {
        /// <summary>
        /// 初期表示
        /// </summary>
        public IsraelFlag()
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
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            float height = 10 * width / 19;
            // 青色の四角を作成
            g.FillRectangle(blueBrush, x0, y0, width, height / 5);
            // 白色の四角を作成
            g.FillRectangle(whiteBrush, x0,
                y0 + 2 * 1 * height / 10, width, (height + 50) / 2);
            // 青色の四角を作成
            g.FillRectangle(blueBrush, x0,
                y0 + 2 * 1 * (height + 50) / 3, width, height / 5);
            
            //三角を作成する
            DrawTriangle(g);

            blueBrush.Dispose();
            whiteBrush.Dispose();
        }

        /// <summary>
        /// 三角を作成する
        /// </summary>
        /// <param name="g"></param>
        private void DrawTriangle(Graphics g)
        {
            // ぺんを作成する。色と大きさを設定
            Pen blackPen = new Pen(Color.Blue, 8);
            
            // 四角のポイントを作成する。X PositionとY Position
            Point point1 = new Point(250, 80);
            Point point2 = new Point(200, 170);
            Point point3 = new Point(300, 170);

            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3
             };

            // 画面に三角を書く
            g.DrawPolygon(blackPen, curvePoints);

            // 三角２を作成のため、ポイントを設定
            point1 = new Point(200, 100);
            point2 = new Point(300, 100);
            point3 = new Point(250, 190);

            Point[] curvePoints1 =
                     {
                 point1,
                 point2,
                 point3
             };

            // 画面に四角２を書く
            g.DrawPolygon(blackPen, curvePoints1);
        }
    }
}
