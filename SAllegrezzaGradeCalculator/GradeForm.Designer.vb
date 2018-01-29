<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnSaveGrades = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.pnlNames = New System.Windows.Forms.Panel()
        Me.txtStudent4Name = New System.Windows.Forms.TextBox()
        Me.txtStudent2Name = New System.Windows.Forms.TextBox()
        Me.txtStudent3Name = New System.Windows.Forms.TextBox()
        Me.txtStudent0Name = New System.Windows.Forms.TextBox()
        Me.txtStudent1Name = New System.Windows.Forms.TextBox()
        Me.pnlGrades = New System.Windows.Forms.Panel()
        Me.txtStdnt4gr3 = New System.Windows.Forms.TextBox()
        Me.txtStdnt3gr1 = New System.Windows.Forms.TextBox()
        Me.txtStdnt4gr2 = New System.Windows.Forms.TextBox()
        Me.txtStdnt0gr0 = New System.Windows.Forms.TextBox()
        Me.txtStdnt4gr1 = New System.Windows.Forms.TextBox()
        Me.txtStdnt0gr1 = New System.Windows.Forms.TextBox()
        Me.txtStdnt4gr0 = New System.Windows.Forms.TextBox()
        Me.txtStdnt0gr2 = New System.Windows.Forms.TextBox()
        Me.txtStdnt3gr3 = New System.Windows.Forms.TextBox()
        Me.txtStdnt0gr3 = New System.Windows.Forms.TextBox()
        Me.txtStdnt3gr2 = New System.Windows.Forms.TextBox()
        Me.txtStdnt1gr0 = New System.Windows.Forms.TextBox()
        Me.txtStdnt1gr1 = New System.Windows.Forms.TextBox()
        Me.txtStdnt3gr0 = New System.Windows.Forms.TextBox()
        Me.txtStdnt1gr2 = New System.Windows.Forms.TextBox()
        Me.txtStdnt2gr3 = New System.Windows.Forms.TextBox()
        Me.txtStdnt1gr3 = New System.Windows.Forms.TextBox()
        Me.txtStdnt2gr2 = New System.Windows.Forms.TextBox()
        Me.txtStdnt2gr0 = New System.Windows.Forms.TextBox()
        Me.txtStdnt2gr1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlNames.SuspendLayout()
        Me.pnlGrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(462, 448)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 54)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnResetForm
        '
        Me.btnResetForm.AutoSize = True
        Me.btnResetForm.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetForm.Location = New System.Drawing.Point(258, 448)
        Me.btnResetForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(167, 54)
        Me.btnResetForm.TabIndex = 26
        Me.btnResetForm.Text = "Reset Grades"
        Me.btnResetForm.UseVisualStyleBackColor = True
        '
        'btnSaveGrades
        '
        Me.btnSaveGrades.AutoSize = True
        Me.btnSaveGrades.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSaveGrades.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGrades.Location = New System.Drawing.Point(75, 448)
        Me.btnSaveGrades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveGrades.Name = "btnSaveGrades"
        Me.btnSaveGrades.Size = New System.Drawing.Size(159, 54)
        Me.btnSaveGrades.TabIndex = 25
        Me.btnSaveGrades.Text = "Save Grades"
        Me.btnSaveGrades.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.DarkRed
        Me.lblWarning.Location = New System.Drawing.Point(132, 390)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(368, 28)
        Me.lblWarning.TabIndex = 69
        Me.lblWarning.Text = "Please enter something into each box"
        '
        'pnlNames
        '
        Me.pnlNames.Controls.Add(Me.txtStudent4Name)
        Me.pnlNames.Controls.Add(Me.txtStudent2Name)
        Me.pnlNames.Controls.Add(Me.txtStudent3Name)
        Me.pnlNames.Controls.Add(Me.txtStudent0Name)
        Me.pnlNames.Controls.Add(Me.txtStudent1Name)
        Me.pnlNames.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNames.Location = New System.Drawing.Point(30, 54)
        Me.pnlNames.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlNames.Name = "pnlNames"
        Me.pnlNames.Size = New System.Drawing.Size(217, 325)
        Me.pnlNames.TabIndex = 29
        '
        'txtStudent4Name
        '
        Me.txtStudent4Name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStudent4Name.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent4Name.Location = New System.Drawing.Point(15, 31)
        Me.txtStudent4Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudent4Name.Name = "txtStudent4Name"
        Me.txtStudent4Name.Size = New System.Drawing.Size(189, 35)
        Me.txtStudent4Name.TabIndex = 34
        '
        'txtStudent2Name
        '
        Me.txtStudent2Name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStudent2Name.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent2Name.Location = New System.Drawing.Point(15, 86)
        Me.txtStudent2Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudent2Name.Name = "txtStudent2Name"
        Me.txtStudent2Name.Size = New System.Drawing.Size(189, 35)
        Me.txtStudent2Name.TabIndex = 32
        '
        'txtStudent3Name
        '
        Me.txtStudent3Name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStudent3Name.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent3Name.Location = New System.Drawing.Point(15, 140)
        Me.txtStudent3Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudent3Name.Name = "txtStudent3Name"
        Me.txtStudent3Name.Size = New System.Drawing.Size(189, 35)
        Me.txtStudent3Name.TabIndex = 33
        '
        'txtStudent0Name
        '
        Me.txtStudent0Name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStudent0Name.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent0Name.Location = New System.Drawing.Point(15, 194)
        Me.txtStudent0Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudent0Name.Name = "txtStudent0Name"
        Me.txtStudent0Name.Size = New System.Drawing.Size(189, 35)
        Me.txtStudent0Name.TabIndex = 30
        '
        'txtStudent1Name
        '
        Me.txtStudent1Name.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtStudent1Name.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent1Name.Location = New System.Drawing.Point(15, 248)
        Me.txtStudent1Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudent1Name.Name = "txtStudent1Name"
        Me.txtStudent1Name.Size = New System.Drawing.Size(189, 35)
        Me.txtStudent1Name.TabIndex = 31
        '
        'pnlGrades
        '
        Me.pnlGrades.Controls.Add(Me.txtStdnt4gr3)
        Me.pnlGrades.Controls.Add(Me.txtStdnt3gr1)
        Me.pnlGrades.Controls.Add(Me.txtStdnt4gr2)
        Me.pnlGrades.Controls.Add(Me.txtStdnt0gr0)
        Me.pnlGrades.Controls.Add(Me.txtStdnt4gr1)
        Me.pnlGrades.Controls.Add(Me.txtStdnt0gr1)
        Me.pnlGrades.Controls.Add(Me.txtStdnt4gr0)
        Me.pnlGrades.Controls.Add(Me.txtStdnt0gr2)
        Me.pnlGrades.Controls.Add(Me.txtStdnt3gr3)
        Me.pnlGrades.Controls.Add(Me.txtStdnt0gr3)
        Me.pnlGrades.Controls.Add(Me.txtStdnt3gr2)
        Me.pnlGrades.Controls.Add(Me.txtStdnt1gr0)
        Me.pnlGrades.Controls.Add(Me.txtStdnt1gr1)
        Me.pnlGrades.Controls.Add(Me.txtStdnt3gr0)
        Me.pnlGrades.Controls.Add(Me.txtStdnt1gr2)
        Me.pnlGrades.Controls.Add(Me.txtStdnt2gr3)
        Me.pnlGrades.Controls.Add(Me.txtStdnt1gr3)
        Me.pnlGrades.Controls.Add(Me.txtStdnt2gr2)
        Me.pnlGrades.Controls.Add(Me.txtStdnt2gr0)
        Me.pnlGrades.Controls.Add(Me.txtStdnt2gr1)
        Me.pnlGrades.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlGrades.Location = New System.Drawing.Point(283, 54)
        Me.pnlGrades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlGrades.Name = "pnlGrades"
        Me.pnlGrades.Size = New System.Drawing.Size(340, 325)
        Me.pnlGrades.TabIndex = 70
        '
        'txtStdnt4gr3
        '
        Me.txtStdnt4gr3.BackColor = System.Drawing.Color.White
        Me.txtStdnt4gr3.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt4gr3.Location = New System.Drawing.Point(260, 248)
        Me.txtStdnt4gr3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt4gr3.Name = "txtStdnt4gr3"
        Me.txtStdnt4gr3.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt4gr3.TabIndex = 88
        '
        'txtStdnt3gr1
        '
        Me.txtStdnt3gr1.BackColor = System.Drawing.Color.White
        Me.txtStdnt3gr1.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt3gr1.Location = New System.Drawing.Point(98, 194)
        Me.txtStdnt3gr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt3gr1.Name = "txtStdnt3gr1"
        Me.txtStdnt3gr1.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt3gr1.TabIndex = 82
        '
        'txtStdnt4gr2
        '
        Me.txtStdnt4gr2.BackColor = System.Drawing.Color.White
        Me.txtStdnt4gr2.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt4gr2.Location = New System.Drawing.Point(179, 248)
        Me.txtStdnt4gr2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt4gr2.Name = "txtStdnt4gr2"
        Me.txtStdnt4gr2.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt4gr2.TabIndex = 87
        '
        'txtStdnt0gr0
        '
        Me.txtStdnt0gr0.BackColor = System.Drawing.Color.White
        Me.txtStdnt0gr0.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt0gr0.Location = New System.Drawing.Point(16, 31)
        Me.txtStdnt0gr0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt0gr0.Name = "txtStdnt0gr0"
        Me.txtStdnt0gr0.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt0gr0.TabIndex = 69
        '
        'txtStdnt4gr1
        '
        Me.txtStdnt4gr1.BackColor = System.Drawing.Color.White
        Me.txtStdnt4gr1.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt4gr1.Location = New System.Drawing.Point(98, 248)
        Me.txtStdnt4gr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt4gr1.Name = "txtStdnt4gr1"
        Me.txtStdnt4gr1.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt4gr1.TabIndex = 86
        '
        'txtStdnt0gr1
        '
        Me.txtStdnt0gr1.BackColor = System.Drawing.Color.White
        Me.txtStdnt0gr1.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt0gr1.Location = New System.Drawing.Point(98, 31)
        Me.txtStdnt0gr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt0gr1.Name = "txtStdnt0gr1"
        Me.txtStdnt0gr1.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt0gr1.TabIndex = 70
        '
        'txtStdnt4gr0
        '
        Me.txtStdnt4gr0.BackColor = System.Drawing.Color.White
        Me.txtStdnt4gr0.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt4gr0.Location = New System.Drawing.Point(16, 248)
        Me.txtStdnt4gr0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt4gr0.Name = "txtStdnt4gr0"
        Me.txtStdnt4gr0.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt4gr0.TabIndex = 85
        '
        'txtStdnt0gr2
        '
        Me.txtStdnt0gr2.BackColor = System.Drawing.Color.White
        Me.txtStdnt0gr2.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt0gr2.Location = New System.Drawing.Point(179, 31)
        Me.txtStdnt0gr2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt0gr2.Name = "txtStdnt0gr2"
        Me.txtStdnt0gr2.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt0gr2.TabIndex = 71
        '
        'txtStdnt3gr3
        '
        Me.txtStdnt3gr3.BackColor = System.Drawing.Color.White
        Me.txtStdnt3gr3.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt3gr3.Location = New System.Drawing.Point(260, 194)
        Me.txtStdnt3gr3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt3gr3.Name = "txtStdnt3gr3"
        Me.txtStdnt3gr3.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt3gr3.TabIndex = 84
        '
        'txtStdnt0gr3
        '
        Me.txtStdnt0gr3.BackColor = System.Drawing.Color.White
        Me.txtStdnt0gr3.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt0gr3.Location = New System.Drawing.Point(260, 31)
        Me.txtStdnt0gr3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt0gr3.Name = "txtStdnt0gr3"
        Me.txtStdnt0gr3.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt0gr3.TabIndex = 72
        '
        'txtStdnt3gr2
        '
        Me.txtStdnt3gr2.BackColor = System.Drawing.Color.White
        Me.txtStdnt3gr2.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt3gr2.Location = New System.Drawing.Point(179, 194)
        Me.txtStdnt3gr2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt3gr2.Name = "txtStdnt3gr2"
        Me.txtStdnt3gr2.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt3gr2.TabIndex = 83
        '
        'txtStdnt1gr0
        '
        Me.txtStdnt1gr0.BackColor = System.Drawing.Color.White
        Me.txtStdnt1gr0.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt1gr0.Location = New System.Drawing.Point(16, 86)
        Me.txtStdnt1gr0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt1gr0.Name = "txtStdnt1gr0"
        Me.txtStdnt1gr0.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt1gr0.TabIndex = 73
        '
        'txtStdnt1gr1
        '
        Me.txtStdnt1gr1.BackColor = System.Drawing.Color.White
        Me.txtStdnt1gr1.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt1gr1.Location = New System.Drawing.Point(98, 86)
        Me.txtStdnt1gr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt1gr1.Name = "txtStdnt1gr1"
        Me.txtStdnt1gr1.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt1gr1.TabIndex = 74
        '
        'txtStdnt3gr0
        '
        Me.txtStdnt3gr0.BackColor = System.Drawing.Color.White
        Me.txtStdnt3gr0.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt3gr0.Location = New System.Drawing.Point(16, 194)
        Me.txtStdnt3gr0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt3gr0.Name = "txtStdnt3gr0"
        Me.txtStdnt3gr0.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt3gr0.TabIndex = 81
        '
        'txtStdnt1gr2
        '
        Me.txtStdnt1gr2.BackColor = System.Drawing.Color.White
        Me.txtStdnt1gr2.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt1gr2.Location = New System.Drawing.Point(179, 86)
        Me.txtStdnt1gr2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt1gr2.Name = "txtStdnt1gr2"
        Me.txtStdnt1gr2.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt1gr2.TabIndex = 75
        '
        'txtStdnt2gr3
        '
        Me.txtStdnt2gr3.BackColor = System.Drawing.Color.White
        Me.txtStdnt2gr3.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt2gr3.Location = New System.Drawing.Point(260, 140)
        Me.txtStdnt2gr3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt2gr3.Name = "txtStdnt2gr3"
        Me.txtStdnt2gr3.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt2gr3.TabIndex = 80
        '
        'txtStdnt1gr3
        '
        Me.txtStdnt1gr3.BackColor = System.Drawing.Color.White
        Me.txtStdnt1gr3.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt1gr3.Location = New System.Drawing.Point(260, 86)
        Me.txtStdnt1gr3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt1gr3.Name = "txtStdnt1gr3"
        Me.txtStdnt1gr3.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt1gr3.TabIndex = 76
        '
        'txtStdnt2gr2
        '
        Me.txtStdnt2gr2.BackColor = System.Drawing.Color.White
        Me.txtStdnt2gr2.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt2gr2.Location = New System.Drawing.Point(179, 140)
        Me.txtStdnt2gr2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt2gr2.Name = "txtStdnt2gr2"
        Me.txtStdnt2gr2.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt2gr2.TabIndex = 79
        '
        'txtStdnt2gr0
        '
        Me.txtStdnt2gr0.BackColor = System.Drawing.Color.White
        Me.txtStdnt2gr0.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt2gr0.Location = New System.Drawing.Point(16, 140)
        Me.txtStdnt2gr0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt2gr0.Name = "txtStdnt2gr0"
        Me.txtStdnt2gr0.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt2gr0.TabIndex = 77
        '
        'txtStdnt2gr1
        '
        Me.txtStdnt2gr1.BackColor = System.Drawing.Color.White
        Me.txtStdnt2gr1.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStdnt2gr1.Location = New System.Drawing.Point(98, 140)
        Me.txtStdnt2gr1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStdnt2gr1.Name = "txtStdnt2gr1"
        Me.txtStdnt2gr1.Size = New System.Drawing.Size(65, 35)
        Me.txtStdnt2gr1.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 28)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Enter the student's name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("IBM Plex Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 28)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Enter the student's grade"
        '
        'GradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(670, 574)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlGrades)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.pnlNames)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnSaveGrades)
        Me.Font = New System.Drawing.Font("IBM Plex Sans", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GradeForm"
        Me.pnlNames.ResumeLayout(False)
        Me.pnlNames.PerformLayout()
        Me.pnlGrades.ResumeLayout(False)
        Me.pnlGrades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnResetForm As Button
    Friend WithEvents btnSaveGrades As Button
    Friend WithEvents lblWarning As Label
    Friend WithEvents pnlNames As Panel
    Friend WithEvents txtStudent4Name As TextBox
    Friend WithEvents txtStudent2Name As TextBox
    Friend WithEvents txtStudent3Name As TextBox
    Friend WithEvents txtStudent0Name As TextBox
    Friend WithEvents txtStudent1Name As TextBox
    Friend WithEvents pnlGrades As Panel
    Friend WithEvents txtStdnt4gr3 As TextBox
    Friend WithEvents txtStdnt3gr1 As TextBox
    Friend WithEvents txtStdnt4gr2 As TextBox
    Friend WithEvents txtStdnt0gr0 As TextBox
    Friend WithEvents txtStdnt4gr1 As TextBox
    Friend WithEvents txtStdnt0gr1 As TextBox
    Friend WithEvents txtStdnt4gr0 As TextBox
    Friend WithEvents txtStdnt0gr2 As TextBox
    Friend WithEvents txtStdnt3gr3 As TextBox
    Friend WithEvents txtStdnt0gr3 As TextBox
    Friend WithEvents txtStdnt3gr2 As TextBox
    Friend WithEvents txtStdnt1gr0 As TextBox
    Friend WithEvents txtStdnt1gr1 As TextBox
    Friend WithEvents txtStdnt3gr0 As TextBox
    Friend WithEvents txtStdnt1gr2 As TextBox
    Friend WithEvents txtStdnt2gr3 As TextBox
    Friend WithEvents txtStdnt1gr3 As TextBox
    Friend WithEvents txtStdnt2gr2 As TextBox
    Friend WithEvents txtStdnt2gr0 As TextBox
    Friend WithEvents txtStdnt2gr1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
