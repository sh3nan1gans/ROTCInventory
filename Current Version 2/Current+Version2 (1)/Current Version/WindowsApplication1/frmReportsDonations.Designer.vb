﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsDonations
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgvRepDonations = New System.Windows.Forms.DataGridView()
        Me.UniformType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRepDonations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(411, 292)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(62, 39)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(26, 292)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(62, 39)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dgvRepDonations
        '
        Me.dgvRepDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepDonations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UniformType, Me.ItemType, Me.Size, Me.Quantity})
        Me.dgvRepDonations.Location = New System.Drawing.Point(26, 12)
        Me.dgvRepDonations.Name = "dgvRepDonations"
        Me.dgvRepDonations.Size = New System.Drawing.Size(447, 260)
        Me.dgvRepDonations.TabIndex = 10
        '
        'UniformType
        '
        Me.UniformType.HeaderText = "Uniform Type"
        Me.UniformType.Name = "UniformType"
        Me.UniformType.ReadOnly = True
        '
        'ItemType
        '
        Me.ItemType.HeaderText = "Item Type"
        Me.ItemType.Name = "ItemType"
        Me.ItemType.ReadOnly = True
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'frmReportsDonations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 356)
        Me.Controls.Add(Me.dgvRepDonations)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "frmReportsDonations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsDonations"
        CType(Me.dgvRepDonations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents dgvRepDonations As System.Windows.Forms.DataGridView
    Friend WithEvents UniformType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Size As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
