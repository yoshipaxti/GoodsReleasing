Imports System.Data.SqlClient

Public Class Form3

    Public ConnectionString As String = "Data Source=IA-CCTV,1433;Network Library=DBMSSOCN;Initial Catalog=GoodsReleasing;User ID=sa;Password=otcadmin"

    Private Sub SaveRecord(id As String, name As String, position As String, department As String, status As String, time As String, remarks As String)
        Dim sqlQuery As String = "INSERT INTO Releasing (ID, Name, Position, Department, Status, [Time of Recieved], Remarks) VALUES (@Id, @Name, @Position, @Department, @Status, @Time, @Remarks)"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(sqlQuery, connection)


                ' Adding parameters to avoid SQL injection 
                command.Parameters.AddWithValue("@Id", id)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Position", position)
                command.Parameters.AddWithValue("@Department", department)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@Time", time)
                command.Parameters.AddWithValue("@Remarks", remarks)

                ' Open the connection if it's not already open
                If connection.State <> ConnectionState.Open Then
                    connection.Open()
                End If

                ' Execute the update query
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim id As String = TxtID.Text
            Dim name As String = TxtName.Text
            Dim position As String = TxtPosition.Text
            Dim department As String = TxtDepartment.Text
            Dim status As String = TxtStatus.Text
            Dim time As String = TxtTime.Text
            Dim remarks As String = TxtRemarks.Text

            If String.IsNullOrEmpty(name) Then
                MessageBox.Show("Please Enter the Employee ID", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SaveRecord(id, name, position, department, status, time, remarks) ' Call updateRecord to save the guest information updates in the database
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class