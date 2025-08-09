Imports System.Data.SqlClient

Public Class Sform
    Private connectionString As String = "Data Source=IA-CCTV,1433;Network Library=DBMSSOCN;Initial Catalog=GoodsReleasing;User ID=sa;Password=otcadmin"

    Private Sub Sform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateRecord(id As String, name As String, position As String, department As String, status As String, time As String, remarks As String)
        Dim sqlQuery As String = "UPDATE Releasing SET Name = @Name, Position = @Position, Department = @Department, Status = @Status, [Time of Recieved] = @Time, Remarks = @Remarks WHERE [ID] = @ID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlQuery, connection)


                ' Adding parameters to avoid SQL injection 
                command.Parameters.AddWithValue("@ID", id)
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

    Public Sub ImportData(id As String, name As String, position As String, department As String, status As String, time As String, otc As String, ham As String, calendar As String, shirt As String, cheeseball As String, canned As String, bonus As String, others As String, remarks As String)
        TxtID.Text = id
        TxtName.Text = name
        TxtPosition.Text = position
        TxtDepartment.Text = department
        TxtStatus.Text = status
        TxtTime.Text = time
        ChkBag.Checked = (otc = "1")
        ChkHam.Checked = (ham = "1")
        ChkCalendar.Checked = (calendar = "1")
        ChkShirt.Checked = (shirt = "1")
        ChkCheese.Checked = (cheeseball = "1")
        ChkCannedGoods.Checked = (canned = "1")
        ChkBonus.Checked = (bonus = "1")
        ChkOthers.Checked = (others = "1")
        TxtRemarks.Text = (remarks)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim id As String = TxtID.Text
            Dim name As String = TxtName.Text
            Dim position As String = TxtPosition.Text
            Dim department As String = TxtDepartment.Text
            Dim status As String = TxtStatus.Text
            Dim time As DateTime = DateTime.Now
            Dim remarks As String = TxtRemarks.Text

            If String.IsNullOrEmpty(name) Then
                MessageBox.Show("Please Enter the Employee ID", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateRecord(id, name, position, department, status, time, remarks) ' Call updateRecord to save the guest information updates in the database
                UpdateCheckboxes(id)
            End If

            Application.Restart()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateCheckboxes(id As String)
        UpdateCheckbox("OTC Bag pack", ChkBag.Checked, id)
        UpdateCheckbox("Ham", ChkHam.Checked, id)
        UpdateCheckbox("Calendar", ChkCalendar.Checked, id)
        UpdateCheckbox("Shirt", ChkShirt.Checked, id)
        UpdateCheckbox("Cheeseball", ChkCheese.Checked, id)
        UpdateCheckbox("Canned Goods", ChkCannedGoods.Checked, id)
        UpdateCheckbox("Bonus", ChkBonus.Checked, id)
        UpdateCheckbox("Others", ChkOthers.Checked, id)
    End Sub


    Private Sub UpdateCheckbox(ColumnName As String, checked As Boolean, id As String)
        Dim sqlquery As String

        Try
            If checked Then
                sqlquery = $"UPDATE Releasing SET [{ColumnName}] = '1' WHERE ID = @ID"
            Else
                sqlquery = $"UPDATE Releasing SET [{ColumnName}] = NULL WHERE ID = @ID"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sqlquery, connection)
                    command.Parameters.AddWithValue("@ID", id)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class