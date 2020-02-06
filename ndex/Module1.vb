Imports System.Data.Odbc
Module Module1
    Public CONN As OdbcConnection
    Public DS As DataSet
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public CMD As OdbcCommand
    Public DT As DataTable
    Public sql As String = "Dsn=DNSPerpus;server=localhost;uid=root;database=perpustakaan;port=3306"

    Public Sub Koneksi()
        Try
            sql = "Dsn=DNSPerpus;server=localhost;uid=root;database=perpustakaan;port=3306"
            CONN = New OdbcConnection(sql)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Module
