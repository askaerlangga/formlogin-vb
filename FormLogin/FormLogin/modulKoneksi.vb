Imports System.Data.Odbc
Module modulKoneksi
    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Dim DB As String

    Sub bukaKoneksi()
        'Letak Database
        DB = "Driver={MySQL ODBC 8.0 ANSI Driver};Database=mysql_crud;server=localhost;uid=root"
        CONN = New OdbcConnection(DB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

    Sub tutupKoneksi()
        If CONN.State = ConnectionState.Open Then
            CONN.Close()
        End If
    End Sub
End Module
