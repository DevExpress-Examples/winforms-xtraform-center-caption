Imports DevExpress.Skins
Imports DevExpress.Skins.XtraForm
Imports DevExpress.Utils
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Class CustomFormPainter
        Inherits FormPainter

        Public Sub New(ByVal owner As Control, ByVal provider As ISkinProvider)
            MyBase.New(owner, provider)
        End Sub

        Private _CaptionAlignment As HorzAlignment = HorzAlignment.Default

        Public Property CaptionAlignment As HorzAlignment
            Get
                Return _CaptionAlignment
            End Get

            Set(ByVal value As HorzAlignment)
                _CaptionAlignment = value
            End Set
        End Property

        Public Sub New(ByVal owner As XtraForm1, ByVal provider As DevExpress.LookAndFeel.UserLookAndFeel, ByVal captionAlignment As HorzAlignment)
            MyBase.New(owner, provider)
            Me.CaptionAlignment = captionAlignment
        End Sub

        Protected Overrides Sub DrawText(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache)
            Dim text As String = Me.Text
            If Equals(text, Nothing) OrElse text.Length = 0 OrElse TextBounds.IsEmpty Then
                Return
            End If

            Dim appearance As AppearanceObject = New AppearanceObject(GetDefaultAppearance())
            appearance.TextOptions.Trimming = Trimming.EllipsisCharacter
            appearance.TextOptions.HAlignment = CaptionAlignment
            If AllowHtmlDraw Then
                DrawHtmlText(cache, appearance)
                Return
            End If

            Dim r As Rectangle = RectangleHelper.GetCenterBounds(TextBounds, New Size(TextBounds.Width, CalcTextHeight(cache, appearance)))
            DrawTextShadow(cache, appearance, r)
            cache.DrawString(text, appearance.Font, appearance.GetForeBrush(cache), r, appearance.GetStringFormat())
        End Sub
    End Class
End Namespace
