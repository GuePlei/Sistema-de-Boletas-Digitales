﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.BtnMini = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.BtnLog = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Btnrepass = New System.Windows.Forms.LinkLabel()
        Me.PBlog = New System.Windows.Forms.PictureBox()
        Me.BtnPasshidden = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBlog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPasshidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.BtnMini)
        Me.PanelTitulo.Controls.Add(Me.BtnClose)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(400, 40)
        Me.PanelTitulo.TabIndex = 0
        '
        'BtnMini
        '
        Me.BtnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMini.Image = Global.SB.My.Resources.Resources.icons8_minimize_window_24px
        Me.BtnMini.Location = New System.Drawing.Point(343, 3)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(24, 24)
        Me.BtnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMini.TabIndex = 2
        Me.BtnMini.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Image = Global.SB.My.Resources.Resources.icons8_close_window_24px
        Me.BtnClose.Location = New System.Drawing.Point(373, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(24, 24)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.TabStop = False
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 665)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(400, 15)
        Me.PanelBottom.TabIndex = 1
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblUser.Location = New System.Drawing.Point(26, 249)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblUser.Size = New System.Drawing.Size(58, 19)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "Usuario"
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.White
        Me.TxtUser.Location = New System.Drawing.Point(30, 271)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(350, 27)
        Me.TxtUser.TabIndex = 0
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.White
        Me.TxtPass.Location = New System.Drawing.Point(30, 325)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(350, 27)
        Me.TxtPass.TabIndex = 1
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblPass.Location = New System.Drawing.Point(26, 303)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(71, 19)
        Me.LblPass.TabIndex = 4
        Me.LblPass.Text = "Password"
        '
        'BtnLog
        '
        Me.BtnLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BtnLog.FlatAppearance.BorderSize = 0
        Me.BtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLog.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLog.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnLog.Location = New System.Drawing.Point(30, 460)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(350, 50)
        Me.BtnLog.TabIndex = 3
        Me.BtnLog.Text = "Login"
        Me.BtnLog.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(400, 680)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 55
        Me.LineShape1.X2 = 339
        Me.LineShape1.Y1 = 587
        Me.LineShape1.Y2 = 587
        '
        'Btnrepass
        '
        Me.Btnrepass.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btnrepass.AutoSize = True
        Me.Btnrepass.Font = New System.Drawing.Font("Roboto Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrepass.LinkColor = System.Drawing.Color.Silver
        Me.Btnrepass.Location = New System.Drawing.Point(146, 619)
        Me.Btnrepass.Name = "Btnrepass"
        Me.Btnrepass.Size = New System.Drawing.Size(126, 17)
        Me.Btnrepass.TabIndex = 4
        Me.Btnrepass.TabStop = True
        Me.Btnrepass.Text = "Olvidó la contraseña?"
        '
        'PBlog
        '
        Me.PBlog.Image = Global.SB.My.Resources.Resources.icons8_teacher_124px
        Me.PBlog.Location = New System.Drawing.Point(139, 82)
        Me.PBlog.Name = "PBlog"
        Me.PBlog.Size = New System.Drawing.Size(124, 124)
        Me.PBlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBlog.TabIndex = 11
        Me.PBlog.TabStop = False
        '
        'BtnPasshidden
        '
        Me.BtnPasshidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPasshidden.Image = Global.SB.My.Resources.Resources.icons8_eye_24px
        Me.BtnPasshidden.Location = New System.Drawing.Point(356, 358)
        Me.BtnPasshidden.Name = "BtnPasshidden"
        Me.BtnPasshidden.Size = New System.Drawing.Size(24, 24)
        Me.BtnPasshidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnPasshidden.TabIndex = 6
        Me.BtnPasshidden.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 680)
        Me.Controls.Add(Me.PBlog)
        Me.Controls.Add(Me.Btnrepass)
        Me.Controls.Add(Me.BtnLog)
        Me.Controls.Add(Me.BtnPasshidden)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.Opacity = 0.95R
        Me.Text = "LoginForm"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.BtnMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBlog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPasshidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents BtnMini As PictureBox
    Friend WithEvents LblUser As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents LblPass As Label
    Friend WithEvents BtnPasshidden As PictureBox
    Friend WithEvents BtnLog As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Btnrepass As LinkLabel
    Friend WithEvents PBlog As PictureBox
End Class
