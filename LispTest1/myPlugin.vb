Imports Teigha.Runtime
Imports Teigha.DatabaseServices
Imports Teigha.Geometry
Imports Bricscad.ApplicationServices
Imports Bricscad.Runtime
Imports Bricscad.EditorInput

<Assembly: ExtensionApplication(GetType(LispTest1.Plugin))> 
Namespace LispTest1
    Public Class Plugin
        Implements IExtensionApplication

        Public Sub Initialize() Implements IExtensionApplication.Initialize

        End Sub

        Public Sub Terminate() Implements IExtensionApplication.Terminate

        End Sub
    End Class
End Namespace
