Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace WindowsApplication1

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call SkinManager.EnableFormSkins()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            Call Application.Run(New XtraForm1())
        End Sub
    End Module
End Namespace
