<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim INVUNIQLabel As System.Windows.Forms.Label
        Dim INVDATELabel As System.Windows.Forms.Label
        Dim CUSTOMERLabel As System.Windows.Forms.Label
        Dim BILNAMELabel As System.Windows.Forms.Label
        Dim DESCLabel As System.Windows.Forms.Label
        Dim SEND_INVOICELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim SENDLabel As System.Windows.Forms.Label
        Me.OEINVHOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.OEINVHOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MFGCOMDataSet = New vb_sql.MFGCOMDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.INVUNIQLabel1 = New System.Windows.Forms.Label()
        Me.INVDATELabel1 = New System.Windows.Forms.Label()
        Me.CUSTOMERLabel1 = New System.Windows.Forms.Label()
        Me.BILNAMELabel1 = New System.Windows.Forms.Label()
        Me.DESCLabel1 = New System.Windows.Forms.Label()
        Me.SEND_INVOICELabel1 = New System.Windows.Forms.Label()
        Me.OEINVHOTableAdapter = New vb_sql.MFGCOMDataSetTableAdapters.OEINVHOTableAdapter()
        Me.TableAdapterManager = New vb_sql.MFGCOMDataSetTableAdapters.TableAdapterManager()
        Me.MFGCOMDataSet1 = New vb_sql.MFGCOMDataSet()
        Me.MFGCOMDataSet2 = New vb_sql.MFGCOMDataSet()
        Me.OEINVHOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OEINVHODataGridView = New System.Windows.Forms.DataGridView()
        Me.SENDComboBox = New System.Windows.Forms.ComboBox()
        Me.OEINVHOBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OEINVHO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OEINVHO1TableAdapter = New vb_sql.MFGCOMDataSetTableAdapters.OEINVHO1TableAdapter()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVNUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEND = New System.Windows.Forms.DataGridViewComboBoxColumn()
        INVUNIQLabel = New System.Windows.Forms.Label()
        INVDATELabel = New System.Windows.Forms.Label()
        CUSTOMERLabel = New System.Windows.Forms.Label()
        BILNAMELabel = New System.Windows.Forms.Label()
        DESCLabel = New System.Windows.Forms.Label()
        SEND_INVOICELabel = New System.Windows.Forms.Label()
        SENDLabel = New System.Windows.Forms.Label()
        CType(Me.OEINVHOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OEINVHOBindingNavigator.SuspendLayout()
        CType(Me.OEINVHOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFGCOMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFGCOMDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFGCOMDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEINVHOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEINVHODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEINVHOBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEINVHO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INVUNIQLabel
        '
        INVUNIQLabel.AutoSize = True
        INVUNIQLabel.Location = New System.Drawing.Point(237, 158)
        INVUNIQLabel.Name = "INVUNIQLabel"
        INVUNIQLabel.Size = New System.Drawing.Size(55, 13)
        INVUNIQLabel.TabIndex = 3
        INVUNIQLabel.Text = "INVUNIQ:"
        '
        'INVDATELabel
        '
        INVDATELabel.AutoSize = True
        INVDATELabel.Location = New System.Drawing.Point(237, 181)
        INVDATELabel.Name = "INVDATELabel"
        INVDATELabel.Size = New System.Drawing.Size(57, 13)
        INVDATELabel.TabIndex = 5
        INVDATELabel.Text = "INVDATE:"
        '
        'CUSTOMERLabel
        '
        CUSTOMERLabel.AutoSize = True
        CUSTOMERLabel.Location = New System.Drawing.Point(237, 204)
        CUSTOMERLabel.Name = "CUSTOMERLabel"
        CUSTOMERLabel.Size = New System.Drawing.Size(71, 13)
        CUSTOMERLabel.TabIndex = 7
        CUSTOMERLabel.Text = "CUSTOMER:"
        '
        'BILNAMELabel
        '
        BILNAMELabel.AutoSize = True
        BILNAMELabel.Location = New System.Drawing.Point(237, 227)
        BILNAMELabel.Name = "BILNAMELabel"
        BILNAMELabel.Size = New System.Drawing.Size(57, 13)
        BILNAMELabel.TabIndex = 9
        BILNAMELabel.Text = "BILNAME:"
        '
        'DESCLabel
        '
        DESCLabel.AutoSize = True
        DESCLabel.Location = New System.Drawing.Point(237, 250)
        DESCLabel.Name = "DESCLabel"
        DESCLabel.Size = New System.Drawing.Size(39, 13)
        DESCLabel.TabIndex = 11
        DESCLabel.Text = "DESC:"
        '
        'SEND_INVOICELabel
        '
        SEND_INVOICELabel.AutoSize = True
        SEND_INVOICELabel.Location = New System.Drawing.Point(237, 273)
        SEND_INVOICELabel.Name = "SEND_INVOICELabel"
        SEND_INVOICELabel.Size = New System.Drawing.Size(86, 13)
        SEND_INVOICELabel.TabIndex = 13
        SEND_INVOICELabel.Text = "SEND INVOICE:"
        '
        'OEINVHOBindingNavigator
        '
        Me.OEINVHOBindingNavigator.AddNewItem = Nothing
        Me.OEINVHOBindingNavigator.BindingSource = Me.OEINVHOBindingSource
        Me.OEINVHOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OEINVHOBindingNavigator.DeleteItem = Nothing
        Me.OEINVHOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1})
        Me.OEINVHOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OEINVHOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OEINVHOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OEINVHOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OEINVHOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OEINVHOBindingNavigator.Name = "OEINVHOBindingNavigator"
        Me.OEINVHOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OEINVHOBindingNavigator.Size = New System.Drawing.Size(879, 25)
        Me.OEINVHOBindingNavigator.TabIndex = 3
        Me.OEINVHOBindingNavigator.Text = "BindingNavigator1"
        '
        'OEINVHOBindingSource
        '
        Me.OEINVHOBindingSource.DataMember = "OEINVHO"
        Me.OEINVHOBindingSource.DataSource = Me.MFGCOMDataSet
        '
        'MFGCOMDataSet
        '
        Me.MFGCOMDataSet.DataSetName = "MFGCOMDataSet"
        Me.MFGCOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.ToolStripButton1.Image = Global.vb_sql.My.Resources.Resources._3643749_edit_pen_pencil_write_writing_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'INVUNIQLabel1
        '
        Me.INVUNIQLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "INVUNIQ", True))
        Me.INVUNIQLabel1.Location = New System.Drawing.Point(329, 158)
        Me.INVUNIQLabel1.Name = "INVUNIQLabel1"
        Me.INVUNIQLabel1.Size = New System.Drawing.Size(100, 23)
        Me.INVUNIQLabel1.TabIndex = 4
        Me.INVUNIQLabel1.Text = "Label1"
        '
        'INVDATELabel1
        '
        Me.INVDATELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "INVDATE", True))
        Me.INVDATELabel1.Location = New System.Drawing.Point(329, 181)
        Me.INVDATELabel1.Name = "INVDATELabel1"
        Me.INVDATELabel1.Size = New System.Drawing.Size(100, 23)
        Me.INVDATELabel1.TabIndex = 6
        Me.INVDATELabel1.Text = "Label1"
        '
        'CUSTOMERLabel1
        '
        Me.CUSTOMERLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "CUSTOMER", True))
        Me.CUSTOMERLabel1.Location = New System.Drawing.Point(329, 204)
        Me.CUSTOMERLabel1.Name = "CUSTOMERLabel1"
        Me.CUSTOMERLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CUSTOMERLabel1.TabIndex = 8
        Me.CUSTOMERLabel1.Text = "Label1"
        '
        'BILNAMELabel1
        '
        Me.BILNAMELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "BILNAME", True))
        Me.BILNAMELabel1.Location = New System.Drawing.Point(329, 227)
        Me.BILNAMELabel1.Name = "BILNAMELabel1"
        Me.BILNAMELabel1.Size = New System.Drawing.Size(100, 23)
        Me.BILNAMELabel1.TabIndex = 10
        Me.BILNAMELabel1.Text = "Label1"
        '
        'DESCLabel1
        '
        Me.DESCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "DESC", True))
        Me.DESCLabel1.Location = New System.Drawing.Point(329, 250)
        Me.DESCLabel1.Name = "DESCLabel1"
        Me.DESCLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DESCLabel1.TabIndex = 12
        Me.DESCLabel1.Text = "Label1"
        '
        'SEND_INVOICELabel1
        '
        Me.SEND_INVOICELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "SEND INVOICE", True))
        Me.SEND_INVOICELabel1.Location = New System.Drawing.Point(329, 273)
        Me.SEND_INVOICELabel1.Name = "SEND_INVOICELabel1"
        Me.SEND_INVOICELabel1.Size = New System.Drawing.Size(100, 23)
        Me.SEND_INVOICELabel1.TabIndex = 14
        Me.SEND_INVOICELabel1.Text = "Label1"
        '
        'OEINVHOTableAdapter
        '
        Me.OEINVHOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.OEINVHO1TableAdapter = Nothing
        Me.TableAdapterManager.OEINVHTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vb_sql.MFGCOMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MFGCOMDataSet1
        '
        Me.MFGCOMDataSet1.DataSetName = "MFGCOMDataSet"
        Me.MFGCOMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MFGCOMDataSet2
        '
        Me.MFGCOMDataSet2.DataSetName = "MFGCOMDataSet"
        Me.MFGCOMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OEINVHOBindingSource1
        '
        Me.OEINVHOBindingSource1.DataMember = "OEINVHO"
        Me.OEINVHOBindingSource1.DataSource = Me.MFGCOMDataSet2
        '
        'OEINVHODataGridView
        '
        Me.OEINVHODataGridView.AllowUserToAddRows = False
        Me.OEINVHODataGridView.AllowUserToDeleteRows = False
        Me.OEINVHODataGridView.AutoGenerateColumns = False
        Me.OEINVHODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OEINVHODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OEINVHODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.INVNUMBER, Me.DataGridViewTextBoxColumn2, Me.SEND})
        Me.OEINVHODataGridView.DataSource = Me.OEINVHOBindingSource
        Me.OEINVHODataGridView.Location = New System.Drawing.Point(-7, 314)
        Me.OEINVHODataGridView.Name = "OEINVHODataGridView"
        Me.OEINVHODataGridView.Size = New System.Drawing.Size(866, 175)
        Me.OEINVHODataGridView.TabIndex = 14
        '
        'SENDLabel
        '
        SENDLabel.AutoSize = True
        SENDLabel.Location = New System.Drawing.Point(285, 105)
        SENDLabel.Name = "SENDLabel"
        SENDLabel.Size = New System.Drawing.Size(40, 13)
        SENDLabel.TabIndex = 14
        SENDLabel.Text = "SEND:"
        '
        'SENDComboBox
        '
        Me.SENDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "SEND", True))
        Me.SENDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OEINVHO1BindingSource, "VALUE", True))
        Me.SENDComboBox.DataSource = Me.OEINVHOBindingSource2
        Me.SENDComboBox.DisplayMember = "SEND"
        Me.SENDComboBox.FormattingEnabled = True
        Me.SENDComboBox.Location = New System.Drawing.Point(331, 102)
        Me.SENDComboBox.Name = "SENDComboBox"
        Me.SENDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SENDComboBox.TabIndex = 15
        Me.SENDComboBox.ValueMember = "SEND INVOICE"
        '
        'OEINVHOBindingSource2
        '
        Me.OEINVHOBindingSource2.DataMember = "OEINVHO"
        Me.OEINVHOBindingSource2.DataSource = Me.MFGCOMDataSet
        '
        'OEINVHO1BindingSource
        '
        Me.OEINVHO1BindingSource.DataMember = "OEINVHO1"
        Me.OEINVHO1BindingSource.DataSource = Me.MFGCOMDataSet
        '
        'OEINVHO1TableAdapter
        '
        Me.OEINVHO1TableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CUSTOMER"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CUSTOMER"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BILNAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BILNAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'INVNUMBER
        '
        Me.INVNUMBER.DataPropertyName = "INVNUMBER"
        Me.INVNUMBER.HeaderText = "INVNUMBER"
        Me.INVNUMBER.Name = "INVNUMBER"
        Me.INVNUMBER.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INVDATE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "INVDATE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SEND
        '
        Me.SEND.DataPropertyName = "SEND"
        Me.SEND.HeaderText = "SEND"
        Me.SEND.Items.AddRange(New Object() {"YES", "NO"})
        Me.SEND.Name = "SEND"
        Me.SEND.ReadOnly = True
        Me.SEND.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SEND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(879, 509)
        Me.Controls.Add(SENDLabel)
        Me.Controls.Add(Me.SENDComboBox)
        Me.Controls.Add(Me.OEINVHODataGridView)
        Me.Controls.Add(INVUNIQLabel)
        Me.Controls.Add(Me.INVUNIQLabel1)
        Me.Controls.Add(INVDATELabel)
        Me.Controls.Add(Me.INVDATELabel1)
        Me.Controls.Add(CUSTOMERLabel)
        Me.Controls.Add(Me.CUSTOMERLabel1)
        Me.Controls.Add(BILNAMELabel)
        Me.Controls.Add(Me.BILNAMELabel1)
        Me.Controls.Add(DESCLabel)
        Me.Controls.Add(Me.DESCLabel1)
        Me.Controls.Add(SEND_INVOICELabel)
        Me.Controls.Add(Me.SEND_INVOICELabel1)
        Me.Controls.Add(Me.OEINVHOBindingNavigator)
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Invoices"
        CType(Me.OEINVHOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OEINVHOBindingNavigator.ResumeLayout(False)
        Me.OEINVHOBindingNavigator.PerformLayout()
        CType(Me.OEINVHOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFGCOMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFGCOMDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFGCOMDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEINVHOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEINVHODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEINVHOBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEINVHO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MFGCOMDataSet As MFGCOMDataSet
    Friend WithEvents OEINVHOBindingSource As BindingSource
    Friend WithEvents OEINVHOTableAdapter As MFGCOMDataSetTableAdapters.OEINVHOTableAdapter
    Friend WithEvents TableAdapterManager As MFGCOMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OEINVHOBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents INVUNIQLabel1 As Label
    Friend WithEvents INVDATELabel1 As Label
    Friend WithEvents CUSTOMERLabel1 As Label
    Friend WithEvents BILNAMELabel1 As Label
    Friend WithEvents DESCLabel1 As Label
    Friend WithEvents SEND_INVOICELabel1 As Label
    Friend WithEvents MFGCOMDataSet1 As MFGCOMDataSet
    Friend WithEvents MFGCOMDataSet2 As MFGCOMDataSet
    Friend WithEvents OEINVHOBindingSource1 As BindingSource
    Friend WithEvents OEINVHODataGridView As DataGridView
    Friend WithEvents SENDComboBox As ComboBox
    Friend WithEvents OEINVHOBindingSource2 As BindingSource
    Friend WithEvents OEINVHO1BindingSource As BindingSource
    Friend WithEvents OEINVHO1TableAdapter As MFGCOMDataSetTableAdapters.OEINVHO1TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents INVNUMBER As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SEND As DataGridViewComboBoxColumn
End Class
