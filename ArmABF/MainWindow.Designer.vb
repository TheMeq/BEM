<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AABF_MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AABF_MainWindow))
        Me.ts_MainWindow = New System.Windows.Forms.ToolStrip()
        Me.tsl_File = New System.Windows.Forms.ToolStripLabel()
        Me.tsc_FileSelector = New System.Windows.Forms.ToolStripComboBox()
        Me.tss_3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ss_MainWindow = New System.Windows.Forms.StatusStrip()
        Me.tssl_CurrentlyLoaded = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_FileLoaded = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sb_FE = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sc_MainWindow = New System.Windows.Forms.SplitContainer()
        Me.lb_Lines = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.dgv_SelectedRow = New System.Windows.Forms.DataGridView()
        Me.sr_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sr_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_FileLoaded = New System.Windows.Forms.DataGridView()
        Me.lb_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_Exceptions = New System.Windows.Forms.ListBox()
        Me.ts_Exceptions = New System.Windows.Forms.ToolStrip()
        Me.update_timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.tsb_AddEntry = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Load = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeutscheKaioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpanishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DutchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.РусскийMentaiCosmicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.한국어MinimalResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.簡體中文KondouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.繁體中文KondouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_MainWindow.SuspendLayout()
        Me.ss_MainWindow.SuspendLayout()
        CType(Me.sc_MainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sc_MainWindow.Panel1.SuspendLayout()
        Me.sc_MainWindow.Panel2.SuspendLayout()
        Me.sc_MainWindow.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_SelectedRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_FileLoaded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_Exceptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts_MainWindow
        '
        Me.ts_MainWindow.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_MainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_File, Me.tsc_FileSelector, Me.tsb_Load, Me.tsb_Save, Me.ToolStripButton2, Me.tss_3, Me.ToolStripButton10, Me.ToolStripSeparator2, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ts_MainWindow.Location = New System.Drawing.Point(0, 0)
        Me.ts_MainWindow.Name = "ts_MainWindow"
        Me.ts_MainWindow.Size = New System.Drawing.Size(1163, 25)
        Me.ts_MainWindow.TabIndex = 3
        Me.ts_MainWindow.Text = "ToolStrip1"
        '
        'tsl_File
        '
        Me.tsl_File.Name = "tsl_File"
        Me.tsl_File.Size = New System.Drawing.Size(71, 22)
        Me.tsl_File.Text = "Choose File:"
        '
        'tsc_FileSelector
        '
        Me.tsc_FileSelector.AutoSize = False
        Me.tsc_FileSelector.DropDownHeight = 200
        Me.tsc_FileSelector.DropDownWidth = 300
        Me.tsc_FileSelector.IntegralHeight = False
        Me.tsc_FileSelector.Name = "tsc_FileSelector"
        Me.tsc_FileSelector.Size = New System.Drawing.Size(300, 23)
        Me.tsc_FileSelector.Text = "No File Detected"
        '
        'tss_3
        '
        Me.tss_3.Name = "tss_3"
        Me.tss_3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ss_MainWindow
        '
        Me.ss_MainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl_CurrentlyLoaded, Me.tssl_FileLoaded, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.sb_FE})
        Me.ss_MainWindow.Location = New System.Drawing.Point(0, 598)
        Me.ss_MainWindow.Name = "ss_MainWindow"
        Me.ss_MainWindow.Size = New System.Drawing.Size(1163, 22)
        Me.ss_MainWindow.TabIndex = 4
        Me.ss_MainWindow.Text = "StatusStrip1"
        '
        'tssl_CurrentlyLoaded
        '
        Me.tssl_CurrentlyLoaded.Name = "tssl_CurrentlyLoaded"
        Me.tssl_CurrentlyLoaded.Size = New System.Drawing.Size(104, 17)
        Me.tssl_CurrentlyLoaded.Text = "Currently Loaded: "
        '
        'tssl_FileLoaded
        '
        Me.tssl_FileLoaded.Name = "tssl_FileLoaded"
        Me.tssl_FileLoaded.Size = New System.Drawing.Size(139, 17)
        Me.tssl_FileLoaded.Text = "None. Load a file to start."
        Me.tssl_FileLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'sb_FE
        '
        Me.sb_FE.Name = "sb_FE"
        Me.sb_FE.Size = New System.Drawing.Size(0, 17)
        '
        'sc_MainWindow
        '
        Me.sc_MainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc_MainWindow.Location = New System.Drawing.Point(0, 25)
        Me.sc_MainWindow.Name = "sc_MainWindow"
        '
        'sc_MainWindow.Panel1
        '
        Me.sc_MainWindow.Panel1.Controls.Add(Me.lb_Lines)
        Me.sc_MainWindow.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'sc_MainWindow.Panel2
        '
        Me.sc_MainWindow.Panel2.Controls.Add(Me.dgv_SelectedRow)
        Me.sc_MainWindow.Panel2.Controls.Add(Me.dgv_FileLoaded)
        Me.sc_MainWindow.Panel2.Controls.Add(Me.lb_Exceptions)
        Me.sc_MainWindow.Panel2.Controls.Add(Me.ts_Exceptions)
        Me.sc_MainWindow.Size = New System.Drawing.Size(1163, 573)
        Me.sc_MainWindow.SplitterDistance = 454
        Me.sc_MainWindow.TabIndex = 7
        '
        'lb_Lines
        '
        Me.lb_Lines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_Lines.FormattingEnabled = True
        Me.lb_Lines.HorizontalScrollbar = True
        Me.lb_Lines.IntegralHeight = False
        Me.lb_Lines.Location = New System.Drawing.Point(0, 25)
        Me.lb_Lines.Name = "lb_Lines"
        Me.lb_Lines.Size = New System.Drawing.Size(454, 548)
        Me.lb_Lines.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(454, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'dgv_SelectedRow
        '
        Me.dgv_SelectedRow.AllowUserToAddRows = False
        Me.dgv_SelectedRow.AllowUserToDeleteRows = False
        Me.dgv_SelectedRow.AllowUserToResizeRows = False
        Me.dgv_SelectedRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SelectedRow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sr_0, Me.sr_1})
        Me.dgv_SelectedRow.Location = New System.Drawing.Point(6, 293)
        Me.dgv_SelectedRow.Name = "dgv_SelectedRow"
        Me.dgv_SelectedRow.Size = New System.Drawing.Size(699, 262)
        Me.dgv_SelectedRow.TabIndex = 2
        Me.dgv_SelectedRow.Visible = False
        '
        'sr_0
        '
        Me.sr_0.HeaderText = "ExceptionType"
        Me.sr_0.Name = "sr_0"
        '
        'sr_1
        '
        Me.sr_1.HeaderText = "Parameter"
        Me.sr_1.Name = "sr_1"
        Me.sr_1.Width = 1000
        '
        'dgv_FileLoaded
        '
        Me.dgv_FileLoaded.AllowUserToAddRows = False
        Me.dgv_FileLoaded.AllowUserToDeleteRows = False
        Me.dgv_FileLoaded.AllowUserToResizeRows = False
        Me.dgv_FileLoaded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_FileLoaded.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lb_0, Me.lb_3, Me.lb_1, Me.lb_2})
        Me.dgv_FileLoaded.Location = New System.Drawing.Point(6, 95)
        Me.dgv_FileLoaded.Name = "dgv_FileLoaded"
        Me.dgv_FileLoaded.Size = New System.Drawing.Size(699, 192)
        Me.dgv_FileLoaded.TabIndex = 1
        Me.dgv_FileLoaded.Visible = False
        '
        'lb_0
        '
        Me.lb_0.HeaderText = "LogType"
        Me.lb_0.Name = "lb_0"
        '
        'lb_3
        '
        Me.lb_3.HeaderText = "Line"
        Me.lb_3.Name = "lb_3"
        '
        'lb_1
        '
        Me.lb_1.HeaderText = "Keyword"
        Me.lb_1.Name = "lb_1"
        '
        'lb_2
        '
        Me.lb_2.HeaderText = "Parameters"
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Width = 1000
        '
        'lb_Exceptions
        '
        Me.lb_Exceptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_Exceptions.FormattingEnabled = True
        Me.lb_Exceptions.HorizontalScrollbar = True
        Me.lb_Exceptions.IntegralHeight = False
        Me.lb_Exceptions.Location = New System.Drawing.Point(0, 25)
        Me.lb_Exceptions.Name = "lb_Exceptions"
        Me.lb_Exceptions.Size = New System.Drawing.Size(705, 548)
        Me.lb_Exceptions.TabIndex = 1
        '
        'ts_Exceptions
        '
        Me.ts_Exceptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_Exceptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_AddEntry, Me.ToolStripButton1, Me.ToolStripButton8})
        Me.ts_Exceptions.Location = New System.Drawing.Point(0, 0)
        Me.ts_Exceptions.Name = "ts_Exceptions"
        Me.ts_Exceptions.Size = New System.Drawing.Size(705, 25)
        Me.ts_Exceptions.TabIndex = 0
        Me.ts_Exceptions.Text = "ToolStrip2"
        '
        'update_timer
        '
        Me.update_timer.Interval = 300000
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.BEM.My.Resources.Resources.textfield_add
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripButton5.Text = "Add Keyword"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.BEM.My.Resources.Resources.textfield_delete
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripButton6.Text = "Remove Keyword"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.BEM.My.Resources.Resources.textfield_rename
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButton7.Text = "Edit Keyword"
        '
        'tsb_AddEntry
        '
        Me.tsb_AddEntry.Image = Global.BEM.My.Resources.Resources.textfield_add
        Me.tsb_AddEntry.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_AddEntry.Name = "tsb_AddEntry"
        Me.tsb_AddEntry.Size = New System.Drawing.Size(78, 22)
        Me.tsb_AddEntry.Text = "Add Filter"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.BEM.My.Resources.Resources.textfield_delete
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripButton1.Text = "Remove Filter"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Image = Global.BEM.My.Resources.Resources.textfield_rename
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton8.Text = "Edit Filter"
        '
        'tsb_Load
        '
        Me.tsb_Load.Image = Global.BEM.My.Resources.Resources.script_go
        Me.tsb_Load.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Load.Name = "tsb_Load"
        Me.tsb_Load.Size = New System.Drawing.Size(74, 22)
        Me.tsb_Load.Text = "Load File"
        '
        'tsb_Save
        '
        Me.tsb_Save.Image = Global.BEM.My.Resources.Resources.disk
        Me.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Save.Name = "tsb_Save"
        Me.tsb_Save.Size = New System.Drawing.Size(72, 22)
        Me.tsb_Save.Text = "Save File"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.BEM.My.Resources.Resources.package_green
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripButton2.Text = "Upload Scripts"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Image = Global.BEM.My.Resources.Resources.page_find
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripButton10.Text = "Import from Logs"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripDropDownButton1.Text = "Options"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.money_pound
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.package_green
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.asterisk_yellow
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.AutoSize = False
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.FranToolStripMenuItem, Me.DeutscheKaioniToolStripMenuItem, Me.SpanishToolStripMenuItem, Me.DutchToolStripMenuItem, Me.ToolStripMenuItem2, Me.РусскийMentaiCosmicToolStripMenuItem, Me.한국어MinimalResultsToolStripMenuItem, Me.簡體中文KondouToolStripMenuItem, Me.繁體中文KondouToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = Global.BEM.My.Resources.Resources.gb
        Me.ToolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.ToolTipText = "Language"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.gb
        Me.EnglishToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EnglishToolStripMenuItem.Text = "English (TheMeq)"
        '
        'FranToolStripMenuItem
        '
        Me.FranToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.fr
        Me.FranToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FranToolStripMenuItem.Name = "FranToolStripMenuItem"
        Me.FranToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.FranToolStripMenuItem.Text = "Français (Ilyasio)"
        '
        'DeutscheKaioniToolStripMenuItem
        '
        Me.DeutscheKaioniToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.de
        Me.DeutscheKaioniToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeutscheKaioniToolStripMenuItem.Name = "DeutscheKaioniToolStripMenuItem"
        Me.DeutscheKaioniToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DeutscheKaioniToolStripMenuItem.Text = "Deutsche (Kaionacho)"
        '
        'SpanishToolStripMenuItem
        '
        Me.SpanishToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.es
        Me.SpanishToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SpanishToolStripMenuItem.Name = "SpanishToolStripMenuItem"
        Me.SpanishToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SpanishToolStripMenuItem.Text = "Español (shinmai_rookie)"
        '
        'DutchToolStripMenuItem
        '
        Me.DutchToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.nl
        Me.DutchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DutchToolStripMenuItem.Name = "DutchToolStripMenuItem"
        Me.DutchToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DutchToolStripMenuItem.Text = "Nederlands (Crado)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.BEM.My.Resources.Resources.fi
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(207, 22)
        Me.ToolStripMenuItem2.Text = "Suomi (Lefafel)"
        '
        'РусскийMentaiCosmicToolStripMenuItem
        '
        Me.РусскийMentaiCosmicToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.ru
        Me.РусскийMentaiCosmicToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.РусскийMentaiCosmicToolStripMenuItem.Name = "РусскийMentaiCosmicToolStripMenuItem"
        Me.РусскийMentaiCosmicToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.РусскийMentaiCosmicToolStripMenuItem.Text = "Русский (MentaiCosmic)"
        '
        '한국어MinimalResultsToolStripMenuItem
        '
        Me.한국어MinimalResultsToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.kr
        Me.한국어MinimalResultsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.한국어MinimalResultsToolStripMenuItem.Name = "한국어MinimalResultsToolStripMenuItem"
        Me.한국어MinimalResultsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.한국어MinimalResultsToolStripMenuItem.Text = "한국어 (MinimalResults)"
        '
        '簡體中文KondouToolStripMenuItem
        '
        Me.簡體中文KondouToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.cn
        Me.簡體中文KondouToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.簡體中文KondouToolStripMenuItem.Name = "簡體中文KondouToolStripMenuItem"
        Me.簡體中文KondouToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.簡體中文KondouToolStripMenuItem.Text = "简体中文 (Kondou)"
        '
        '繁體中文KondouToolStripMenuItem
        '
        Me.繁體中文KondouToolStripMenuItem.Image = Global.BEM.My.Resources.Resources.cn
        Me.繁體中文KondouToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.繁體中文KondouToolStripMenuItem.Name = "繁體中文KondouToolStripMenuItem"
        Me.繁體中文KondouToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.繁體中文KondouToolStripMenuItem.Text = "繁體中文 (Kondou)"
        '
        'frm_AABF_MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 620)
        Me.Controls.Add(Me.sc_MainWindow)
        Me.Controls.Add(Me.ss_MainWindow)
        Me.Controls.Add(Me.ts_MainWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frm_AABF_MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BEM - BattlEye Filter Manager - by TheMeq"
        Me.ts_MainWindow.ResumeLayout(False)
        Me.ts_MainWindow.PerformLayout()
        Me.ss_MainWindow.ResumeLayout(False)
        Me.ss_MainWindow.PerformLayout()
        Me.sc_MainWindow.Panel1.ResumeLayout(False)
        Me.sc_MainWindow.Panel1.PerformLayout()
        Me.sc_MainWindow.Panel2.ResumeLayout(False)
        Me.sc_MainWindow.Panel2.PerformLayout()
        CType(Me.sc_MainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sc_MainWindow.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_SelectedRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_FileLoaded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_Exceptions.ResumeLayout(False)
        Me.ts_Exceptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ts_MainWindow As System.Windows.Forms.ToolStrip
    Friend WithEvents tsl_File As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsc_FileSelector As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsb_Load As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss_3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents ss_MainWindow As System.Windows.Forms.StatusStrip
    Friend WithEvents tssl_CurrentlyLoaded As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssl_FileLoaded As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sc_MainWindow As System.Windows.Forms.SplitContainer
    Friend WithEvents lb_Lines As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgv_SelectedRow As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_FileLoaded As System.Windows.Forms.DataGridView
    Friend WithEvents lb_Exceptions As System.Windows.Forms.ListBox
    Friend WithEvents ts_Exceptions As System.Windows.Forms.ToolStrip
    Friend WithEvents tsb_AddEntry As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents sr_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sr_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sb_FE As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents update_timer As Timer
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SpanishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 한국어MinimalResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РусскийMentaiCosmicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 簡體中文KondouToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 繁體中文KondouToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeutscheKaioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DutchToolStripMenuItem As ToolStripMenuItem
End Class
