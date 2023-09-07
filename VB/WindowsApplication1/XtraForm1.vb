Imports DevExpress.Utils

Namespace WindowsApplication1

    Public Partial Class XtraForm1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Function CreateFormBorderPainter() As DevExpress.Skins.XtraForm.FormPainter
            Dim formCaptionAlignment As HorzAlignment = HorzAlignment.Center
            Return New CustomFormPainter(Me, LookAndFeel, formCaptionAlignment)
        End Function
    End Class
End Namespace
