using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionUI.View.Component
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
    public class Icons
    {
        private Image _icon;
        public Image Icon
        {
            get => _icon;
            set
            {
                if (_icon != value)
                {
                    _icon = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Size _iconSize = new Size(16, 16);
        public Size IconSize
        {
            get => _iconSize;
            set
            {
                if (_iconSize != value)
                {
                    _iconSize = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private HorizontalAlignment iconHorizontalAlign = HorizontalAlignment.Center;
        public HorizontalAlignment IconHorizontalAlign
        {
            get => iconHorizontalAlign; set
            {
                iconHorizontalAlign = value;
                PropertyChanged?.Invoke();
            }
        }

        private VerticalAlignment iconVerticalAlign = VerticalAlignment.Center;
        public VerticalAlignment IconVerticalAlign
        {
            get => iconVerticalAlign; set
            {
                iconVerticalAlign = value;

                PropertyChanged?.Invoke();
            }
        }
        private Padding _iconPadding = new Padding(5);
        public Padding IconPadding
        {
            get => _iconPadding;
            set
            {
                if (_iconPadding != value)
                {
                    _iconPadding = value;

                    PropertyChanged?.Invoke();
                }
            }
        }
        public event Action PropertyChanged;

    }


    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Fonts
    {
        private Font buttonFont = new Font("Arial", 12f);
        public Font ButtonFont
        {
            get => buttonFont; set
            {
                buttonFont = value;
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

        private Color _colorTop = Color.SteelBlue;
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

        private Color _hoverColorTop = Color.LightBlue;
        public Color HoverColorTop
        {
            get => _hoverColorTop;
            set
            {
                if (_hoverColorTop != value)
                {
                    _hoverColorTop = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _hoverColorBottom = Color.DeepSkyBlue;
        public Color HoverColorBottom
        {
            get => _hoverColorBottom;
            set
            {
                if (_hoverColorBottom != value)
                {
                    _hoverColorBottom = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _downColorTop = Color.LightBlue;
        public Color DownColorTop
        {
            get => _downColorTop;
            set
            {
                if (_downColorTop != value)
                {
                    _downColorTop = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private Color _downColorBottom = Color.DeepSkyBlue;
        public Color DownColorBottom
        {
            get => _downColorBottom;
            set
            {
                if (_downColorBottom != value)
                {
                    _downColorBottom = value;
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
        private bool _hoverEffectEnabled = true;
        public bool HoverEffectEnabled
        {
            get => _hoverEffectEnabled;
            set
            {
                if (_hoverEffectEnabled != value)
                {
                    _hoverEffectEnabled = value;
                    PropertyChanged?.Invoke();
                }
            }
        }

        private bool _downEffectEnabled = true;
        public bool DownEffectEnabled
        {
            get => _downEffectEnabled;
            set
            {
                if (_downEffectEnabled != value)
                {
                    _downEffectEnabled = value;
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

        [Category("Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        private Icons _icons = new Icons();

        public Icons Icons
        {
            get { return _icons; }
            set { _icons = value; }
        }

        private int _cornerRadius = 20;
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

        public event Action PropertyChanged;

    }

    public class CButton : Button
    {
        public Style _style = new Style();

        [Category("Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Style Style { get { return _style; } set { _style = value; } }

        private bool _isHovering = false;
        private bool _isPressed = false;


        public CButton()
        {
            this.BackColor = Color.Transparent;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.DoubleBuffered = true;

            this.Style.PropertyChanged += PaintInvalidate;
            this.Style.Border.PropertyChanged += PaintInvalidate;
            this.Style.Colors.PropertyChanged += PaintInvalidate;
            this.Style.Fonts.PropertyChanged += PaintInvalidate;
            this.Style.Icons.PropertyChanged += PaintInvalidate;
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
            _isPressed = true;
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isPressed = false;
            Invalidate();
            base.OnMouseUp(e);
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
            if (_isPressed && Style.Colors.DownEffectEnabled)
            {
                topColor = Style.Colors.DownColorTop;
                bottomColor = Style.Colors.DownColorBottom;
            }
            else if (_isHovering && Style.Colors.HoverEffectEnabled)
            {
                topColor = Style.Colors.HoverColorTop;
                bottomColor = Style.Colors.HoverColorBottom;
            }
            else
            {
                topColor = Style.Colors.ColorTop;
                bottomColor = Style.Colors.ColorBottom;
            }

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

            if (Style.Icons.Icon != null)
            {
                Size iconSize = Style.Icons.IconSize;
                Point iconLocation = new Point(0, 0);
                float iconX = 0;
                float iconY = 0;


                switch (Style.Icons.IconHorizontalAlign)
                {
                    case HorizontalAlignment.Left:
                        iconX = Style.Icons.IconPadding.Left;
                        break;
                    case HorizontalAlignment.Center:
                        iconX = (this.Width - iconSize.Width) / 2;
                        break;
                    case HorizontalAlignment.Right:
                        iconX = this.Width - iconSize.Width - Style.Icons.IconPadding.Right;
                        break;
                }

                switch (Style.Icons.IconVerticalAlign)
                {
                    case VerticalAlignment.Top:
                        iconY = Style.Icons.IconPadding.Top;
                        break;
                    case VerticalAlignment.Center:
                        iconY = (this.Height - iconSize.Height) / 2;
                        break;
                    case VerticalAlignment.Bottom:
                        iconY = this.Height - iconSize.Height - Style.Icons.IconPadding.Bottom;
                        break;
                }
                g.DrawImage(Style.Icons.Icon, new Rectangle((int)iconX, (int)iconY, iconSize.Width, iconSize.Height));
            }

            SizeF textSize = g.MeasureString(this.Text, Style.Fonts.ButtonFont);
            List<string> wrappedTextLines = WordWrap(this.Text, Style.Fonts.ButtonFont, g, this.Width * 0.6f);

            float totalHeight = 0;
            foreach (var line in wrappedTextLines)
            {
                totalHeight += g.MeasureString(line, Style.Fonts.ButtonFont).Height;
            }

            float currentY;
            switch (Style.Fonts.FontVerticalAlign)
            {
                case VerticalAlignment.Top:
                    currentY = Style.Fonts.TextPadding.Top;
                    break;
                case VerticalAlignment.Center:
                    currentY = (this.Height - totalHeight) / 2;
                    break;
                case VerticalAlignment.Bottom:
                    currentY = this.Height - totalHeight - Style.Fonts.TextPadding.Bottom;
                    break;
                default:
                    currentY = 0;
                    break;
            }

            foreach (var line in wrappedTextLines)
            {
                float lineWidth = g.MeasureString(line, Style.Fonts.ButtonFont).Width;
                float textX;

                switch (Style.Fonts.FontHorizontalAlign)
                {
                    case HorizontalAlignment.Left:
                        textX = Style.Fonts.TextPadding.Left;
                        break;
                    case HorizontalAlignment.Center:
                        textX = (this.Width - lineWidth) / 2;
                        break;
                    case HorizontalAlignment.Right:
                        textX = this.Width - lineWidth - Style.Fonts.TextPadding.Right;
                        break;
                    default:
                        textX = 0;
                        break;
                }

                g.DrawString(line, Style.Fonts.ButtonFont, new SolidBrush(this.ForeColor), textX, currentY);
                currentY += g.MeasureString(line, Style.Fonts.ButtonFont).Height;
            }



            if (Style.Border.BorderThickness > 0)
            {
                using (Pen pen = new Pen(Style.Border.BorderColor, Style.Border.BorderThickness))
                {
                    g.DrawPath(pen, path);
                }

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
        private List<string> WordWrap(string text, Font font, Graphics graphics, float width)
        {
            List<string> lines = new List<string>();
            string[] originalLines = text.Split(new string[] { " " }, StringSplitOptions.None);
            StringBuilder currentLine = new StringBuilder();

            foreach (var word in originalLines)
            {
                if (graphics.MeasureString(currentLine + " " + word, font).Width > width)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
                if (currentLine.Length > 0)
                {
                    currentLine.Append(" " + word);
                }
                else
                {
                    currentLine.Append(word);
                }
            }
            if (currentLine.Length > 0)
            {
                lines.Add(currentLine.ToString());
            }
            return lines;
        }
        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            const int WM_POINTERDOWN = 0x0246;
            const int WM_POINTERUP = 0x0247;

            Point screenPos;
            Point clientPos;

            switch (msg.Msg)
            {
                case WM_POINTERDOWN:
                    screenPos = Control.MousePosition;
                    clientPos = this.PointToClient(screenPos);
                    OnMouseDown(new MouseEventArgs(MouseButtons.Left, 1, clientPos.X, clientPos.Y, 0));
                    break;
                case WM_POINTERUP:
                    screenPos = Control.MousePosition;
                    clientPos = this.PointToClient(screenPos);
                    OnMouseUp(new MouseEventArgs(MouseButtons.Left, 1, clientPos.X, clientPos.Y, 0));
                    PerformClick();
                    break;
                default:
                    base.WndProc(ref msg);
                    break;
            }
        }

    }

}
