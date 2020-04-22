Imports System

Imports Teigha.Runtime
Imports Teigha.DatabaseServices
Imports Teigha.Geometry
Imports Bricscad.ApplicationServices
Imports Bricscad.Runtime
Imports Bricscad.EditorInput

' https://knowledge.autodesk.com/ja/search-result/caas/CloudHelp/cloudhelp/2015/JPN/AutoCAD-NET/files/GUID-3B2760FE-A0DC-4229-AEBE-5CC83290BA95-htm.html

<Assembly: CommandClass(GetType(LispTest1.Class1))> 
Namespace LispTest1
    Public Class Class1
        <LispFunction("Hoge")>
        Public Function Hoge(args As ResultBuffer) As ResultBuffer
            Dim rv As New ResultBuffer
            If args IsNot Nothing Then
                Dim strVal1 As String = "", strVal2 As String = ""

                Dim nCnt As Integer = 0
                For Each rb As TypedValue In args
                    If rb.TypeCode = LispDataType.Text Then
                        rv.Add(New TypedValue(LispDataType.Text, "[" & rb.Value.ToString() & "]"))
                    End If
                Next
            End If
            Return rv
        End Function
    End Class
End Namespace
