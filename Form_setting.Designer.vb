<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_setting
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_setting))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_jadwal1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.ck_hari = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cb_audio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_jam = New System.Windows.Forms.TextBox()
        Me.txt_keter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_menit = New System.Windows.Forms.TextBox()
        Me.txt_detik = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_hari = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_namasekolah = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_db = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_host = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbl_path = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rb_restore = New System.Windows.Forms.RadioButton()
        Me.rb_backup = New System.Windows.Forms.RadioButton()
        Me.txt_pathsumber = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_namasekolah = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_backrest = New System.Windows.Forms.Button()
        Me.btn_pathsumber = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_jadwal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 466)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_jadwal1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 386)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "JADWAL BEL"
        '
        'dg_jadwal1
        '
        Me.dg_jadwal1.AllowUserToAddRows = False
        Me.dg_jadwal1.AllowUserToDeleteRows = False
        Me.dg_jadwal1.AllowUserToResizeColumns = False
        Me.dg_jadwal1.AllowUserToResizeRows = False
        Me.dg_jadwal1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_jadwal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_jadwal1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col1, Me.col2, Me.col3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_jadwal1.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg_jadwal1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dg_jadwal1.Location = New System.Drawing.Point(11, 16)
        Me.dg_jadwal1.Name = "dg_jadwal1"
        Me.dg_jadwal1.ReadOnly = True
        Me.dg_jadwal1.RowHeadersVisible = False
        Me.dg_jadwal1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_jadwal1.Size = New System.Drawing.Size(406, 364)
        Me.dg_jadwal1.TabIndex = 0
        '
        'col1
        '
        Me.col1.HeaderText = "HARI"
        Me.col1.Name = "col1"
        Me.col1.ReadOnly = True
        '
        'col2
        '
        Me.col2.HeaderText = "JAM"
        Me.col2.Name = "col2"
        Me.col2.ReadOnly = True
        Me.col2.Width = 80
        '
        'col3
        '
        Me.col3.HeaderText = "KETERANGAN"
        Me.col3.Name = "col3"
        Me.col3.ReadOnly = True
        Me.col3.Width = 350
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TabPage2.Controls.Add(Me.lbl_info)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.btn_simpan)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_info.Location = New System.Drawing.Point(11, 397)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(237, 24)
        Me.lbl_info.TabIndex = 18
        Me.lbl_info.Text = "Nb :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data yang bisa diedit hanya JAM,KETERANGAN dan AUDIO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_id)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.ck_hari)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.cb_audio)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_jam)
        Me.GroupBox4.Controls.Add(Me.txt_keter)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_menit)
        Me.GroupBox4.Controls.Add(Me.txt_detik)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(394, 324)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(380, 294)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 18
        Me.lbl_id.Visible = False
        '
        'ck_hari
        '
        Me.ck_hari.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ck_hari.FormattingEnabled = True
        Me.ck_hari.Items.AddRange(New Object() {"SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU", "MINGGU"})
        Me.ck_hari.Location = New System.Drawing.Point(91, 21)
        Me.ck_hari.Name = "ck_hari"
        Me.ck_hari.Size = New System.Drawing.Size(120, 106)
        Me.ck_hari.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pilihan Hari :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(217, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Pilih Semua"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cb_audio
        '
        Me.cb_audio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_audio.FormattingEnabled = True
        Me.cb_audio.Location = New System.Drawing.Point(93, 212)
        Me.cb_audio.Name = "cb_audio"
        Me.cb_audio.Size = New System.Drawing.Size(236, 21)
        Me.cb_audio.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "JAM :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "AUDIO :"
        '
        'txt_jam
        '
        Me.txt_jam.Location = New System.Drawing.Point(93, 157)
        Me.txt_jam.Name = "txt_jam"
        Me.txt_jam.Size = New System.Drawing.Size(31, 22)
        Me.txt_jam.TabIndex = 6
        Me.txt_jam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_keter
        '
        Me.txt_keter.BackColor = System.Drawing.SystemColors.Window
        Me.txt_keter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_keter.Location = New System.Drawing.Point(93, 185)
        Me.txt_keter.Name = "txt_keter"
        Me.txt_keter.Size = New System.Drawing.Size(296, 22)
        Me.txt_keter.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "KETERANGAN :"
        '
        'txt_menit
        '
        Me.txt_menit.Location = New System.Drawing.Point(136, 157)
        Me.txt_menit.Name = "txt_menit"
        Me.txt_menit.Size = New System.Drawing.Size(31, 22)
        Me.txt_menit.TabIndex = 7
        Me.txt_menit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_detik
        '
        Me.txt_detik.Location = New System.Drawing.Point(179, 157)
        Me.txt_detik.Name = "txt_detik"
        Me.txt_detik.ReadOnly = True
        Me.txt_detik.Size = New System.Drawing.Size(31, 22)
        Me.txt_detik.TabIndex = 10
        Me.txt_detik.Text = "00"
        Me.txt_detik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = ":"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_hari)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 57)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hari"
        '
        'cb_hari
        '
        Me.cb_hari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_hari.FormattingEnabled = True
        Me.cb_hari.Items.AddRange(New Object() {"SEMUA HARI", "SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU", "MINGGU"})
        Me.cb_hari.Location = New System.Drawing.Point(11, 20)
        Me.cb_hari.Name = "cb_hari"
        Me.cb_hari.Size = New System.Drawing.Size(369, 21)
        Me.cb_hari.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.Button7)
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(430, 437)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pb_logo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 186)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logo Sekolah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CARI FILE :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(293, 22)
        Me.TextBox2.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.txt_namasekolah)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 132)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(411, 59)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Nama Sekolah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "NAMA SEKOLAH :"
        '
        'txt_namasekolah
        '
        Me.txt_namasekolah.Location = New System.Drawing.Point(113, 21)
        Me.txt_namasekolah.Name = "txt_namasekolah"
        Me.txt_namasekolah.Size = New System.Drawing.Size(293, 22)
        Me.txt_namasekolah.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txt_db)
        Me.GroupBox5.Controls.Add(Me.txt_pass)
        Me.GroupBox5.Controls.Add(Me.txt_user)
        Me.GroupBox5.Controls.Add(Me.txt_host)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(413, 124)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Database"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "DATABASE :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "PASSWORD :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "USER :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "SERVER :"
        '
        'txt_db
        '
        Me.txt_db.Location = New System.Drawing.Point(114, 90)
        Me.txt_db.Name = "txt_db"
        Me.txt_db.Size = New System.Drawing.Size(293, 22)
        Me.txt_db.TabIndex = 3
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(114, 64)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(293, 22)
        Me.txt_pass.TabIndex = 2
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(114, 38)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(293, 22)
        Me.txt_user.TabIndex = 1
        '
        'txt_host
        '
        Me.txt_host.Location = New System.Drawing.Point(114, 12)
        Me.txt_host.Name = "txt_host"
        Me.txt_host.Size = New System.Drawing.Size(293, 22)
        Me.txt_host.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TabPage4.Controls.Add(Me.lbl_path)
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.txt_pathsumber)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.btn_pathsumber)
        Me.TabPage4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(430, 437)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Location = New System.Drawing.Point(14, 119)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(30, 13)
        Me.lbl_path.TabIndex = 6
        Me.lbl_path.Text = "Path"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rb_restore)
        Me.GroupBox8.Controls.Add(Me.rb_backup)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(156, 82)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Jenis"
        '
        'rb_restore
        '
        Me.rb_restore.AutoSize = True
        Me.rb_restore.Location = New System.Drawing.Point(39, 45)
        Me.rb_restore.Name = "rb_restore"
        Me.rb_restore.Size = New System.Drawing.Size(64, 17)
        Me.rb_restore.TabIndex = 4
        Me.rb_restore.TabStop = True
        Me.rb_restore.Text = "Restore"
        Me.rb_restore.UseVisualStyleBackColor = True
        '
        'rb_backup
        '
        Me.rb_backup.AutoSize = True
        Me.rb_backup.Location = New System.Drawing.Point(39, 22)
        Me.rb_backup.Name = "rb_backup"
        Me.rb_backup.Size = New System.Drawing.Size(62, 17)
        Me.rb_backup.TabIndex = 3
        Me.rb_backup.TabStop = True
        Me.rb_backup.Text = "Backup"
        Me.rb_backup.UseVisualStyleBackColor = True
        '
        'txt_pathsumber
        '
        Me.txt_pathsumber.Location = New System.Drawing.Point(17, 135)
        Me.txt_pathsumber.Name = "txt_pathsumber"
        Me.txt_pathsumber.ReadOnly = True
        Me.txt_pathsumber.Size = New System.Drawing.Size(244, 22)
        Me.txt_pathsumber.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btn_backrest)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 330)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(414, 92)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Backup / Restore"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbl_namasekolah
        '
        Me.lbl_namasekolah.AutoSize = True
        Me.lbl_namasekolah.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namasekolah.Location = New System.Drawing.Point(144, 472)
        Me.lbl_namasekolah.Name = "lbl_namasekolah"
        Me.lbl_namasekolah.Size = New System.Drawing.Size(149, 17)
        Me.lbl_namasekolah.TabIndex = 1
        Me.lbl_namasekolah.Text = "LABEL NAMA SEKOLAH"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem1.Text = "Edit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripMenuItem2.Text = "Hapus"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Bell.My.Resources.Resources.icons8_remove_26
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(300, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "HAPUS SEMUA"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bell.My.Resources.Resources.icons8_available_updates_26
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(166, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "REFRESH"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.Bell.My.Resources.Resources.icons8_pause_button_26
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(160, 239)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(64, 34)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "STOP"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Bell.My.Resources.Resources.icons8_play_button_circled_26
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(93, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 34)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "PLAY"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.Control
        Me.btn_simpan.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Image = Global.Bell.My.Resources.Resources._3floppy_unmount
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(304, 397)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(118, 37)
        Me.btn_simpan.TabIndex = 16
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'pb_logo
        '
        Me.pb_logo.ErrorImage = Global.Bell.My.Resources.Resources.bg1
        Me.pb_logo.Location = New System.Drawing.Point(115, 48)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(123, 132)
        Me.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_logo.TabIndex = 10
        Me.pb_logo.TabStop = False
        '
        'Button7
        '
        Me.Button7.Image = Global.Bell.My.Resources.Resources.document_save_as
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(9, 389)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(412, 45)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "SIMPAN PERUBAHAN"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_backrest
        '
        Me.btn_backrest.BackColor = System.Drawing.SystemColors.Control
        Me.btn_backrest.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backrest.Image = Global.Bell.My.Resources.Resources.database_save1
        Me.btn_backrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_backrest.Location = New System.Drawing.Point(20, 21)
        Me.btn_backrest.Name = "btn_backrest"
        Me.btn_backrest.Size = New System.Drawing.Size(373, 47)
        Me.btn_backrest.TabIndex = 7
        Me.btn_backrest.Text = "PROSES"
        Me.btn_backrest.UseVisualStyleBackColor = False
        '
        'btn_pathsumber
        '
        Me.btn_pathsumber.Image = Global.Bell.My.Resources.Resources.human_folder_public
        Me.btn_pathsumber.Location = New System.Drawing.Point(264, 133)
        Me.btn_pathsumber.Name = "btn_pathsumber"
        Me.btn_pathsumber.Size = New System.Drawing.Size(51, 26)
        Me.btn_pathsumber.TabIndex = 2
        Me.btn_pathsumber.UseVisualStyleBackColor = True
        '
        'Form_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(438, 494)
        Me.Controls.Add(Me.lbl_namasekolah)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_jadwal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg_jadwal1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col3 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cb_hari As ComboBox
    Friend WithEvents ck_hari As CheckedListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_jam As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_detik As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_menit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_keter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_audio As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txt_db As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_host As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_namasekolah As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents lbl_namasekolah As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btn_pathsumber As Button
    Friend WithEvents txt_pathsumber As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rb_restore As RadioButton
    Friend WithEvents rb_backup As RadioButton
    Friend WithEvents lbl_path As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_info As Label
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents btn_backrest As Button
End Class
