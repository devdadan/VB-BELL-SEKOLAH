<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_depan
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_depan))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_jam = New System.Windows.Forms.Label()
        Me.lblhari = New System.Windows.Forms.Label()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_instansi = New System.Windows.Forms.Label()
        Me.gboc_dg = New System.Windows.Forms.GroupBox()
        Me.dg_antrian = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lbl_tgl = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SETTINGDATABASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BunyikanBelManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_versi = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gboc_dg.SuspendLayout()
        CType(Me.dg_antrian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_jam)
        Me.Panel1.Controls.Add(Me.lblhari)
        Me.Panel1.Controls.Add(Me.txt_ket)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.gboc_dg)
        Me.Panel1.Controls.Add(Me.lbl_tgl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 380)
        Me.Panel1.TabIndex = 1
        '
        'lbl_jam
        '
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_jam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_jam.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_jam.Location = New System.Drawing.Point(442, 15)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(260, 75)
        Me.lbl_jam.TabIndex = 34
        Me.lbl_jam.Text = "00:00:00"
        '
        'lblhari
        '
        Me.lblhari.AutoSize = True
        Me.lblhari.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhari.Location = New System.Drawing.Point(386, 88)
        Me.lblhari.Name = "lblhari"
        Me.lblhari.Size = New System.Drawing.Size(0, 45)
        Me.lblhari.TabIndex = 33
        '
        'txt_ket
        '
        Me.txt_ket.BackColor = System.Drawing.SystemColors.InfoText
        Me.txt_ket.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_ket.Location = New System.Drawing.Point(334, 318)
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(477, 31)
        Me.txt_ket.TabIndex = 32
        Me.txt_ket.Text = "BELUM ADA JADWAL"
        Me.txt_ket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_instansi)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 337)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'lbl_instansi
        '
        Me.lbl_instansi.AutoSize = True
        Me.lbl_instansi.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instansi.Location = New System.Drawing.Point(37, 291)
        Me.lbl_instansi.Name = "lbl_instansi"
        Me.lbl_instansi.Size = New System.Drawing.Size(217, 25)
        Me.lbl_instansi.TabIndex = 1
        Me.lbl_instansi.Text = "LABEL NAMA INSTANSI"
        Me.lbl_instansi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboc_dg
        '
        Me.gboc_dg.Controls.Add(Me.dg_antrian)
        Me.gboc_dg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboc_dg.Location = New System.Drawing.Point(334, 136)
        Me.gboc_dg.Name = "gboc_dg"
        Me.gboc_dg.Size = New System.Drawing.Size(477, 176)
        Me.gboc_dg.TabIndex = 2
        Me.gboc_dg.TabStop = False
        Me.gboc_dg.Text = "Antrian Bel"
        '
        'dg_antrian
        '
        Me.dg_antrian.AllowUserToAddRows = False
        Me.dg_antrian.AllowUserToDeleteRows = False
        Me.dg_antrian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_antrian.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_antrian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_antrian.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg_antrian.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dg_antrian.Location = New System.Drawing.Point(11, 18)
        Me.dg_antrian.Name = "dg_antrian"
        Me.dg_antrian.ReadOnly = True
        Me.dg_antrian.RowHeadersVisible = False
        Me.dg_antrian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_antrian.Size = New System.Drawing.Size(458, 152)
        Me.dg_antrian.TabIndex = 0
        '
        'lbl_tgl
        '
        Me.lbl_tgl.AutoSize = True
        Me.lbl_tgl.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tgl.Location = New System.Drawing.Point(493, 88)
        Me.lbl_tgl.Name = "lbl_tgl"
        Me.lbl_tgl.Size = New System.Drawing.Size(266, 45)
        Me.lbl_tgl.TabIndex = 1
        Me.lbl_tgl.Text = "22 Februari 2023"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SETTINGDATABASEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(112, 26)
        '
        'SETTINGDATABASEToolStripMenuItem
        '
        Me.SETTINGDATABASEToolStripMenuItem.Name = "SETTINGDATABASEToolStripMenuItem"
        Me.SETTINGDATABASEToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SETTINGDATABASEToolStripMenuItem.Text = "Setting"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BunyikanBelManualToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(186, 26)
        '
        'BunyikanBelManualToolStripMenuItem
        '
        Me.BunyikanBelManualToolStripMenuItem.Name = "BunyikanBelManualToolStripMenuItem"
        Me.BunyikanBelManualToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.BunyikanBelManualToolStripMenuItem.Text = "Bunyikan bel manual"
        '
        'lbl_versi
        '
        Me.lbl_versi.AutoSize = True
        Me.lbl_versi.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_versi.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_versi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_versi.Location = New System.Drawing.Point(39, 3)
        Me.lbl_versi.Name = "lbl_versi"
        Me.lbl_versi.Size = New System.Drawing.Size(161, 21)
        Me.lbl_versi.TabIndex = 3
        Me.lbl_versi.Text = "Sistem Bell Otomatis"
        Me.lbl_versi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Bell.My.Resources.Resources.alarm
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Bell.My.Resources.Resources.icons8_shutdown_24
        Me.Button1.Location = New System.Drawing.Point(811, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form_depan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(850, 410)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_versi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_depan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Managemen Bell"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gboc_dg.ResumeLayout(False)
        CType(Me.dg_antrian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_tgl As Label
    Friend WithEvents gboc_dg As GroupBox
    Friend WithEvents dg_antrian As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_instansi As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_ket As TextBox
    Friend WithEvents lblhari As Label
    Friend WithEvents lbl_jam As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SETTINGDATABASEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents BunyikanBelManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_versi As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
