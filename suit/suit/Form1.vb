'Muhammad Asad Siddiqui
'CTS 289
'Due Date 4/28/13

'Imports System.Data.OleDb
Public Class Form1

    'Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Asad\Documents\Visual Studio 2012\Projects\suit\suit\Suit.accdb"
    'Dim Con As OleDbConnection = New OleDbConnection(constr)
    'Con.Open()
    'Dim com As OleDbCommand = New OleDbCommand
    'com.Connection = Con
    'com = New OleDbCommand("INSERT INTO Customer(Customer ID,F Name,L Name," & _
    '               "Phone Number,City,State,Zip Code) VALUES ('" + txtCID.Text + "' , '" & _
    '               +txtFname.Text + "' , '" + txtLname.Text + " ' , '" + txtPnum.Text + "' , '" & _
    '               +txtAddress.Text + "' , '" + txtCity.Text + " ' , '" + txtState.Text + "' , '" & _
    '               +txtZip.Text + " ' ); )", Con)

    'Dim Num As Integer = com.ExecuteNonQuery
    'If (Num <> 0) Then
    'MessageBox.Show("Record Successfully Added....", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'Me.Close()
    'Else
    'MessageBox.Show("Record is not Added....", "Add Record Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ' End If

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        MessageBox.Show("This is Larry's suit program. For help call (336)333-3210 ")
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        MessageBox.Show("This is Larry's suit program. Made to help Larry go digital with his business! ")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuitDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.SuitDataSet.Sales)
        'TODO: This line of code loads data into the 'SuitDataSet.Suit' table. You can move, or remove it, as needed.
        Me.SuitTableAdapter.Fill(Me.SuitDataSet.Suit)
        'TODO: This line of code loads data into the 'SuitDataSet.Costumer' table. You can move, or remove it, as needed.
        Me.CostumerTableAdapter.Fill(Me.SuitDataSet.Costumer)
        
    End Sub
    Private Sub btnViewdba2_Click(sender As Object, e As EventArgs) Handles btnViewdba2.Click
        DataBase.TabControl.SelectedIndex = 1
        DataBase.dgvSuits.DataSource = SuitBindingSource
        DataBase.Show()
    End Sub

    Private Sub btnViewdba3_Click(sender As Object, e As EventArgs) Handles btnViewdba3.Click
        DataBase.TabControl.SelectedIndex = 2
        DataBase.dgvSales.DataSource = SalesBindingSource
        DataBase.Show()
    End Sub

    Private Sub btnViewDBA_Click(sender As Object, e As EventArgs) Handles btnViewDBA.Click
        DataBase.TabControl.SelectedIndex = 0
        DataBase.dgvCostumer.DataSource = CostumerBindingSource


        DataBase.Show()
    End Sub
    

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        DataBase.dgvCostumer.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
        DataBase.dgvCostumer.Update()

    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim CTMB = SuitDataSet.Sales.Sum(Function(i) i._Cost_to_Make_Buy)
        Dim SP = SuitDataSet.Sales.Sum(Function(i) i.Suit_Price)
        Dim Suitnum = 0
        Dim CNum = 0
        Suitnum = SuitDataSet.Suit.Rows.Count + 1
        CNum = SuitDataSet.Costumer.Rows.Count + 1
        Dim SCP = SP - CTMB

        rtbReport.AppendText(vbTab + vbTab + "Number of Suits sold:" + "           ")
        rtbReport.AppendText(Suitnum)
        rtbReport.AppendText(vbNewLine)
        rtbReport.AppendText(vbTab + vbTab + "Number of costumers:" + "          ")
        rtbReport.AppendText(CNum)
        rtbReport.AppendText(vbNewLine)
        rtbReport.AppendText(vbTab + vbTab + "Total cost to make:" + vbTab + "            $")
        rtbReport.AppendText(CTMB)
        rtbReport.AppendText(vbNewLine)
        rtbReport.AppendText(vbTab + vbTab + "Total Sold:" + vbTab + "                        $")
        rtbReport.AppendText(SP)
        rtbReport.AppendText(vbNewLine)
        rtbReport.AppendText(vbTab + vbTab + "Total Profit from Suits:         " + "$")
        rtbReport.AppendText(SCP)
        rtbReport.AppendText(vbNewLine)
        rtbReport.Visible = True
    End Sub
End Class

