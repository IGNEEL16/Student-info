Imports System.Data.SqlClient

Module Module1
    Public cn As New SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public str As String

    Public Sub conn()
        cn = New SqlConnection("Data Source=DESKTOP-2LLV29I\MSSQLSERVER01;Initial Catalog=SIM;Integrated Security=True;Pooling=False")


    End Sub
End Module
