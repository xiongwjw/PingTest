using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

 namespace PingTest
{
    public class ListviewEx : System.Windows.Forms.ListView
    {

        #region 新增属性
        private Color _headColor;
        private Color _selectedColor;
        private Color _rowBackColor1;
        private Color _rowBackColor2;
        public Color RowBackColor1
        {
            get
            {
                return _rowBackColor1;
            }
            set
            {
                _rowBackColor1 = value;
            }
        }
        public Color RowBackColor2
        {
            get
            {
                return _rowBackColor2;
            }
            set
            {
                _rowBackColor2 = value;
            }
        }
        public Color SelectedColor
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor = value;
            }
        }
        public Color HeadColor
        {
            get
            {
                return _headColor;
            }
            set
            {
                _headColor = value;
            }
        }

        #endregion

        public ListviewEx()
            : base()
        {
            base.OwnerDraw = true;
        }

        public void RenderBackgroundInternal(Graphics g, Rectangle rect,
                    Color baseColor, Color borderColor, Color innerBorderColor,
                    float basePosition, bool drawBorder, LinearGradientMode mode)
        {
            if (drawBorder)
            {
                rect.Width--;
                rect.Height--;
            }
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.Transparent, Color.Transparent, mode))
            {
                Color[] colors = new Color[4];
                colors[0] = GetColor(baseColor, 0, 35, 24, 9);
                colors[1] = GetColor(baseColor, 0, 13, 8, 3);
                colors[2] = baseColor;
                colors[3] = GetColor(baseColor, 0, 68, 69, 54);


                ColorBlend blend = new ColorBlend();
                blend.Positions = new float[] { 0.0f, basePosition, basePosition + 0.05f, 1.0f };
                blend.Colors = colors;
                brush.InterpolationColors = blend;
                g.FillRectangle(brush, rect);
            }
            if (baseColor.A > 80)
            {
                Rectangle rectTop = rect;
                if (mode == LinearGradientMode.Vertical)
                {
                    rectTop.Height = (int)(rectTop.Height * basePosition);
                }
                else
                {
                    rectTop.Width = (int)(rect.Width * basePosition);
                }
                using (SolidBrush brushAlpha =
                    new SolidBrush(Color.FromArgb(80, 255, 255, 255)))
                {
                    g.FillRectangle(brushAlpha, rectTop);
                }
            }
            if (drawBorder)
            {
                using (Pen pen = new Pen(borderColor))
                {
                    g.DrawRectangle(pen, rect);
                }


                rect.Inflate(-1, -1);
                using (Pen pen = new Pen(innerBorderColor))
                {
                    g.DrawRectangle(pen, rect);
                }
            }
        }
        private static Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int a0 = colorBase.A;
            int r0 = colorBase.R;
            int g0 = colorBase.G;
            int b0 = colorBase.B;


            if (a + a0 > 255) { a = 255; } else { a = Math.Max(a + a0, 0); }
            if (r + r0 > 255) { r = 255; } else { r = Math.Max(r + r0, 0); }
            if (g + g0 > 255) { g = 255; } else { g = Math.Max(g + g0, 0); }
            if (b + b0 > 255) { b = 255; } else { b = Math.Max(b + b0, 0); }


            return Color.FromArgb(a, r, g, b);
        }


        protected override void OnDrawColumnHeader(
            DrawListViewColumnHeaderEventArgs e)
        {
            base.OnDrawColumnHeader(e);

            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;

            Color baseColor = _headColor;
            Color borderColor = _headColor;
            Color innerBorderColor = Color.FromArgb(200, 255, 255);

            RenderBackgroundInternal(
                g,
                bounds,
                baseColor,
                borderColor,
                innerBorderColor,
                0.35f,
                true,
                LinearGradientMode.Vertical);

           // TextFormatFlags flags = TextFormatFlags.HorizontalCenter;
            TextFormatFlags flags = TextFormatFlags.Left;
            Rectangle textRect = new Rectangle(
                       bounds.X + 3,
                       bounds.Y,
                       bounds.Width - 6,
                       bounds.Height); ;

            if (e.Header.ImageList != null)
            {
                Image image = e.Header.ImageIndex == -1 ?
                    null : e.Header.ImageList.Images[e.Header.ImageIndex];
                if (image != null)
                {
                    Rectangle imageRect = new Rectangle(
                        bounds.X + 3,
                        bounds.Y + 2,
                        bounds.Height - 4,
                        bounds.Height - 4);
                    g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                    g.DrawImage(image, imageRect);

                    textRect.X = imageRect.Right + 3;
                    textRect.Width -= imageRect.Width;
                }
            }
          //  Font font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextRenderer.DrawText(
                   g,
                   e.Header.Text,
                   e.Font,
                   textRect,
                   e.ForeColor,
                   flags);
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (View != View.Details)
            {
                e.DrawDefault = true;
            }
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            base.OnDrawSubItem(e);
            if (View != View.Details)
            {
                return;
            }
            if (e.ItemIndex == -1)
            {
                return;
            }
            Rectangle bounds = e.Bounds;
            ListViewItemStates itemState = e.ItemState;
            Graphics g = e.Graphics;
            if ((itemState & ListViewItemStates.Selected)
                == ListViewItemStates.Selected)
            {
                bounds.Height--;
                Color baseColor = _selectedColor;
                Color borderColor = _selectedColor;
                Color innerBorderColor = Color.FromArgb(200, 255, 255);

                RenderBackgroundInternal(
                    g,
                    bounds,
                    baseColor,
                    borderColor,
                    innerBorderColor,
                    0.35f,
                    true,
                    LinearGradientMode.Vertical);
                bounds.Height++;
            }
            else
            {
                Color backColor = e.ItemIndex % 2 == 0 ?
                _rowBackColor1 : _rowBackColor2;

                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    g.FillRectangle(brush, bounds);
                }
            }

           // TextFormatFlags flags = TextFormatFlags.HorizontalCenter;
            TextFormatFlags flags = TextFormatFlags.Left;
            if (e.ColumnIndex == 0)
            {
                if (e.Item.ImageList == null)
                {
                    e.DrawText(flags);
                    return;
                }
                Image image = e.Item.ImageIndex == -1 ?
                    null : e.Item.ImageList.Images[e.Item.ImageIndex];
                if (image == null)
                {
                    e.DrawText(flags);
                    return;
                }
                Rectangle imageRect = new Rectangle(
                    bounds.X + 4,
                    bounds.Y + 2,
                    bounds.Height - 4,
                    bounds.Height - 4);
                g.DrawImage(image, imageRect);

                Rectangle textRect = new Rectangle(
                    imageRect.Right + 3,
                    bounds.Y,
                    bounds.Width - imageRect.Right - 3,
                    bounds.Height);
                TextRenderer.DrawText(
                    g,
                    e.Item.Text,
                    e.Item.Font,
                    textRect,
                    e.Item.ForeColor,
                    flags);
                return;
            }
            e.DrawText(flags);
        }


    }
}
