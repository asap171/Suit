<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabC = New System.Windows.Forms.TabPage()
        Me.dgvCostumer = New System.Windows.Forms.DataGridView()
        Me.tabSuit = New System.Windows.Forms.TabPage()
        Me.dgvSuits = New System.Windows.Forms.DataGridView()
        Me.tabSales = New System.Windows.Forms.TabPage()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.TabControl.SuspendLayout()
        Me.tabC.SuspendLayout()
        CType(Me.dgvCostumer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSuit.SuspendLayout()
        CType(Me.dgvSuits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSales.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabC)
        Me.TabControl.Controls.Add(Me.tabSuit)
        Me.TabControl.Controls.Add(Me.tabSales)
        Me.TabControl.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(848, 343)
        Me.TabControl.TabIndex = 1
        '
        'tabC
        '
        Me.tabC.Controls.Add(Me.dgvCostumer)
        Me.tabC.Location = New System.Drawing.Point(4, 22)
        Me.tabC.Name = "tabC"
        Me.tabC.Padding = New System.Windows.Forms.Padding(3)
        Me.tabC.Size = New System.Drawing.Size(840, 317)
        Me.tabC.TabIndex = 0
        Me.tabC.Text = "Costumer"
        Me.tabC.UseVisualStyleBackColor = True
        '
        'dgvCostumer
        '
        Me.dgvCostumer.AllowUserToAddRows = False
        Me.dgvCostumer.AllowUserToDeleteRows = False
        Me.dgvCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCostumer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCostumer.Location = New System.Drawing.Point(3, 3)
        Me.dgvCostumer.Name = "dgvCostumer"
        Me.dgvCostumer.ReadOnly = True
        Me.dgvCostumer.Size = New System.Drawing.Size(834, 311)
        Me.dgvCostumer.TabIndex = 2
        '
        'tabSuit
        '
        Me.tabSuit.Controls.Add(Me.dgvSuits)
        Me.tabSuit.Location = New System.Drawing.Point(4, 22)
        Me.tabSuit.Name = "tabSuit"
        Me.tabSuit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSuit.Size = New System.Drawing.Size(840, 317)
        Me.tabSuit.TabIndex = 1
        Me.tabSuit.Text = "Suits"
        Me.tabSuit.UseVisualStyleBackColor = True
        '
        'dgvSuits
        '
        Me.dgvSuits.AllowUserToAddRows = False
        Me.dgvSuits.AllowUserToDeleteRows = False
        Me.dgvSuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuits.Location = New System.Drawing.Point(3, 3)
        Me.dgvSuits.Name = "dgvSuits"
        Me.dgvSuits.ReadOnly = True
        Me.dgvSuits.Size = New System.Drawing.Size(834, 311)
        Me.dgvSuits.TabIndex = 2
        '
        'tabSales
        '
        Me.tabSales.Controls.Add(Me.dgvSales)
        Me.tabSales.Location = New System.Drawing.Point(4, 22)
        Me.tabSales.Name = "tabSales"
        Me.tabSales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSales.Size = New System.Drawing.Size(840, 317)
        Me.tabSales.TabIndex = 2
        Me.tabSales.Text = "Sales"
        Me.tabSales.UseVisualStyleBackColor = True
        '
        'dgvSales
        '
        Me.dgvSales.AllowUserToAddRows = False
        Me.dgvSales.AllowUserToDeleteRows = False
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSales.Location = New System.Drawing.Point(3, 3)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.ReadOnly = True
        Me.dgvSales.Size = New System.Drawing.Size(834, 311)
        Me.dgvSales.TabIndex = 2
        '
        'DataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 344)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "DataBase"
        Me.Text = "DataBase"
        Me.TabControl.ResumeLayout(False)
        Me.tabC.ResumeLayout(False)
        CType(Me.dgvCostumer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSuit.ResumeLayout(False)
        CType(Me.dgvSuits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSales.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabC As System.Windows.Forms.TabPage
    Friend WithEvents dgvCostumer As System.Windows.Forms.DataGridView
    Friend WithEvents tabSuit As System.Windows.Forms.TabPage
    Friend WithEvents dgvSuits As System.Windows.Forms.DataGridView
    Friend WithEvents tabSales As System.Windows.Forms.TabPage
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
End Class
