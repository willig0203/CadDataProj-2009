
' not being used or compiled

Imports System.Math
Imports System.Windows.Forms

Imports rnsCadDataProj.nsCDPUtility
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry
'Imports Autodesk.AutoCAD.PlottingServices
Imports Autodesk.AutoCAD.Geometry.Point3d

Namespace nsUserCtls

    Public Class ucArcUtil

        Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'UserControl overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents gbArcUtil As System.Windows.Forms.GroupBox
        Friend WithEvents btnPckDia As System.Windows.Forms.Button
        Friend WithEvents btnDrawArc As System.Windows.Forms.Button
        Friend WithEvents btnCalcCrdLen As System.Windows.Forms.Button
        Friend WithEvents btnCalDia As System.Windows.Forms.Button
        Friend WithEvents tbDia As System.Windows.Forms.TextBox
        Friend WithEvents btnCalcArcLen As System.Windows.Forms.Button
        Friend WithEvents btnClrArcBxs As System.Windows.Forms.Button
        Friend WithEvents btnCalcCircum As System.Windows.Forms.Button
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents tbArcLen As System.Windows.Forms.TextBox
        Friend WithEvents btnCalcDeg As System.Windows.Forms.Button
        Friend WithEvents tbCircum As System.Windows.Forms.TextBox
        Friend WithEvents tbDeg As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents tbCalcCrdLen As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents lblInvert As System.Windows.Forms.Label
        Friend WithEvents lblNegate As System.Windows.Forms.Label
        Friend WithEvents lblDivideBy As System.Windows.Forms.Label
        Friend WithEvents lblTimes As System.Windows.Forms.Label
        Friend WithEvents lblMinus As System.Windows.Forms.Label
        Friend WithEvents lblPlus As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents btnGo As System.Windows.Forms.Button
        Friend WithEvents txtFraction2 As System.Windows.Forms.TextBox
        Friend WithEvents txtFraction1 As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents btnJig As System.Windows.Forms.Button
        Friend WithEvents btnDragInsertDemo As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.gbArcUtil = New System.Windows.Forms.GroupBox
            Me.btnPckDia = New System.Windows.Forms.Button
            Me.btnDrawArc = New System.Windows.Forms.Button
            Me.btnCalcCrdLen = New System.Windows.Forms.Button
            Me.btnCalDia = New System.Windows.Forms.Button
            Me.tbDia = New System.Windows.Forms.TextBox
            Me.btnCalcArcLen = New System.Windows.Forms.Button
            Me.btnClrArcBxs = New System.Windows.Forms.Button
            Me.btnCalcCircum = New System.Windows.Forms.Button
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.tbArcLen = New System.Windows.Forms.TextBox
            Me.btnCalcDeg = New System.Windows.Forms.Button
            Me.tbCircum = New System.Windows.Forms.TextBox
            Me.tbDeg = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.tbCalcCrdLen = New System.Windows.Forms.TextBox
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.lblInvert = New System.Windows.Forms.Label
            Me.lblNegate = New System.Windows.Forms.Label
            Me.lblDivideBy = New System.Windows.Forms.Label
            Me.lblTimes = New System.Windows.Forms.Label
            Me.lblMinus = New System.Windows.Forms.Label
            Me.lblPlus = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.btnGo = New System.Windows.Forms.Button
            Me.txtFraction2 = New System.Windows.Forms.TextBox
            Me.txtFraction1 = New System.Windows.Forms.TextBox
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.Button2 = New System.Windows.Forms.Button
            Me.TextBox5 = New System.Windows.Forms.TextBox
            Me.TextBox3 = New System.Windows.Forms.TextBox
            Me.TextBox4 = New System.Windows.Forms.TextBox
            Me.TextBox2 = New System.Windows.Forms.TextBox
            Me.Button1 = New System.Windows.Forms.Button
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.TextBox6 = New System.Windows.Forms.TextBox
            Me.btnJig = New System.Windows.Forms.Button
            Me.btnDragInsertDemo = New System.Windows.Forms.Button
            Me.gbArcUtil.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbArcUtil
            '
            Me.gbArcUtil.Controls.Add(Me.btnPckDia)
            Me.gbArcUtil.Controls.Add(Me.btnDrawArc)
            Me.gbArcUtil.Controls.Add(Me.btnCalcCrdLen)
            Me.gbArcUtil.Controls.Add(Me.btnCalDia)
            Me.gbArcUtil.Controls.Add(Me.tbDia)
            Me.gbArcUtil.Controls.Add(Me.btnCalcArcLen)
            Me.gbArcUtil.Controls.Add(Me.btnClrArcBxs)
            Me.gbArcUtil.Controls.Add(Me.btnCalcCircum)
            Me.gbArcUtil.Controls.Add(Me.Label4)
            Me.gbArcUtil.Controls.Add(Me.Label2)
            Me.gbArcUtil.Controls.Add(Me.tbArcLen)
            Me.gbArcUtil.Controls.Add(Me.btnCalcDeg)
            Me.gbArcUtil.Controls.Add(Me.tbCircum)
            Me.gbArcUtil.Controls.Add(Me.tbDeg)
            Me.gbArcUtil.Controls.Add(Me.Label3)
            Me.gbArcUtil.Controls.Add(Me.Label5)
            Me.gbArcUtil.Controls.Add(Me.Label6)
            Me.gbArcUtil.Controls.Add(Me.tbCalcCrdLen)
            Me.gbArcUtil.Location = New System.Drawing.Point(0, 0)
            Me.gbArcUtil.Name = "gbArcUtil"
            Me.gbArcUtil.Size = New System.Drawing.Size(304, 216)
            Me.gbArcUtil.TabIndex = 13
            Me.gbArcUtil.TabStop = False
            Me.gbArcUtil.Text = "Arc Util"
            '
            'btnPckDia
            '
            Me.btnPckDia.Location = New System.Drawing.Point(8, 56)
            Me.btnPckDia.Name = "btnPckDia"
            Me.btnPckDia.Size = New System.Drawing.Size(40, 23)
            Me.btnPckDia.TabIndex = 22
            Me.btnPckDia.Text = "Pick"
            '
            'btnDrawArc
            '
            Me.btnDrawArc.Location = New System.Drawing.Point(216, 160)
            Me.btnDrawArc.Name = "btnDrawArc"
            Me.btnDrawArc.TabIndex = 20
            Me.btnDrawArc.Text = "Draw Arc"
            '
            'btnCalcCrdLen
            '
            Me.btnCalcCrdLen.Location = New System.Drawing.Point(8, 184)
            Me.btnCalcCrdLen.Name = "btnCalcCrdLen"
            Me.btnCalcCrdLen.Size = New System.Drawing.Size(96, 23)
            Me.btnCalcCrdLen.TabIndex = 19
            Me.btnCalcCrdLen.Text = "Calc Crd Len"
            '
            'btnCalDia
            '
            Me.btnCalDia.Location = New System.Drawing.Point(48, 56)
            Me.btnCalDia.Name = "btnCalDia"
            Me.btnCalDia.Size = New System.Drawing.Size(56, 23)
            Me.btnCalDia.TabIndex = 18
            Me.btnCalDia.Text = "Calc Dia"
            '
            'tbDia
            '
            Me.tbDia.Location = New System.Drawing.Point(8, 32)
            Me.tbDia.Name = "tbDia"
            Me.tbDia.Size = New System.Drawing.Size(128, 20)
            Me.tbDia.TabIndex = 8
            Me.tbDia.Text = "tbDia"
            '
            'btnCalcArcLen
            '
            Me.btnCalcArcLen.Location = New System.Drawing.Point(8, 120)
            Me.btnCalcArcLen.Name = "btnCalcArcLen"
            Me.btnCalcArcLen.Size = New System.Drawing.Size(96, 23)
            Me.btnCalcArcLen.TabIndex = 17
            Me.btnCalcArcLen.Text = "Calc Arc Len"
            '
            'btnClrArcBxs
            '
            Me.btnClrArcBxs.Location = New System.Drawing.Point(120, 184)
            Me.btnClrArcBxs.Name = "btnClrArcBxs"
            Me.btnClrArcBxs.TabIndex = 16
            Me.btnClrArcBxs.Text = "Clr Arc Bxs"
            '
            'btnCalcCircum
            '
            Me.btnCalcCircum.Location = New System.Drawing.Point(144, 56)
            Me.btnCalcCircum.Name = "btnCalcCircum"
            Me.btnCalcCircum.Size = New System.Drawing.Size(96, 23)
            Me.btnCalcCircum.TabIndex = 15
            Me.btnCalcCircum.Text = "Calc Circum"
            '
            'Label4
            '
            Me.Label4.Location = New System.Drawing.Point(8, 80)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(100, 16)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "Arc Len in inches"
            '
            'Label2
            '
            Me.Label2.Location = New System.Drawing.Point(8, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "dia in inches"
            '
            'tbArcLen
            '
            Me.tbArcLen.Location = New System.Drawing.Point(8, 96)
            Me.tbArcLen.Name = "tbArcLen"
            Me.tbArcLen.Size = New System.Drawing.Size(128, 20)
            Me.tbArcLen.TabIndex = 7
            Me.tbArcLen.Text = "tbArcLen"
            '
            'btnCalcDeg
            '
            Me.btnCalcDeg.Location = New System.Drawing.Point(144, 120)
            Me.btnCalcDeg.Name = "btnCalcDeg"
            Me.btnCalcDeg.Size = New System.Drawing.Size(96, 23)
            Me.btnCalcDeg.TabIndex = 10
            Me.btnCalcDeg.Text = "Calc Deg"
            '
            'tbCircum
            '
            Me.tbCircum.Location = New System.Drawing.Point(144, 32)
            Me.tbCircum.Name = "tbCircum"
            Me.tbCircum.Size = New System.Drawing.Size(152, 20)
            Me.tbCircum.TabIndex = 9
            Me.tbCircum.Text = "tbCircum"
            '
            'tbDeg
            '
            Me.tbDeg.Location = New System.Drawing.Point(144, 96)
            Me.tbDeg.Name = "tbDeg"
            Me.tbDeg.Size = New System.Drawing.Size(152, 20)
            Me.tbDeg.TabIndex = 11
            Me.tbDeg.Text = "tbDeg"
            '
            'Label3
            '
            Me.Label3.Location = New System.Drawing.Point(144, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "circum in inches"
            '
            'Label5
            '
            Me.Label5.Location = New System.Drawing.Point(144, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(100, 16)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "Degrees"
            '
            'Label6
            '
            Me.Label6.Location = New System.Drawing.Point(8, 144)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(112, 16)
            Me.Label6.TabIndex = 14
            Me.Label6.Text = "Chord Len in inches"
            '
            'tbCalcCrdLen
            '
            Me.tbCalcCrdLen.Location = New System.Drawing.Point(8, 160)
            Me.tbCalcCrdLen.Name = "tbCalcCrdLen"
            Me.tbCalcCrdLen.Size = New System.Drawing.Size(152, 20)
            Me.tbCalcCrdLen.TabIndex = 7
            Me.tbCalcCrdLen.Text = "tbCalcCrdLen"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblInvert)
            Me.GroupBox2.Controls.Add(Me.lblNegate)
            Me.GroupBox2.Controls.Add(Me.lblDivideBy)
            Me.GroupBox2.Controls.Add(Me.lblTimes)
            Me.GroupBox2.Controls.Add(Me.lblMinus)
            Me.GroupBox2.Controls.Add(Me.lblPlus)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.btnGo)
            Me.GroupBox2.Controls.Add(Me.txtFraction2)
            Me.GroupBox2.Controls.Add(Me.txtFraction1)
            Me.GroupBox2.Location = New System.Drawing.Point(0, 216)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(304, 160)
            Me.GroupBox2.TabIndex = 14
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Fractions"
            '
            'lblInvert
            '
            Me.lblInvert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblInvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblInvert.Location = New System.Drawing.Point(134, 108)
            Me.lblInvert.Name = "lblInvert"
            Me.lblInvert.Size = New System.Drawing.Size(162, 16)
            Me.lblInvert.TabIndex = 29
            '
            'lblNegate
            '
            Me.lblNegate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblNegate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNegate.Location = New System.Drawing.Point(134, 132)
            Me.lblNegate.Name = "lblNegate"
            Me.lblNegate.Size = New System.Drawing.Size(162, 16)
            Me.lblNegate.TabIndex = 28
            '
            'lblDivideBy
            '
            Me.lblDivideBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblDivideBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblDivideBy.Location = New System.Drawing.Point(134, 84)
            Me.lblDivideBy.Name = "lblDivideBy"
            Me.lblDivideBy.Size = New System.Drawing.Size(162, 16)
            Me.lblDivideBy.TabIndex = 27
            '
            'lblTimes
            '
            Me.lblTimes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTimes.Location = New System.Drawing.Point(134, 60)
            Me.lblTimes.Name = "lblTimes"
            Me.lblTimes.Size = New System.Drawing.Size(162, 16)
            Me.lblTimes.TabIndex = 26
            '
            'lblMinus
            '
            Me.lblMinus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblMinus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblMinus.Location = New System.Drawing.Point(134, 36)
            Me.lblMinus.Name = "lblMinus"
            Me.lblMinus.Size = New System.Drawing.Size(162, 16)
            Me.lblMinus.TabIndex = 25
            '
            'lblPlus
            '
            Me.lblPlus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPlus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblPlus.Location = New System.Drawing.Point(134, 12)
            Me.lblPlus.Name = "lblPlus"
            Me.lblPlus.Size = New System.Drawing.Size(162, 16)
            Me.lblPlus.TabIndex = 24
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(110, 108)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(24, 16)
            Me.Label7.TabIndex = 23
            Me.Label7.Text = "1/x"
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(110, 132)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(24, 16)
            Me.Label8.TabIndex = 22
            Me.Label8.Text = "-x"
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(110, 84)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(24, 16)
            Me.Label9.TabIndex = 21
            Me.Label9.Text = "/"
            '
            'Label10
            '
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(110, 60)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(24, 16)
            Me.Label10.TabIndex = 20
            Me.Label10.Text = "*"
            '
            'Label11
            '
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(110, 36)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(24, 16)
            Me.Label11.TabIndex = 19
            Me.Label11.Text = "-"
            '
            'Label12
            '
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(110, 12)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(24, 16)
            Me.Label12.TabIndex = 18
            Me.Label12.Text = "+"
            '
            'btnGo
            '
            Me.btnGo.Location = New System.Drawing.Point(32, 80)
            Me.btnGo.Name = "btnGo"
            Me.btnGo.Size = New System.Drawing.Size(40, 24)
            Me.btnGo.TabIndex = 17
            Me.btnGo.Text = "Go"
            '
            'txtFraction2
            '
            Me.txtFraction2.Location = New System.Drawing.Point(24, 48)
            Me.txtFraction2.Name = "txtFraction2"
            Me.txtFraction2.Size = New System.Drawing.Size(64, 20)
            Me.txtFraction2.TabIndex = 16
            Me.txtFraction2.Text = "21/10"
            '
            'txtFraction1
            '
            Me.txtFraction1.Location = New System.Drawing.Point(24, 16)
            Me.txtFraction1.Name = "txtFraction1"
            Me.txtFraction1.Size = New System.Drawing.Size(64, 20)
            Me.txtFraction1.TabIndex = 15
            Me.txtFraction1.Text = "4/15"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Button2)
            Me.GroupBox3.Controls.Add(Me.TextBox5)
            Me.GroupBox3.Controls.Add(Me.TextBox3)
            Me.GroupBox3.Controls.Add(Me.TextBox4)
            Me.GroupBox3.Controls.Add(Me.TextBox2)
            Me.GroupBox3.Controls.Add(Me.Button1)
            Me.GroupBox3.Controls.Add(Me.TextBox1)
            Me.GroupBox3.Controls.Add(Me.TextBox6)
            Me.GroupBox3.Location = New System.Drawing.Point(304, 8)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(200, 240)
            Me.GroupBox3.TabIndex = 23
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Ft-Inches"
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(112, 176)
            Me.Button2.Name = "Button2"
            Me.Button2.TabIndex = 20
            Me.Button2.Text = "Button2"
            '
            'TextBox5
            '
            Me.TextBox5.Location = New System.Drawing.Point(40, 144)
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.TabIndex = 19
            Me.TextBox5.Text = "TextBox5"
            '
            'TextBox3
            '
            Me.TextBox3.Location = New System.Drawing.Point(40, 88)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.TabIndex = 17
            Me.TextBox3.Text = "TextBox3"
            '
            'TextBox4
            '
            Me.TextBox4.Location = New System.Drawing.Point(40, 112)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.TabIndex = 18
            Me.TextBox4.Text = "TextBox4"
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(40, 64)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.TabIndex = 16
            Me.TextBox2.Text = "TextBox2"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(112, 24)
            Me.Button1.Name = "Button1"
            Me.Button1.TabIndex = 15
            Me.Button1.Text = "Button1"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(8, 24)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.TabIndex = 14
            Me.TextBox1.Text = "TextBox1"
            '
            'TextBox6
            '
            Me.TextBox6.Location = New System.Drawing.Point(40, 208)
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.TabIndex = 21
            Me.TextBox6.Text = "TextBox6"
            '
            'btnJig
            '
            Me.btnJig.Location = New System.Drawing.Point(360, 296)
            Me.btnJig.Name = "btnJig"
            Me.btnJig.Size = New System.Drawing.Size(72, 23)
            Me.btnJig.TabIndex = 24
            Me.btnJig.Text = "jig"
            '
            'btnDragInsertDemo
            '
            Me.btnDragInsertDemo.Location = New System.Drawing.Point(360, 272)
            Me.btnDragInsertDemo.Name = "btnDragInsertDemo"
            Me.btnDragInsertDemo.Size = New System.Drawing.Size(72, 23)
            Me.btnDragInsertDemo.TabIndex = 25
            Me.btnDragInsertDemo.Text = "DragInsertDemo"
            '
            'ucArcUtil
            '
            Me.Controls.Add(Me.btnDragInsertDemo)
            Me.Controls.Add(Me.btnJig)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.gbArcUtil)
            Me.Name = "ucArcUtil"
            Me.Size = New System.Drawing.Size(504, 376)
            Me.gbArcUtil.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region



        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Dim MyFt() As String : Dim MyIn() As String : Dim MyFr() As String

            MyFt = System.Text.RegularExpressions.Regex.Split(TextBox1.Text, "'")

            MyIn = System.Text.RegularExpressions.Regex.Split(MyFt(1), "-")

            MyFr = System.Text.RegularExpressions.Regex.Split(MyIn(1), "\""")

            TextBox2.Text = MyFt(0)
            TextBox3.Text = MyIn(0)
            TextBox4.Text = MyFr(0)

            MyFr = System.Text.RegularExpressions.Regex.Split(MyFr(0), "/")

            TextBox5.Text = (MyFt(0) * 12) + MyIn(0) + (MyFr(0) / MyFr(1))

        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            TextBox6.Text = Dec2Frac(TextBox5.Text)
        End Sub


        Private Sub btnDragInsertDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDragInsertDemo.Click
            ''Me.Hide()
            'Dim doit As CaddZone.Class1
            'doit.DragInsertDemo()
            ''Me.Show()

        End Sub

        Private Sub btnJig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJig.Click

            'Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            'Dim frm As Form = Me.FindForm()
            'frm.Hide()
            ''Dim arcPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            ''Dim arcPntRes As PromptPointResult = ed.GetPoint(arcPnt)

            'Dim AnglePromt As PromptAngleOptions = New PromptAngleOptions("Pick Angle...")
            ''AnglePromt.UseBasePoint = True
            ''AnglePromt.BasePoint = arcPntRes.Value
            'Dim Angle As PromptDoubleResult = ed.GetAngle(AnglePromt)
            '' MessageBox.Show(Angle.Value)
            'If Angle.Status <> PromptStatus.OK Then frm.Show() : Return
            ''If arcPntRes.Status <> PromptStatus.OK Then Me.Show() : Return
            'Dim Origin = New Point3d(0, 0, 0)
            ''arcPntRes.Value()
            'Dim arc As Arc = New Arc(Origin, tbDia.Text / 2, 0, (tbDeg.Text * PI / 180))
            ''Dim arc As Arc = New Arc(arcPntRes.Value, tbDia.Text / 2, Angle.Value, Angle.Value + (tbDeg.Text * PI / 180))

            ''transformation problems......
            'Dim moveVec As New Vector3d(0, 0, 1)

            'Dim m As Matrix3d = Matrix3d.Rotation(Angle.Value, moveVec, Origin)
            ''For Each ent As Entity In objectsToRotate
            'arc.TransformBy(m)
            ''Next ent

            ''Dim arc As Arc = New Arc(New Point3d(0, 0, 0), tbDia.Text / 2, 0, tbDeg.Text * PI / 180)
            'Dim cj As New circJig.JigExample

            'Dim res As PromptPointResult = cj.StartJig(arc)
            'If (res.Status <> PromptStatus.OK) Then

            '    Dim bt As BlockTable : Dim btr As BlockTableRecord
            '    Dim db As Database = HostApplicationServices.WorkingDatabase
            '    Dim trans As Transaction = db.TransactionManager.StartTransaction()
            '    Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            '    Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()

            '    Try : bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead)
            '        Dim cSpace As String = modUtility.CurSpace
            '        Select Case cSpace
            '            Case "*Model_Space"
            '                btr = trans.GetObject(bt(btr.ModelSpace), OpenMode.ForWrite)
            '            Case "*MODEL_SPACE"
            '                btr = trans.GetObject(bt(btr.ModelSpace), OpenMode.ForWrite)
            '            Case "*Paper_Space"
            '                btr = trans.GetObject(bt(btr.PaperSpace), OpenMode.ForWrite)
            '            Case "*PAPER_SPACE"
            '                btr = trans.GetObject(bt(btr.PaperSpace), OpenMode.ForWrite)
            '        End Select
            '        Try : btr.AppendEntity(arc)
            '            trans.AddNewlyCreatedDBObject(arc, True)
            '        Finally
            '            arc.Dispose()
            '        End Try
            '        trans.Commit()
            '    Finally
            '        docLock.Dispose() : trans.Dispose()
            '    End Try
            'End If
        End Sub

        Private Sub btnDrawArc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawArc.Click

            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            Dim arcPnt As PromptPointOptions = New PromptPointOptions("Select Insertion Point...")
            Dim arcPntRes As PromptPointResult = ed.GetPoint(arcPnt)

            Dim AnglePromt As PromptAngleOptions = New PromptAngleOptions("Pick Angle...")
            AnglePromt.UseBasePoint = True
            AnglePromt.BasePoint = arcPntRes.Value
            Dim Angle As PromptDoubleResult = ed.GetAngle(AnglePromt)
            ' MessageBox.Show(Angle.Value)
            If arcPntRes.Status <> PromptStatus.OK Then frm.Show() : Return

            Dim arc As Arc = New Arc(arcPntRes.Value, tbDia.Text / 2, Angle.Value, Angle.Value + (tbDeg.Text * PI / 180))

            Dim bt As BlockTable : Dim btr As BlockTableRecord
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()

            Try : bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead)
                Dim cSpace As String = modUtility.CurSpace
                Select Case cSpace
                    Case "*Model_Space"
                        btr = trans.GetObject(bt(btr.ModelSpace), OpenMode.ForWrite)
                    Case "*MODEL_SPACE"
                        btr = trans.GetObject(bt(btr.ModelSpace), OpenMode.ForWrite)
                    Case "*Paper_Space"
                        btr = trans.GetObject(bt(btr.PaperSpace), OpenMode.ForWrite)
                    Case "*PAPER_SPACE"
                        btr = trans.GetObject(bt(btr.PaperSpace), OpenMode.ForWrite)
                End Select
                Try : btr.AppendEntity(arc)
                    trans.AddNewlyCreatedDBObject(arc, True)
                Finally
                    arc.Dispose()
                End Try
                trans.Commit()
            Finally
                docLock.Dispose() : trans.Dispose()
            End Try
        End Sub

        Private Sub btnClrArcBxs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClrArcBxs.Click
            tbDia.Text = "tbDia"
            tbCircum.Text = "tbCircum"
            tbDeg.Text = "tbDeg"
            tbArcLen.Text = "tbArcLen"
            tbCalcCrdLen.Text = "tbCalcCrdLen"
        End Sub


        Private Sub btnCalcCircum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcCircum.Click
            If tbDia.Text <> "tbDia" Then
                tbCircum.Text = (tbDia.Text * PI).ToString
                ' Me.Text = DistanceToString(tbCircum.Text, DistanceUnitFormat.Architectural.Fractional, 64)
            End If
        End Sub

        Private Sub btnCalDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalDia.Click
            If tbCircum.Text <> "tbCircum" Then
                tbDia.Text = (tbCircum.Text / PI).ToString
            End If
        End Sub

        Private Sub btnPckDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPckDia.Click
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
            Dim frm As Form = Me.FindForm()
            frm.Hide()
            Dim trans As Transaction = db.TransactionManager.StartTransaction()
            Dim DocCol As DocumentCollection = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager
            Dim docLock As DocumentLock = DocCol.MdiActiveDocument.LockDocument()
            Try
                Dim prEnt As PromptNestedEntityOptions = New PromptNestedEntityOptions("Select the Circle ...")
                Dim prEntRes As PromptEntityResult = ed.GetNestedEntity(prEnt)
                If prEntRes.Status <> PromptStatus.OK Then
                    frm.Show()
                    Return
                End If
                Dim ent As Entity = trans.GetObject(prEntRes.ObjectId, OpenMode.ForRead)
                If TypeOf ent Is Circle Then
                    Dim att As Circle = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    tbDia.Text = (att.Radius.ToString) * 2
                    trans.Commit() 'ed.UpdateScreen()
                End If
                If TypeOf ent Is Arc Then
                    Dim att As Arc = trans.GetObject(prEntRes.ObjectId, OpenMode.ForWrite)
                    tbDia.Text = (att.Radius.ToString) * 2
                    trans.Commit() 'ed.UpdateScreen()
                End If
            Finally
                docLock.Dispose() : trans.Dispose() : Me.Show()
            End Try

        End Sub

        Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
            lblPlus.Text = ""
            lblMinus.Text = ""
            lblTimes.Text = ""
            lblDivideBy.Text = ""
            lblInvert.Text = ""
            lblNegate.Text = ""

            On Error GoTo CalculationError
            Dim frac1 As New Fraction(txtFraction1.Text)
            Dim frac2 As New Fraction(txtFraction2.Text)
            Dim result As Fraction

            lblPlus.Text = frac1.Plus(frac2).ToString()
            lblMinus.Text = frac1.Minus(frac2).ToString()
            lblTimes.Text = frac1.Times(frac2).ToString()
            lblDivideBy.Text = frac1.DivideBy(frac2).ToString()
            lblInvert.Text = frac1.Invert().ToString()
            lblNegate.Text = frac1.Negate().ToString()
            Exit Sub

