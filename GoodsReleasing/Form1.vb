Imports System.Data.SqlClient

Public Class Form1
    Private connectionString As String = "Data Source=IA-CCTV,1433;Network Library=DBMSSOCN;Initial Catalog=GoodsReleasing;User ID=sa;Password=otcadmin"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GoodsReleasingDataSet.Releasing' table. You can move, or remove it, as needed.
        Me.ReleasingTableAdapter.Fill(Me.GoodsReleasingDataSet.Releasing)

        CalculateDiff()
    End Sub

    Private Sub TxtSId_TextChanged(sender As Object, e As EventArgs) Handles TxtSId.TextChanged
        Try
            Dim filter As String = TxtSId.Text.Trim()
            Dim dv As New DataView(GoodsReleasingDataSet.Releasing) ' Create a new DataView for filtering

            If String.IsNullOrEmpty(filter) Then
                dv.RowFilter = String.Empty ' Clear filter if input is empty
            Else
                dv.RowFilter = String.Format("ID LIKE '%{0}%'", filter) ' Apply filter based on name search

                DtView.DataSource = dv  'Set filtered data as the DataSource for DataGridView
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtSName_TextChanged(sender As Object, e As EventArgs) Handles TxtSName.TextChanged
        Try
            Dim filter As String = TxtSName.Text.Trim()
            Dim dv As New DataView(GoodsReleasingDataSet.Releasing) ' Create a new DataView for filtering

            If String.IsNullOrEmpty(filter) Then
                dv.RowFilter = String.Empty ' Clear filter if input is empty
            Else
                dv.RowFilter = String.Format("Name LIKE '%{0}%'", filter) ' Apply filter based on name search

                DtView.DataSource = dv  'Set filtered data as the DataSource for DataGridView
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtSDepartment_TextChanged(sender As Object, e As EventArgs) Handles TxtSDepartment.TextChanged
        Try
            Dim filter As String = TxtSDepartment.Text.Trim()
            Dim dv As New DataView(GoodsReleasingDataSet.Releasing) ' Create a new DataView for filtering

            If String.IsNullOrEmpty(filter) Then
                dv.RowFilter = String.Empty ' Clear filter if input is empty
            Else
                dv.RowFilter = String.Format("Department LIKE '%{0}%'", filter) ' Apply filter based on name search

                DtView.DataSource = dv  'Set filtered data as the DataSource for DataGridView
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtView.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DtView.Rows(e.RowIndex)

                Dim form As New Sform()

                ' Pass selected cell values to GForm for processing (ensure proper indexing)
                form.ImportData(row.Cells(0).Value.ToString(),
                              row.Cells(1).Value.ToString(),
                              row.Cells(2).Value.ToString(),
                              row.Cells(3).Value.ToString(),
                              row.Cells(4).Value.ToString(),
                              row.Cells(5).Value.ToString(),
                              row.Cells(6).Value.ToString(),
                              row.Cells(7).Value.ToString(),
                              row.Cells(8).Value.ToString(),
                              row.Cells(9).Value.ToString(),
                              row.Cells(10).Value.ToString(),
                              row.Cells(11).Value.ToString(),
                              row.Cells(12).Value.ToString(),
                              row.Cells(13).Value.ToString(),
                              row.Cells(14).Value.ToString())
                form.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Application.Restart()
    End Sub

    Private Sub CalculateDiff()
        Dim sum As Integer = 0
        Dim diff As Integer = 0
        Dim dv As New DataView(GoodsReleasingDataSet.Releasing)

        Try
            For Each row As DataRowView In dv
                If row(4).ToString() = "Recieved" Then
                    sum += 1
                ElseIf String.IsNullOrEmpty(row(4).ToString()) Then
                    diff += 1
                End If
            Next
            UpdateLabels(sum, diff)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UpdateLabels(sum As Integer, diff As String)
        Label5.Text = sum.ToString()
        Label6.Text = diff.ToString()
        Label7.Text = Math.Floor((sum / (sum + diff)) * 100).ToString() + "%"
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Try
            Dim result As DialogResult = MessageBox.Show("  Do you really want to reset all the data?", "Warning!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                MessageBox.Show("Successfully Reset the Data!")
                Dim sqlQuery As String = "UPDATE Releasing SET Status = NULL ,[Time of Recieved] = NULL, Remarks = NULL, [OTC Bag pack] = NULL, Ham = NULL, Calendar = NULL, Shirt = NULL, Cheeseball = NULL, [Canned Goods] = NULL, Bonus = NULL, Others = NULL  WHERE Status = 'Recieved' OR Status = 'Incomplete'"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(sqlQuery, connection)
                        Dim adapter As New SqlDataAdapter(command)
                        Dim table As New DataTable()

                        connection.Open()
                        adapter.Fill(table)

                        DtView.DataSource = table
                    End Using
                End Using

                Application.Restart()
            ElseIf result = DialogResult.No Then
                MessageBox.Show("operation cancelled!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim nform As New Form3()
        nform.Show()
    End Sub
End Class
