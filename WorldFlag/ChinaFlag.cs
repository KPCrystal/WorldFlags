using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WorldFlag
{
    public partial class ChinaFlag : Form
    {
        /// <summary>
        /// 初期表示
        /// </summary>
        public ChinaFlag()
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
            //フラグを作成する
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
            SolidBrush redBrush = new SolidBrush(Color.Red);
            float height = 10 * width / 19;
            
            // 赤色の四角を作成する
            g.FillRectangle(redBrush, x0, y0, width, height);

            // offsetを設定
            float offset = this.Width / 10;
            // x positionを設定
            float dx = this.Width - 150;
            // y positionを設定
            float dy = this.Height / 2;

            //星を作成する。※複数の星を作成したい場合、ループしてください。
            for (int j = 0; j < 1; j++)
            {
                // Y Positionを設定
                float yc = y0 + offset + j * dy + dy / 10;
                for (int i = 0; i < 1; i++)
                {
                    // X Positionを設定
                    float xc = x0 + offset + i * dx + dx / 12;
                    if ((i + j) % 2 == 0)
                    {
                        //※星のサイズやポジションが違う場合、ループで作成はできません。
                        //大きい星を作成
                        DrawParentStar(g, this.Width / 14, xc, yc);

                        //星のポジションを設定
                        yc = y0 + 25;
                        xc = x0 + offset + i * dx + dx / 4;
                        //小さい星１を作成
                        DrawChildStar1(g, this.Width / 38, xc, yc);

                        //星のポジションを設定
                        yc = y0 + 50;
                        xc = x0 + offset + i * dx + dx / 3;
                        //小さい星２を作成
                        DrawChildStar2(g, this.Width / 38, xc, yc);

                        //星のポジションを設定
                        yc = y0 + 85;
                        xc = x0 + offset + i * dx + dx / 3;
                        //小さい星３を作成
                        DrawChildStar3(g, this.Width / 38, xc, yc);

                        //星のポジションを設定
                        yc = y0 + 105;
                        xc = x0 + offset + i * dx + dx / 4;
                        //小さい星４を作成
                        DrawChildStar4(g, this.Width / 38, xc, yc);
                    }
                }
            }

            redBrush.Dispose();
        }

        /// <summary>
        /// 多きい星を作成
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        private void DrawParentStar(Graphics g, float r, float xc, float yc)
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
            g.FillPolygon(Brushes.Yellow, pts);
        }

        /// <summary>
        /// 小さい星１を作成
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        private void DrawChildStar1(Graphics g, float r, float xc, float yc)
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
            g.FillPolygon(Brushes.Yellow, pts);
        }

        /// <summary>
        /// 小さい星２を作成
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        private void DrawChildStar2(Graphics g, float r, float xc, float yc)
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
            g.FillPolygon(Brushes.Yellow, pts);
        }


        /// <summary>
        /// 小さい星３を作成
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        private void DrawChildStar3(Graphics g, float r, float xc, float yc)
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
            g.FillPolygon(Brushes.Yellow, pts);
        }

        /// <summary>
        /// 小さい星４を作成
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        private void DrawChildStar4(Graphics g, float r, float xc, float yc)
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
            g.FillPolygon(Brushes.Yellow, pts);
        }
    }
}
