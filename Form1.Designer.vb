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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextGPA = New System.Windows.Forms.TextBox()
        Me.TextTinChi = New System.Windows.Forms.TextBox()
        Me.TextTongTinChi = New System.Windows.Forms.TextBox()
        Me.TextTinA = New System.Windows.Forms.TextBox()
        Me.TextTinB = New System.Windows.Forms.TextBox()
        Me.TextTinC = New System.Windows.Forms.TextBox()
        Me.TextTinD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextGPAdukien = New System.Windows.Forms.TextBox()
        Me.TextKetQua = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 110)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(619, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BẢNG TÍNH ĐIỂM GPA VÀ XẾP LOẠI BẰNG TỐT NGHIỆP " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          THEO Đ" &
    "IỂM SỐ DỰ KIẾN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GPA hiện tại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số tín chỉ tích lũy hiện tại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tổng tín chỉ ngành"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Số tín chỉ điểm A (dự kiến)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Số tín chỉ điểm B (dự kiến)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Số tín chỉ điểm C (dự kiến)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Số tín chỉ điểm D (dự kiến)"
        '
        'TextGPA
        '
        Me.TextGPA.Location = New System.Drawing.Point(186, 132)
        Me.TextGPA.Name = "TextGPA"
        Me.TextGPA.Size = New System.Drawing.Size(201, 20)
        Me.TextGPA.TabIndex = 8
        Me.TextGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTinChi
        '
        Me.TextTinChi.Location = New System.Drawing.Point(186, 168)
        Me.TextTinChi.Name = "TextTinChi"
        Me.TextTinChi.Size = New System.Drawing.Size(201, 20)
        Me.TextTinChi.TabIndex = 9
        Me.TextTinChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTongTinChi
        '
        Me.TextTongTinChi.Location = New System.Drawing.Point(186, 205)
        Me.TextTongTinChi.Name = "TextTongTinChi"
        Me.TextTongTinChi.Size = New System.Drawing.Size(201, 20)
        Me.TextTongTinChi.TabIndex = 10
        Me.TextTongTinChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTinA
        '
        Me.TextTinA.Location = New System.Drawing.Point(186, 241)
        Me.TextTinA.Name = "TextTinA"
        Me.TextTinA.Size = New System.Drawing.Size(201, 20)
        Me.TextTinA.TabIndex = 11
        Me.TextTinA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTinB
        '
        Me.TextTinB.Location = New System.Drawing.Point(186, 283)
        Me.TextTinB.Name = "TextTinB"
        Me.TextTinB.Size = New System.Drawing.Size(201, 20)
        Me.TextTinB.TabIndex = 12
        Me.TextTinB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTinC
        '
        Me.TextTinC.Location = New System.Drawing.Point(186, 325)
        Me.TextTinC.Name = "TextTinC"
        Me.TextTinC.Size = New System.Drawing.Size(201, 20)
        Me.TextTinC.TabIndex = 13
        Me.TextTinC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTinD
        '
        Me.TextTinD.Location = New System.Drawing.Point(186, 365)
        Me.TextTinD.Name = "TextTinD"
        Me.TextTinD.Size = New System.Drawing.Size(201, 20)
        Me.TextTinD.TabIndex = 14
        Me.TextTinD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(455, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ĐTB dự kiến"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(455, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Xếp loại Bằng"
        '
        'TextGPAdukien
        '
        Me.TextGPAdukien.ForeColor = System.Drawing.Color.Red
        Me.TextGPAdukien.Location = New System.Drawing.Point(550, 136)
        Me.TextGPAdukien.Name = "TextGPAdukien"
        Me.TextGPAdukien.Size = New System.Drawing.Size(201, 20)
        Me.TextGPAdukien.TabIndex = 17
        Me.TextGPAdukien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextKetQua
        '
        Me.TextKetQua.ForeColor = System.Drawing.Color.Red
        Me.TextKetQua.Location = New System.Drawing.Point(550, 172)
        Me.TextKetQua.Name = "TextKetQua"
        Me.TextKetQua.Size = New System.Drawing.Size(201, 20)
        Me.TextKetQua.TabIndex = 18
        Me.TextKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(458, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 63)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Tính điểm GPA dự kiến"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextKetQua)
        Me.Controls.Add(Me.TextGPAdukien)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextTinD)
        Me.Controls.Add(Me.TextTinC)
        Me.Controls.Add(Me.TextTinB)
        Me.Controls.Add(Me.TextTinA)
        Me.Controls.Add(Me.TextTongTinChi)
        Me.Controls.Add(Me.TextTinChi)
        Me.Controls.Add(Me.TextGPA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Tính GPA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextGPA As TextBox
    Friend WithEvents TextTinChi As TextBox
    Friend WithEvents TextTongTinChi As TextBox
    Friend WithEvents TextTinA As TextBox
    Friend WithEvents TextTinB As TextBox
    Friend WithEvents TextTinC As TextBox
    Friend WithEvents TextTinD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextGPAdukien As TextBox
    Friend WithEvents TextKetQua As TextBox
    Friend WithEvents Button1 As Button
End Class
