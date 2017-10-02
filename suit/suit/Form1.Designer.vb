<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CostumerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuitDataSet = New suit.SuitDataSet()
        Me.SuitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostumerTableAdapter = New suit.SuitDataSetTableAdapters.CostumerTableAdapter()
        Me.SalesTableAdapter = New suit.SuitDataSetTableAdapters.SalesTableAdapter()
        Me.SuitTableAdapter = New suit.SuitDataSetTableAdapters.SuitTableAdapter()
        Me.tabR = New System.Windows.Forms.TabControl()
        Me.tabCostumer = New System.Windows.Forms.TabPage()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnViewDBA = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtPnum = New System.Windows.Forms.TextBox()
        Me.tabSuit = New System.Windows.Forms.TabPage()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnViewdba2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSuitnum = New System.Windows.Forms.TextBox()
        Me.cobGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSname = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.tabSales = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnViewdba3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSid2 = New System.Windows.Forms.TextBox()
        Me.txtCid2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabReport = New System.Windows.Forms.TabPage()
        Me.btnR = New System.Windows.Forms.Button()
        Me.rtbReport = New System.Windows.Forms.RichTextBox()
        CType(Me.CostumerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabR.SuspendLayout()
        Me.tabCostumer.SuspendLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSuit.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSales.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.tabReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'CostumerBindingSource
        '
        Me.CostumerBindingSource.DataMember = "Costumer"
        Me.CostumerBindingSource.DataSource = Me.SuitDataSet
        '
        'SuitDataSet
        '
        Me.SuitDataSet.DataSetName = "SuitDataSet"
        Me.SuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuitBindingSource
        '
        Me.SuitBindingSource.DataMember = "Suit"
        Me.SuitBindingSource.DataSource = Me.SuitDataSet
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.SuitDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(819, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'CostumerTableAdapter
        '
        Me.CostumerTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'SuitTableAdapter
        '
        Me.SuitTableAdapter.ClearBeforeFill = True
        '
        'tabR
        '
        Me.tabR.Controls.Add(Me.tabCostumer)
        Me.tabR.Controls.Add(Me.tabSuit)
        Me.tabR.Controls.Add(Me.tabSales)
        Me.tabR.Controls.Add(Me.tabReport)
        Me.tabR.Location = New System.Drawing.Point(0, 27)
        Me.tabR.Name = "tabR"
        Me.tabR.SelectedIndex = 0
        Me.tabR.Size = New System.Drawing.Size(795, 366)
        Me.tabR.TabIndex = 0
        '
        'tabCostumer
        '
        Me.tabCostumer.BackColor = System.Drawing.Color.AliceBlue
        Me.tabCostumer.Controls.Add(Me.BindingNavigator)
        Me.tabCostumer.Controls.Add(Me.btnViewDBA)
        Me.tabCostumer.Controls.Add(Me.Label10)
        Me.tabCostumer.Controls.Add(Me.PictureBox1)
        Me.tabCostumer.Controls.Add(Me.Label15)
        Me.tabCostumer.Controls.Add(Me.txtCID)
        Me.tabCostumer.Controls.Add(Me.Label1)
        Me.tabCostumer.Controls.Add(Me.txtZip)
        Me.tabCostumer.Controls.Add(Me.Label20)
        Me.tabCostumer.Controls.Add(Me.Label8)
        Me.tabCostumer.Controls.Add(Me.Label9)
        Me.tabCostumer.Controls.Add(Me.Label6)
        Me.tabCostumer.Controls.Add(Me.Label7)
        Me.tabCostumer.Controls.Add(Me.Label5)
        Me.tabCostumer.Controls.Add(Me.Label4)
        Me.tabCostumer.Controls.Add(Me.lbl1)
        Me.tabCostumer.Controls.Add(Me.txtLname)
        Me.tabCostumer.Controls.Add(Me.txtFname)
        Me.tabCostumer.Controls.Add(Me.txtState)
        Me.tabCostumer.Controls.Add(Me.txtAddress)
        Me.tabCostumer.Controls.Add(Me.txtCity)
        Me.tabCostumer.Controls.Add(Me.txtPnum)
        Me.tabCostumer.Location = New System.Drawing.Point(4, 22)
        Me.tabCostumer.Name = "tabCostumer"
        Me.tabCostumer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCostumer.Size = New System.Drawing.Size(787, 340)
        Me.tabCostumer.TabIndex = 0
        Me.tabCostumer.Text = "Costumer"
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.CostumerBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.BindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(781, 25)
        Me.BindingNavigator.TabIndex = 8
        Me.BindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'btnViewDBA
        '
        Me.btnViewDBA.Location = New System.Drawing.Point(288, 292)
        Me.btnViewDBA.Name = "btnViewDBA"
        Me.btnViewDBA.Size = New System.Drawing.Size(107, 42)
        Me.btnViewDBA.TabIndex = 8
        Me.btnViewDBA.Text = "View DataBase"
        Me.btnViewDBA.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(58, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(684, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Click the plus sign and then enter data in the appropriate fields so it can be ad" &
    "ded data into the costumer database."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(620, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 13)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "ID"
        '
        'txtCID
        '
        Me.txtCID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "Costumer ID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCID.Location = New System.Drawing.Point(107, 136)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(100, 20)
        Me.txtCID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Zip"
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "Zip Code", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtZip.Location = New System.Drawing.Point(484, 170)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(281, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 25)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = "Larry’s Suits"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Address "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "First Name"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(318, 113)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(54, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Costumer "
        '
        'txtLname
        '
        Me.txtLname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "Last Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLname.Location = New System.Drawing.Point(107, 192)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(100, 20)
        Me.txtLname.TabIndex = 2
        '
        'txtFname
        '
        Me.txtFname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "First  Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFname.Location = New System.Drawing.Point(107, 166)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 20)
        Me.txtFname.TabIndex = 1
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "State", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtState.Location = New System.Drawing.Point(484, 136)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "Address", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAddress.Location = New System.Drawing.Point(306, 166)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "City", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCity.Location = New System.Drawing.Point(306, 196)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtPnum
        '
        Me.txtPnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostumerBindingSource, "Phone Number", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPnum.Location = New System.Drawing.Point(306, 136)
        Me.txtPnum.Name = "txtPnum"
        Me.txtPnum.Size = New System.Drawing.Size(100, 20)
        Me.txtPnum.TabIndex = 3
        '
        'tabSuit
        '
        Me.tabSuit.BackColor = System.Drawing.Color.LightSlateGray
        Me.tabSuit.Controls.Add(Me.BindingNavigator1)
        Me.tabSuit.Controls.Add(Me.btnViewdba2)
        Me.tabSuit.Controls.Add(Me.PictureBox3)
        Me.tabSuit.Controls.Add(Me.Label16)
        Me.tabSuit.Controls.Add(Me.Label19)
        Me.tabSuit.Controls.Add(Me.Label21)
        Me.tabSuit.Controls.Add(Me.txtSuitnum)
        Me.tabSuit.Controls.Add(Me.cobGender)
        Me.tabSuit.Controls.Add(Me.Label11)
        Me.tabSuit.Controls.Add(Me.Label12)
        Me.tabSuit.Controls.Add(Me.Label13)
        Me.tabSuit.Controls.Add(Me.Label14)
        Me.tabSuit.Controls.Add(Me.lblName)
        Me.tabSuit.Controls.Add(Me.Label2)
        Me.tabSuit.Controls.Add(Me.txtSname)
        Me.tabSuit.Controls.Add(Me.txtSize)
        Me.tabSuit.Controls.Add(Me.txtMaterial)
        Me.tabSuit.Controls.Add(Me.txtColor)
        Me.tabSuit.Location = New System.Drawing.Point(4, 22)
        Me.tabSuit.Name = "tabSuit"
        Me.tabSuit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSuit.Size = New System.Drawing.Size(787, 340)
        Me.tabSuit.TabIndex = 1
        Me.tabSuit.Text = "Suit"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.BindingNavigator1.BindingSource = Me.SuitBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator1.Size = New System.Drawing.Size(781, 25)
        Me.BindingNavigator1.TabIndex = 107
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnViewdba2
        '
        Me.btnViewdba2.Location = New System.Drawing.Point(283, 292)
        Me.btnViewdba2.Name = "btnViewdba2"
        Me.btnViewdba2.Size = New System.Drawing.Size(107, 42)
        Me.btnViewdba2.TabIndex = 6
        Me.btnViewdba2.Text = "View DataBase"
        Me.btnViewdba2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(620, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(161, 234)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 106
        Me.PictureBox3.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(81, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(540, 16)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Enter data in the appropriate fields and then click submit to add data into the s" &
    "uit database."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(278, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 25)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Larry’s Suits"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(140, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 101
        Me.Label21.Text = "Suit #"
        '
        'txtSuitnum
        '
        Me.txtSuitnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuitBindingSource, "Suit ID", True))
        Me.txtSuitnum.Location = New System.Drawing.Point(193, 128)
        Me.txtSuitnum.Name = "txtSuitnum"
        Me.txtSuitnum.Size = New System.Drawing.Size(100, 20)
        Me.txtSuitnum.TabIndex = 0
        '
        'cobGender
        '
        Me.cobGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuitBindingSource, "Gender", True))
        Me.cobGender.DisplayMember = "asad"
        Me.cobGender.FormattingEnabled = True
        Me.cobGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cobGender.Location = New System.Drawing.Point(398, 180)
        Me.cobGender.Name = "cobGender"
        Me.cobGender.Size = New System.Drawing.Size(100, 21)
        Me.cobGender.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(345, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Gender"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(140, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Material"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(345, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(345, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Color"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(140, 157)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 94
        Me.lblName.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Suit"
        '
        'txtSname
        '
        Me.txtSname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuitBindingSource, "Name", True))
        Me.txtSname.Location = New System.Drawing.Point(193, 154)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(100, 20)
        Me.txtSname.TabIndex = 1
        '
        'txtSize
        '
        Me.txtSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuitBindingSource, "Size", True))
        Me.txtSize.Location = New System.Drawing.Point(398, 154)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSize.TabIndex = 4
        '
        'txtMaterial
        '
        Me.txtMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuitBindingSource, "Material", True))
        Me.txtMaterial.Location = New System.Drawing.Point(193, 181)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterial.TabIndex = 2
        '
        'txtColor
        '
        Me.txtColor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuitBindingSource, "Color", True))
        Me.txtColor.Location = New System.Drawing.Point(398, 128)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 3
        '
        'tabSales
        '
        Me.tabSales.BackColor = System.Drawing.Color.SteelBlue
        Me.tabSales.Controls.Add(Me.Label25)
        Me.tabSales.Controls.Add(Me.Label24)
        Me.tabSales.Controls.Add(Me.Label22)
        Me.tabSales.Controls.Add(Me.Label23)
        Me.tabSales.Controls.Add(Me.btnViewdba3)
        Me.tabSales.Controls.Add(Me.PictureBox2)
        Me.tabSales.Controls.Add(Me.txtSid2)
        Me.tabSales.Controls.Add(Me.txtCid2)
        Me.tabSales.Controls.Add(Me.Label17)
        Me.tabSales.Controls.Add(Me.Label18)
        Me.tabSales.Controls.Add(Me.Label3)
        Me.tabSales.Controls.Add(Me.txtCost)
        Me.tabSales.Controls.Add(Me.txtPrice)
        Me.tabSales.Controls.Add(Me.BindingNavigator3)
        Me.tabSales.Location = New System.Drawing.Point(4, 22)
        Me.tabSales.Name = "tabSales"
        Me.tabSales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSales.Size = New System.Drawing.Size(787, 340)
        Me.tabSales.TabIndex = 2
        Me.tabSales.Text = "Sales"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(150, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 13)
        Me.Label25.TabIndex = 109
        Me.Label25.Text = "Costumer ID"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(150, 182)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 108
        Me.Label24.Text = "Suit ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(78, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(507, 32)
        Me.Label22.TabIndex = 107
        Me.Label22.Text = "Enter data in the appropriate fields and then click submit to add data to the dat" &
    "abase." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                  This tab is to add data and relate the" &
    " two table togather. "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(275, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 25)
        Me.Label23.TabIndex = 106
        Me.Label23.Text = "Larry’s Suits"
        '
        'btnViewdba3
        '
        Me.btnViewdba3.Location = New System.Drawing.Point(293, 292)
        Me.btnViewdba3.Name = "btnViewdba3"
        Me.btnViewdba3.Size = New System.Drawing.Size(107, 42)
        Me.btnViewdba3.TabIndex = 4
        Me.btnViewdba3.Text = "View DataBase"
        Me.btnViewdba3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(620, 100)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 234)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'txtSid2
        '
        Me.txtSid2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Suit ID", True))
        Me.txtSid2.Location = New System.Drawing.Point(221, 179)
        Me.txtSid2.Name = "txtSid2"
        Me.txtSid2.Size = New System.Drawing.Size(100, 20)
        Me.txtSid2.TabIndex = 1
        '
        'txtCid2
        '
        Me.txtCid2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Costumer ID", True))
        Me.txtCid2.Location = New System.Drawing.Point(221, 153)
        Me.txtCid2.Name = "txtCid2"
        Me.txtCid2.Size = New System.Drawing.Size(100, 20)
        Me.txtCid2.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(343, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Cost to Make"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(343, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "Suit Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Sales"
        '
        'txtCost
        '
        Me.txtCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Cost to Make/Buy", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtCost.Location = New System.Drawing.Point(413, 179)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 3
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Suit Price", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtPrice.Location = New System.Drawing.Point(413, 153)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 2
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator3.BindingSource = Me.SalesBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator3.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator3.Size = New System.Drawing.Size(781, 25)
        Me.BindingNavigator3.TabIndex = 0
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tabReport
        '
        Me.tabReport.BackColor = System.Drawing.Color.DimGray
        Me.tabReport.Controls.Add(Me.btnR)
        Me.tabReport.Controls.Add(Me.rtbReport)
        Me.tabReport.Location = New System.Drawing.Point(4, 22)
        Me.tabReport.Name = "tabReport"
        Me.tabReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReport.Size = New System.Drawing.Size(787, 340)
        Me.tabReport.TabIndex = 3
        Me.tabReport.Text = "Report"
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(345, 306)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(75, 23)
        Me.btnR.TabIndex = 1
        Me.btnR.Text = "View Report"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'rtbReport
        '
        Me.rtbReport.Enabled = False
        Me.rtbReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbReport.Location = New System.Drawing.Point(104, 50)
        Me.rtbReport.Name = "rtbReport"
        Me.rtbReport.Size = New System.Drawing.Size(547, 250)
        Me.rtbReport.TabIndex = 0
        Me.rtbReport.Text = ""
        Me.rtbReport.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.tabR)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Larry's Suits"
        CType(Me.CostumerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabR.ResumeLayout(False)
        Me.tabCostumer.ResumeLayout(False)
        Me.tabCostumer.PerformLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSuit.ResumeLayout(False)
        Me.tabSuit.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSales.ResumeLayout(False)
        Me.tabSales.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.tabReport.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuitDataSet As suit.SuitDataSet
    Friend WithEvents CostumerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostumerTableAdapter As suit.SuitDataSetTableAdapters.CostumerTableAdapter
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As suit.SuitDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents SuitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuitTableAdapter As suit.SuitDataSetTableAdapters.SuitTableAdapter
    Friend WithEvents tabR As System.Windows.Forms.TabControl
    Friend WithEvents tabCostumer As System.Windows.Forms.TabPage
    Friend WithEvents btnViewDBA As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPnum As System.Windows.Forms.TextBox
    Friend WithEvents tabSuit As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSuitnum As System.Windows.Forms.TextBox
    Friend WithEvents cobGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSname As System.Windows.Forms.TextBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents tabSales As System.Windows.Forms.TabPage
    Friend WithEvents BindingNavigator3 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnViewdba2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnViewdba3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSid2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCid2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabReport As System.Windows.Forms.TabPage
    Friend WithEvents rtbReport As System.Windows.Forms.RichTextBox
    Friend WithEvents btnR As System.Windows.Forms.Button

End Class
