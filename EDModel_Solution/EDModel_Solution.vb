'Joshua Pickenpaugh
'October 8th, 2016
'Unit 2 Project (Connecting to SQL Server via ADO and EDM).

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
'Below is changed from "Imports System.Data.EntityClient" to this as of VS 4.3:
Imports System.Data.Entity.Core.EntityClient
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class EDModel_Solution
    Private Sub btnShowFaculty_Click(sender As Object, e As EventArgs) Handles btnShowFaculty.Click

        'Mismatch from book; should be "Faculty_TYPED_IN" as fname, NOT "Faculties"!!!:
        Dim cmdString As String = "SELECT fname.faculty_name FROM CSE_DEPT_TYPED_INEntities.Faculty_TYPED_IN as fname"
        Dim Conn = New EntityConnection("name=CSE_DEPT_TYPED_INEntities")
        Conn.Open()
        Dim cmd = Conn.CreateCommand()
        cmd.CommandText = cmdString
        Dim rd As EntityDataReader
        rd = cmd.ExecuteReader(CommandBehavior.SequentialAccess)
        'Clears the list box before being filled:
        lstFaculty.Items.Clear()

        While (rd.Read())
            lstFaculty.Items.Add(rd("faculty_name"))
        End While

        Conn.Close()
    End Sub
End Class