CalculationError:
            MessageBox.Show("Error performing calculations." & vbCrLf & _
                Err.Description, _
                "Calculation Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Resume Next
        End Sub


        Private Sub btnCalcCrdLen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcCrdLen.Click
            If tbArcLen.Text <> "tbArcLen" And tbDia.Text <> "tbdia" Then
                Dim rads As Double = tbArcLen.Text / (tbDia.Text / 2)
                tbCalcCrdLen.Text = tbDia.Text * (Sin(rads / 2))
            End If
        End Sub

        Private Sub btnCalcArcLen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcArcLen.Click
            If tbDeg.Text <> "tbDeg" And tbCircum.Text <> "tbCircum" Then
                tbArcLen.Text = (tbDeg.Text / 360 * tbCircum.Text).ToString
            End If
            'To determine ARC LENGTH when CHORD LENGTH and RADIUS are known	
            If tbCalcCrdLen.Text <> "tbCalcCrdLen" And tbDia.Text <> "tbdia" Then
                Dim rads As Double = 2 * Asin((tbCalcCrdLen.Text) / (2 * (tbDia.Text / 2)))
                tbArcLen.Text = (tbDia.Text / 2) * rads
            End If
        End Sub

        Private Sub btnCalcDeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcDeg.Click
            If tbDeg.Text = "tbDeg" Then
                If tbArcLen.Text <> "tbArcLen" And tbCircum.Text <> "tbCircum" Then
                    tbDeg.Text = (tbArcLen.Text / tbCircum.Text * 360).ToString
                End If
            End If
            If tbCalcCrdLen.Text <> "tbCalcCrdLen" And tbDia.Text <> "tbdia" Then
                Dim rads As Double = 2 * Asin((tbCalcCrdLen.Text) / (2 * (tbDia.Text / 2)))
                tbDeg.Text = rads * (180 / PI)
            End If
        End Sub
    End Class

End Namespace