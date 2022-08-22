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
        Dim INVUNIQLabel1 As System.Windows.Forms.Label
        Dim SEND_INVOICELabel As System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OEINVHODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OEINVHOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MFGCOMDataSet = New vb_sql.MFGCOMDataSet()
        Me.OEINVHOTableAdapter = New vb_sql.MFGCOMDataSetTableAdapters.OEINVHOTableAdapter()
        Me.TableAdapterManager = New vb_sql.MFGCOMDataSetTableAdapters.TableAdapterManager()
        Me.INVUNIQLabel2 = New System.Windows.Forms.Label()
        Me.SEND_INVOICELabel1 = New System.Windows.Forms.Label()
        INVUNIQLabel1 = New System.Windows.Forms.Label()
        SEND_INVOICELabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.OEINVHODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OEINVHOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MFGCOMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 445)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(423, 445)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 445)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 29)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(555, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item Title"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(90, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(438, 21)
        Me.TextBox1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 50)
        Me.Panel1.TabIndex = 0
        '
        'OEINVHODataGridView
        '
        Me.OEINVHODataGridView.AutoGenerateColumns = False
        Me.OEINVHODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OEINVHODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.OEINVHODataGridView.DataSource = Me.OEINVHOBindingSource
        Me.OEINVHODataGridView.Location = New System.Drawing.Point(0, 57)
        Me.OEINVHODataGridView.Name = "OEINVHODataGridView"
        Me.OEINVHODataGridView.Size = New System.Drawing.Size(661, 373)
        Me.OEINVHODataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "INVUNIQ"
        Me.DataGridViewTextBoxColumn1.HeaderText = "INVUNIQ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INVDATE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "INVDATE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SEND INVOICE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SEND INVOICE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'INVUNIQLabel1
        '
        INVUNIQLabel1.AutoSize = True
        INVUNIQLabel1.Location = New System.Drawing.Point(689, 86)
        INVUNIQLabel1.Name = "INVUNIQLabel1"
        INVUNIQLabel1.Size = New System.Drawing.Size(59, 15)
        INVUNIQLabel1.TabIndex = 7
        INVUNIQLabel1.Text = "INVUNIQ:"
        '
        'INVUNIQLabel2
        '
        Me.INVUNIQLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "INVUNIQ", True))
        Me.INVUNIQLabel2.Location = New System.Drawing.Point(789, 86)
        Me.INVUNIQLabel2.Name = "INVUNIQLabel2"
        Me.INVUNIQLabel2.Size = New System.Drawing.Size(100, 23)
        Me.INVUNIQLabel2.TabIndex = 8
        Me.INVUNIQLabel2.Text = "Label2"
        '
        'SEND_INVOICELabel
        '
        SEND_INVOICELabel.AutoSize = True
        SEND_INVOICELabel.Location = New System.Drawing.Point(689, 130)
        SEND_INVOICELabel.Name = "SEND_INVOICELabel"
        SEND_INVOICELabel.Size = New System.Drawing.Size(94, 15)
        SEND_INVOICELabel.TabIndex = 8
        SEND_INVOICELabel.Text = "SEND INVOICE:"
        '
        'SEND_INVOICELabel1
        '
        Me.SEND_INVOICELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OEINVHOBindingSource, "SEND INVOICE", True))
        Me.SEND_INVOICELabel1.Location = New System.Drawing.Point(789, 130)
        Me.SEND_INVOICELabel1.Name = "SEND_INVOICELabel1"
        Me.SEND_INVOICELabel1.Size = New System.Drawing.Size(100, 23)
        Me.SEND_INVOICELabel1.TabIndex = 9
        Me.SEND_INVOICELabel1.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(942, 494)
        Me.Controls.Add(SEND_INVOICELabel)
        Me.Controls.Add(Me.SEND_INVOICELabel1)
        Me.Controls.Add(INVUNIQLabel1)
        Me.Controls.Add(Me.INVUNIQLabel2)
        Me.Controls.Add(Me.OEINVHODataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Send"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OEINVHODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OEINVHOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MFGCOMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MFGCOMDataSet As MFGCOMDataSet
    Friend WithEvents OEINVHOBindingSource As BindingSource
    Friend WithEvents OEINVHOTableAdapter As MFGCOMDataSetTableAdapters.OEINVHOTableAdapter
    Friend WithEvents TableAdapterManager As MFGCOMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OEINVHODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents INVUNIQLabel2 As Label
    Friend WithEvents SEND_INVOICELabel1 As Label
End Class
