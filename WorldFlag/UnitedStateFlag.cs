using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorldFlag
{
    public partial class UnitedStatesFlag : Form
    {
        /// <summary>
        /// 初期表示
        /// </summary>
        public UnitedStatesFlag()
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
            SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush redBrush1 = new SolidBrush(Color.Red);

            float height = 10 * width / 19;
            // 白色の四角を作成
            g.FillRectangle(whiteBrush, x0, y0, width, height);
            // 青色の四角を作成
            g.FillRectangle(blueBrush, x0, y0, width / 3, (height + 12) / 2);
            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0 + 2 * 1 * width / 6,
                y0, width - 150, height / 12);
            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0 + 2 * 1 * width / 6,
                y0 + 35, width - 150, height / 12);
            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0 + 2 * 1 * width / 6,
                y0 + 70, width - 150, height / 12);
            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0 + 2 * 1 * width / 6,
                y0 + 105, width - 150, height / 12);

            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0,
                y0 + 140, width, height / 12);
            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0,
                y0 + 175, width, height / 12);
            // 赤色の四角を作成
            g.FillRectangle(redBrush1, x0,
                y0 + 210, width, height / 12);

            //星を作成する。※複数の星を作成したい場合、ループしてください。
            x0 = x0 + 18;
            y0 = y0 + 14;
            for (int j = 0; j < 5; j++)
            {
                // Y Positionを設定
                float yc = y0 + j * 24;
                for (int i = 0; i < 6; i++)
                {
                    // X Positionを設定
                    float xc = x0 + i * 22;
                    DrawStar(g, this.Width / 65, xc, yc);
                }
            }

            //星を作成する。※複数の星を作成したい場合、ループしてください。
            x0 = x0 + 13;
            y0 = y0 + 14;
            for (int j = 0; j < 4; j++)
            {
                // Y Positionを設定
                float yc = y0 + j * 24;
                for (int i = 0; i < 5; i++)
                {
                    // X Positionを設定
                    float xc = x0 + i * 22;
                    DrawStar(g, this.Width / 65, xc, yc);
                }
            }

            blueBrush.Dispose();
            whiteBrush.Dispose();
            redBrush1.Dispose();
        }

        /// <summary>
        /// 星を作成する
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        private void DrawStar(Graphics g, float r, float xc, float yc)
        {
            // r: 星のサイズを調整
            // xc, yc: 星のポジションを調整
            float sin36 = (float)Math.Sin(36.0 * Math.PI / 180.0);
            float sin72 = (float)Math.Sin(72.0 * Math.PI / 180.0);
            float cos36 = (float)Math.Cos(36.0 * Math.PI / 180.0);
            float cos72 = (float)Math.Cos(72.0 * Math.PI / 180.0);
            float r1 = r * cos72 / cos36;
            // ポイントを使って星を書く
            PointF[] pts = new PointF[10];
            pts[0] = new PointF(xc, yc - r);
            pts[1] = new PointF(xc + r1 * sin36, yc - r1 * cos36);
            pts[2] = new PointF(xc + r * sin72, yc - r * cos72);
            pts[3] = new PointF(xc + r1 * sin72, yc + r1 * cos72);
            pts[4] = new PointF(xc + r * sin36, yc + r * cos36);
            pts[5] = new PointF(xc, yc + r1);
            pts[6] = new PointF(xc - r * sin36, yc + r * cos36);
            pts[7] = new PointF(xc - r1 * sin72, yc + r1 * cos72);
            pts[8] = new PointF(xc - r * sin72, yc - r * cos72);
            pts[9] = new PointF(xc - r1 * sin36, yc - r1 * cos36);
            // 星の色とポジションを設定
            g.FillPolygon(Brushes.White, pts);
        }
    }
}
