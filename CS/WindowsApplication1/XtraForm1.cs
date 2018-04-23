using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Utils;

namespace WindowsApplication1 {
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm {
        public XtraForm1() {
            InitializeComponent();
        }

        protected override DevExpress.Skins.XtraForm.FormPainter CreateFormBorderPainter() {
            HorzAlignment formCaptionAlignment = HorzAlignment.Center;
            return new CustomFormPainter(this, LookAndFeel, formCaptionAlignment);
        }
    }
}
