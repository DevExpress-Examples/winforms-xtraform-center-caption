using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public class CustomFormPainter : FormPainter {
        public CustomFormPainter(Control owner, DevExpress.Skins.ISkinProvider provider)
            : base(owner, provider) {
        }

        private HorzAlignment _CaptionAlignment = HorzAlignment.Default;
        public HorzAlignment CaptionAlignment {
            get {
                return _CaptionAlignment;
            }
            set {
                _CaptionAlignment = value;
            }
        }
        public CustomFormPainter(XtraForm1 owner, DevExpress.LookAndFeel.UserLookAndFeel provider, HorzAlignment captionAlignment)
            : base(owner, provider) {
            CaptionAlignment = captionAlignment;
        }
        protected override void DrawText(DevExpress.Utils.Drawing.GraphicsCache cache) {
            string text = Text;
            if (text == null || text.Length == 0 || TextBounds.IsEmpty) {
                return;
            }
            AppearanceObject appearance = new AppearanceObject(GetDefaultAppearance());
            appearance.TextOptions.Trimming = Trimming.EllipsisCharacter;
            appearance.TextOptions.HAlignment = CaptionAlignment;
            if (AllowHtmlDraw) {
                DrawHtmlText(cache, appearance);
                return;
            }
            Rectangle r = RectangleHelper.GetCenterBounds(TextBounds, new Size(TextBounds.Width, CalcTextHeight(cache, appearance)));
            DrawTextShadow(cache, appearance, r);
            cache.DrawString(text, appearance.Font, appearance.GetForeBrush(cache), r, appearance.GetStringFormat());
        }
    }
}
