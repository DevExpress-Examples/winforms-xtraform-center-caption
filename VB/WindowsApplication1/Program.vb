Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace WindowsApplication1
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            SkinManager.EnableFormSkins()
            Application.Run(New XtraForm1())
        End Sub
    End Class
End Namespace