using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionUI.View.Component.Track
{
    public enum HorizontalAlignment
    {
        Left,
        Center,
        Right
    }

    public enum VerticalAlignment
    {
        Top,
        Center,
        Bottom
    }

    public enum FillType
    {
        Solid, Gradient, RadialGradient
    }


    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Fonts
    {
        private Font font = new Font("Arial", 12f);
        public Font Font
        {
            get => font; set
            {
                font = value;
                PropertyChanged?.Invoke();
            }
        }

        private HorizontalAlignment fontHorizontalAlign = HorizontalAlignment.Center;
        public HorizontalAlignment FontHorizontalAlign
        {
            get => fontHorizontalAlign; set
            {
                fontHorizontalAlign = value;
                PropertyChanged?.Invoke();
            }
        }
        private VerticalAlignment fontVerticalAlign = VerticalAlignment.Center;
        public VerticalAlignment FontVerticalAlign
        {
            get => fontVerticalAlign; set
            {
                fontVerticalAlign = value;
                PropertyChanged?.Invoke();
            }
        }
        private Padding _textPadding = new Padding(5);
        public Padding TextPadding
        {
            get => _textPadding;
            set
            {
                if (_textPadding != value)
                {
                    _textPadding = value;
                    PropertyChanged?.Invoke();
                }
            }
        }


        public event Action PropertyChanged;

    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Colors
    {
        private FillType _fillStyle = FillType.Solid;
        public FillType FillStyle
        {
            get => _fillStyle;
            set
            {
                if (_fillStyle != value)
                {
                    _fillStyle = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _colorTop = Color.Gray;
        public Color ColorTop
        {
            get => _colorTop;
            set
            {
                if (_colorTop != value)
                {
                    _colorTop = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _colorBottom = Color.DarkBlue;
        public Color ColorBottom
        {
            get => _colorBottom;
            set
            {
                if (_colorBottom != value)
                {
                    _colorBottom = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private float _gradientAngle = 90F;
        public float GradientAngle
        {
            get => _gradientAngle;
            set
            {
                if (_gradientAngle != value)
                {
                    _gradientAngle = value;
                    PropertyChanged?.Invoke();
                }
            }
        }


        private Color _leftAreaColor = Color.LightBlue;
        public Color LeftAreaColor
        {
            get => _leftAreaColor;
            set
            {
                if (_leftAreaColor != value)
                {
                    _leftAreaColor = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _rightAreaColor = Color.LightCoral;
        public Color RightAreaColor
        {
            get => _rightAreaColor;
            set
            {
                if (_rightAreaColor != value)
                {
                    _rightAreaColor = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _sliderColor = Color.Gray;
        public Color SliderColor
        {
            get => _sliderColor;
            set
            {
                if (_sliderColor != value)
                {
                    _sliderColor = value;
                    PropertyChanged?.Invoke();
                }
            }
        }


        public event Action PropertyChanged;

    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Border
    {
        private int _borderThickness = 0;
        public int BorderThickness
        {
            get => _borderThickness;
            set
            {
                if (_borderThickness != value)
                {
                    _borderThickness = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private int _coloredAreaBorder = 1;
        public int ColoredAreaBorder
        {
            get => _coloredAreaBorder;
            set
            {
                if (_coloredAreaBorder != value)
                {
                    _coloredAreaBorder = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private int _sliderBorder = 1;
        public int SliderBorder
        {
            get => _sliderBorder;
            set
            {
                if (_sliderBorder != value)
                {
                    _sliderBorder = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _borderColor = Color.Black;
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (_borderColor != value)
                {
                    _borderColor = value;
                    PropertyChanged?.Invoke();
                }
            }
        }


        public event Action PropertyChanged;

    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Style
    {
        [Category("Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        private Border _border = new Border();

        public Border Border
        {
            get { return _border; }
            set
            {
                _border = value;
            }
        }

        [Category("Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        private Colors _colors = new Colors();

        public Colors Colors
        {
            get { return _colors; }
            set { _colors = value; }
        }

        [Category("Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        private Fonts _fonts = new Fonts();

        public Fonts Fonts
        {
            get { return _fonts; }
            set { _fonts = value; }
        }


        private int _cornerRadius = 0;

        public int CornerRadius
        {
            get => _cornerRadius;
            set
            {
                if (_cornerRadius != value)
                {
                    _cornerRadius = value;
                    PropertyChanged?.Invoke();
                }
            }
        }


        private int leftRightPadding = 10;
        private int topBottomPadding = 10;

        public int LeftRightPadding
        {
            get => leftRightPadding;
            set
            {
                leftRightPadding = value;
                PropertyChanged?.Invoke();
            }
        }
        public int TopBottomPadding
        {
            get => topBottomPadding; set
            {
                topBottomPadding = value;
                PropertyChanged?.Invoke();
            }
        }
        public event Action PropertyChanged;

    }

    public class CTrackBar : TrackBar
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINTER_INFO
        {
            public int pointerType;
            public uint pointerId;
            public uint frameId;
            public int pointerFlags;
            public IntPtr sourceDevice;
            public IntPtr hwndTarget;
            public POINT ptPixelLocation;
            public POINT ptHimetricLocation;
            public POINT ptPixelLocationRaw;
            public POINT ptHimetricLocationRaw;
            public uint dwTime;
            public uint historyCount;
            public int inputData;
            public uint dwKeyStates;
            public ulong PerformanceCount;
            public int ButtonChangeType;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPointerInfo(uint pointerId, out POINTER_INFO pointerInfo);


        public Style _style = new Style();

        [Category("Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Style Style { get { return _style; } set { _style = value; } }



        private bool _isHovering = false;
        private bool _isDragging = false;


        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }

        public CTrackBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.AutoSize = false;
            this.Minimum = 0;
            this.Maximum = 100;
            this.Value = 0;

            this.Style.PropertyChanged += PaintInvalidate;
            this.Style.Border.PropertyChanged += PaintInvalidate;
            this.Style.Colors.PropertyChanged += PaintInvalidate;
            this.Style.Fonts.PropertyChanged += PaintInvalidate;
        }

        private void PaintInvalidate()
        {
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovering = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isHovering = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isDragging = true;
            SetValueFromMousePosition(e.X);
            Invalidate();

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isDragging)
            {
                SetValueFromMousePosition(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isDragging = false;
            Invalidate();

        }

        private void SetValueFromMousePosition(int x)
        {
            int limitedX = Math.Max(Style.LeftRightPadding, Math.Min(this.Width - Style.LeftRightPadding, x));

            float effectiveWidth = this.Width - (Style.LeftRightPadding * 2);
            float percent = Math.Max(0, Math.Min(1, (float)(limitedX - Style.LeftRightPadding) / effectiveWidth));
            int newValue = (int)((percent * (this.Maximum - this.Minimum)) + this.Minimum);

            this.Value = Math.Max(this.Minimum, Math.Min(this.Maximum, newValue));
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            GraphicsPath path = CreateRoundedRectanglePath(this.ClientRectangle, Style.CornerRadius);

            Color topColor, bottomColor;

            topColor = Style.Colors.ColorTop;
            bottomColor = Style.Colors.ColorBottom;

            if (Style.Colors.FillStyle == FillType.Solid)
            {
                using (SolidBrush brush = new SolidBrush(topColor))
                {
                    g.FillPath(brush, path);
                }
            }
            else if (Style.Colors.FillStyle == FillType.Gradient)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    this.ClientRectangle, topColor, bottomColor, Style.Colors.GradientAngle))
                {
                    g.FillPath(brush, path);
                }
            }
            else if (Style.Colors.FillStyle == FillType.RadialGradient)
            {
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    RectangleF bounds = path.GetBounds();
                    bounds.Inflate(-1, -1);

                    PointF centerPoint = new PointF((bounds.Left + bounds.Right) / 2, (bounds.Top + bounds.Bottom) / 2);
                    brush.CenterPoint = centerPoint;
                    brush.CenterColor = topColor;
                    brush.SurroundColors = new Color[] { bottomColor };

                    g.FillPath(brush, path);
                }
            }



            if (Style.Border.BorderThickness > 0)
            {
                using (Pen pen = new Pen(Style.Border.BorderColor, Style.Border.BorderThickness))
                {
                    g.DrawPath(pen, path);
                }

            }




            float effectiveWidth = this.Width - (Style.LeftRightPadding * 2);
            float percent = (float)(this.Value - this.Minimum) / (this.Maximum - this.Minimum);
            float sliderPosition = (percent * effectiveWidth) + Style.LeftRightPadding;



            float sliderHeight = this.Height - (Style.TopBottomPadding * 2);

            float sliderY = Style.TopBottomPadding;

            float sliderWidth = 20;

            float sliderX = sliderPosition;

            sliderX = Math.Min(sliderX, this.Width - Style.TopBottomPadding - sliderWidth);

            float coloredAreasHeight = sliderHeight - 4;
            float coloredAreasY = sliderY + 2;

            RectangleF leftArea = new RectangleF(Style.LeftRightPadding, coloredAreasY, sliderX - Style.LeftRightPadding, coloredAreasHeight);

            using (Brush leftBrush = new SolidBrush(Style.Colors.LeftAreaColor))
            {
                g.FillRectangle(leftBrush, leftArea);
            }

            RectangleF rightArea = new RectangleF(sliderX + sliderWidth, coloredAreasY, this.Width - Style.LeftRightPadding - (sliderX + sliderWidth), coloredAreasHeight);
            using (Brush rightBrush = new SolidBrush(Style.Colors.RightAreaColor))
            {
                g.FillRectangle(rightBrush, rightArea);
            }
            using (Pen borderPen = new Pen(Style.Border.BorderColor, Style.Border.ColoredAreaBorder))
            {
                g.DrawRectangle(borderPen, sliderX, sliderY, sliderWidth, sliderHeight); // Slider çerçevesi
                g.DrawRectangle(borderPen, Style.LeftRightPadding, coloredAreasY, effectiveWidth, coloredAreasHeight); // Renkli alanlar çerçevesi
            }

            double percentValue = (double)(this.Value - this.Minimum) / (this.Maximum - this.Minimum) * 100;
            string percentText = $"{percentValue:F0}%";

            SizeF textSizeP = g.MeasureString(percentText, Style.Fonts.Font);

            float textXP, textYP;

            if (percentValue <= 50)
            {
                float rightAreaCenterX = (sliderX + sliderWidth) + ((this.Width - Style.LeftRightPadding - (sliderX + sliderWidth)) / 2);
                textXP = rightAreaCenterX - (textSizeP.Width / 2);
            }
            else
            {
                float leftAreaCenterX = Style.LeftRightPadding + ((sliderX - Style.LeftRightPadding) / 2);
                textXP = leftAreaCenterX - (textSizeP.Width / 2);
            }

            textYP = (this.Height - textSizeP.Height) / 2;

            using (Brush textBrush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(percentText, Style.Fonts.Font, textBrush, textXP, textYP);
            }
            using (Brush textBrush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(percentText, Style.Fonts.Font, textBrush, textXP, textYP);
            }


            RectangleF sliderRect = new RectangleF(sliderX, sliderY, sliderWidth, sliderHeight);
            using (Brush sliderBrush = new SolidBrush(Style.Colors.SliderColor))
            {
                g.FillRectangle(sliderBrush, sliderRect);
            }

            using (Pen borderPen = new Pen(Style.Border.BorderColor, Style.Border.SliderBorder))
            {
                g.DrawRectangle(borderPen, sliderX, sliderY, sliderWidth, sliderHeight);
            }


        }
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();

            if (cornerRadius <= 0)
            {
                roundedRect.AddRectangle(rect);
                return roundedRect;
            }

            rect = new Rectangle(rect.X + Style.Border.BorderThickness,
                                 rect.Y + Style.Border.BorderThickness,
                                 rect.Width - Style.Border.BorderThickness * 2,
                                 rect.Height - Style.Border.BorderThickness * 2);

            int adjustedCornerRadius = cornerRadius + Style.Border.BorderThickness;
            int arcSize = adjustedCornerRadius * 2;

            if (adjustedCornerRadius >= (Math.Min(rect.Width, rect.Height) / 2.0))
                return GetCapsule(rect);

            roundedRect.AddArc(rect.X, rect.Y, arcSize, arcSize, 180, 90);
            roundedRect.AddLine(rect.X + adjustedCornerRadius, rect.Y, rect.Right - adjustedCornerRadius, rect.Y);
            roundedRect.AddArc(rect.Right - arcSize, rect.Y, arcSize, arcSize, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + adjustedCornerRadius, rect.Right, rect.Bottom - adjustedCornerRadius);
            roundedRect.AddArc(rect.Right - arcSize, rect.Bottom - arcSize, arcSize, arcSize, 0, 90);
            roundedRect.AddLine(rect.Right - adjustedCornerRadius, rect.Bottom, rect.X + adjustedCornerRadius, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - arcSize, arcSize, arcSize, 90, 90);
            roundedRect.CloseFigure();

            return roundedRect;
        }
        private GraphicsPath GetCapsule(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();
            try
            {
                if (rect.Width > rect.Height)
                {
                    int diameter = rect.Height;
                    Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));
                    path.AddArc(arc, 90, 180);
                    arc.X = rect.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if (rect.Width < rect.Height)
                {
                    int diameter = rect.Width;
                    Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));
                    path.AddArc(arc, 180, 180);
                    arc.Y = rect.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else path.AddEllipse(rect);
            }
            catch { path.AddEllipse(rect); }
            finally { path.CloseFigure(); }
            return path;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_POINTERDOWN = 0x0246;
            const int WM_POINTERMOVE = 0x0245;

            switch (m.Msg)
            {
                case WM_POINTERDOWN:
                    HandlePointerDown(m.WParam);
                    break;
                case WM_POINTERMOVE:
                    HandlePointerMove(m.WParam);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void HandlePointerDown(IntPtr wParam)
        {
            int pointerId = LOWORD(wParam.ToInt32());
            ProcessPointer(pointerId);
        }

        private void HandlePointerMove(IntPtr wParam)
        {
            int pointerId = LOWORD(wParam.ToInt32());
            ProcessPointer(pointerId);
        }

        private void ProcessPointer(int pointerId)
        {
            POINTER_INFO pointerInfo;
            if (GetPointerInfo((uint)pointerId, out pointerInfo))
            {
                Point screenPos = new Point(pointerInfo.ptPixelLocation.X, pointerInfo.ptPixelLocation.Y);
                Point clientPos = this.PointToClient(screenPos);

                int value = CalculateValueFromPosition(clientPos);
                this.Value = Math.Min(Math.Max(value, this.Minimum), this.Maximum);
            }
        }

        private int LOWORD(int number)
        {
            return number & 0xffff;
        }
        private int CalculateValueFromPosition(Point position)
        {
            double percent = (double)position.X / this.Width;
            return (int)(percent * (this.Maximum - this.Minimum)) + this.Minimum;
        }
    }
}
