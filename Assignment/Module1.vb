Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Library.accdb")
    Public com As OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

End Module
