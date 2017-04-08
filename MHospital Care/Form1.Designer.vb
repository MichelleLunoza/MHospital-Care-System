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
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim PatientLastNameLabel As System.Windows.Forms.Label
        Dim PatientFirstNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim SymptomsLabel As System.Windows.Forms.Label
        Dim AdmissionDateLabel As System.Windows.Forms.Label
        Dim AssignedDoctorLabel As System.Windows.Forms.Label
        Dim RoomNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PICTUREPANEL = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_s_InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._HospitalData___CopyDataSet = New WindowsApplication1._HospitalData___CopyDataSet()
        Me.PatientLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PatientFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.SymptomsTextBox = New System.Windows.Forms.TextBox()
        Me.AdmissionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AssignedDoctorTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_s_InformationTableAdapter = New WindowsApplication1._HospitalData___CopyDataSetTableAdapters.Patient_s_InformationTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._HospitalData___CopyDataSetTableAdapters.TableAdapterManager()
        Me.Patient_s_InformationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Patient_s_InformationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        PatientIDLabel = New System.Windows.Forms.Label()
        PatientLastNameLabel = New System.Windows.Forms.Label()
        PatientFirstNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        MaritalStatusLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        SymptomsLabel = New System.Windows.Forms.Label()
        AdmissionDateLabel = New System.Windows.Forms.Label()
        AssignedDoctorLabel = New System.Windows.Forms.Label()
        RoomNumberLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.Patient_s_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._HospitalData___CopyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_s_InformationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patient_s_InformationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(13, 65)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(57, 13)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        '
        'PatientLastNameLabel
        '
        PatientLastNameLabel.AutoSize = True
        PatientLastNameLabel.Location = New System.Drawing.Point(13, 91)
        PatientLastNameLabel.Name = "PatientLastNameLabel"
        PatientLastNameLabel.Size = New System.Drawing.Size(97, 13)
        PatientLastNameLabel.TabIndex = 2
        PatientLastNameLabel.Text = "Patient Last Name:"
        '
        'PatientFirstNameLabel
        '
        PatientFirstNameLabel.AutoSize = True
        PatientFirstNameLabel.Location = New System.Drawing.Point(13, 117)
        PatientFirstNameLabel.Name = "PatientFirstNameLabel"
        PatientFirstNameLabel.Size = New System.Drawing.Size(96, 13)
        PatientFirstNameLabel.TabIndex = 4
        PatientFirstNameLabel.Text = "Patient First Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(13, 143)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(13, 170)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(13, 196)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(13, 222)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 12
        ContactNumberLabel.Text = "Contact Number:"
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.Location = New System.Drawing.Point(343, 64)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(74, 13)
        MaritalStatusLabel.TabIndex = 14
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(343, 91)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(65, 13)
        OccupationLabel.TabIndex = 16
        OccupationLabel.Text = "Occupation:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(343, 117)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 18
        StatusLabel.Text = "Status:"
        '
        'SymptomsLabel
        '
        SymptomsLabel.AutoSize = True
        SymptomsLabel.Location = New System.Drawing.Point(343, 144)
        SymptomsLabel.Name = "SymptomsLabel"
        SymptomsLabel.Size = New System.Drawing.Size(58, 13)
        SymptomsLabel.TabIndex = 20
        SymptomsLabel.Text = "Symptoms:"
        '
        'AdmissionDateLabel
        '
        AdmissionDateLabel.AutoSize = True
        AdmissionDateLabel.Location = New System.Drawing.Point(343, 171)
        AdmissionDateLabel.Name = "AdmissionDateLabel"
        AdmissionDateLabel.Size = New System.Drawing.Size(83, 13)
        AdmissionDateLabel.TabIndex = 22
        AdmissionDateLabel.Text = "Admission Date:"
        '
        'AssignedDoctorLabel
        '
        AssignedDoctorLabel.AutoSize = True
        AssignedDoctorLabel.Location = New System.Drawing.Point(343, 196)
        AssignedDoctorLabel.Name = "AssignedDoctorLabel"
        AssignedDoctorLabel.Size = New System.Drawing.Size(88, 13)
        AssignedDoctorLabel.TabIndex = 26
        AssignedDoctorLabel.Text = "Assigned Doctor:"
        '
        'RoomNumberLabel
        '
        RoomNumberLabel.AutoSize = True
        RoomNumberLabel.Location = New System.Drawing.Point(343, 222)
        RoomNumberLabel.Name = "RoomNumberLabel"
        RoomNumberLabel.Size = New System.Drawing.Size(78, 13)
        RoomNumberLabel.TabIndex = 28
        RoomNumberLabel.Text = "Room Number:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.clinic_icon_003_h
        Me.PictureBox2.Location = New System.Drawing.Point(9, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(885, 18)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCyan
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PICTUREPANEL)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 98)
        Me.Panel1.TabIndex = 1
        '
        'PICTUREPANEL
        '
        Me.PICTUREPANEL.Location = New System.Drawing.Point(184, 98)
        Me.PICTUREPANEL.Name = "PICTUREPANEL"
        Me.PICTUREPANEL.Size = New System.Drawing.Size(702, 394)
        Me.PICTUREPANEL.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(492, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HOSPITAL AND DIAGNOSTIC CENTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Care"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MHospital"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 33)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Patient's Details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quick Launch"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCyan
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(1, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 537)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Location = New System.Drawing.Point(0, 516)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 20)
        Me.Panel4.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Patient's Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.computer_keyboardstethoscope_medical
        Me.PictureBox1.Location = New System.Drawing.Point(185, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(702, 536)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel5.Location = New System.Drawing.Point(185, 616)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(701, 20)
        Me.Panel5.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightCyan
        Me.Panel6.Controls.Add(PatientIDLabel)
        Me.Panel6.Controls.Add(Me.PatientIDTextBox)
        Me.Panel6.Controls.Add(PatientLastNameLabel)
        Me.Panel6.Controls.Add(Me.PatientLastNameTextBox)
        Me.Panel6.Controls.Add(PatientFirstNameLabel)
        Me.Panel6.Controls.Add(Me.PatientFirstNameTextBox)
        Me.Panel6.Controls.Add(GenderLabel)
        Me.Panel6.Controls.Add(Me.GenderComboBox)
        Me.Panel6.Controls.Add(AgeLabel)
        Me.Panel6.Controls.Add(Me.AgeTextBox)
        Me.Panel6.Controls.Add(AddressLabel)
        Me.Panel6.Controls.Add(Me.AddressTextBox)
        Me.Panel6.Controls.Add(ContactNumberLabel)
        Me.Panel6.Controls.Add(Me.ContactNumberTextBox)
        Me.Panel6.Controls.Add(MaritalStatusLabel)
        Me.Panel6.Controls.Add(Me.MaritalStatusComboBox)
        Me.Panel6.Controls.Add(OccupationLabel)
        Me.Panel6.Controls.Add(Me.OccupationTextBox)
        Me.Panel6.Controls.Add(StatusLabel)
        Me.Panel6.Controls.Add(Me.StatusComboBox)
        Me.Panel6.Controls.Add(SymptomsLabel)
        Me.Panel6.Controls.Add(Me.SymptomsTextBox)
        Me.Panel6.Controls.Add(AdmissionDateLabel)
        Me.Panel6.Controls.Add(Me.AdmissionDateDateTimePicker)
        Me.Panel6.Controls.Add(AssignedDoctorLabel)
        Me.Panel6.Controls.Add(Me.AssignedDoctorTextBox)
        Me.Panel6.Controls.Add(RoomNumberLabel)
        Me.Panel6.Controls.Add(Me.RoomNumberTextBox)
        Me.Panel6.Location = New System.Drawing.Point(185, 99)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(702, 525)
        Me.Panel6.TabIndex = 32
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(116, 62)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientIDTextBox.TabIndex = 1
        '
        'Patient_s_InformationBindingSource
        '
        Me.Patient_s_InformationBindingSource.DataMember = "Patient's Information"
        Me.Patient_s_InformationBindingSource.DataSource = Me._HospitalData___CopyDataSet
        '
        '_HospitalData___CopyDataSet
        '
        Me._HospitalData___CopyDataSet.DataSetName = "_HospitalData___CopyDataSet"
        Me._HospitalData___CopyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientLastNameTextBox
        '
        Me.PatientLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "PatientLastName", True))
        Me.PatientLastNameTextBox.Location = New System.Drawing.Point(116, 88)
        Me.PatientLastNameTextBox.Name = "PatientLastNameTextBox"
        Me.PatientLastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientLastNameTextBox.TabIndex = 3
        '
        'PatientFirstNameTextBox
        '
        Me.PatientFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "PatientFirstName", True))
        Me.PatientFirstNameTextBox.Location = New System.Drawing.Point(116, 114)
        Me.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox"
        Me.PatientFirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientFirstNameTextBox.TabIndex = 5
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(116, 140)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderComboBox.TabIndex = 7
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(116, 167)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgeTextBox.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(116, 193)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 11
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(116, 219)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactNumberTextBox.TabIndex = 13
        '
        'MaritalStatusComboBox
        '
        Me.MaritalStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "MaritalStatus", True))
        Me.MaritalStatusComboBox.FormattingEnabled = True
        Me.MaritalStatusComboBox.Location = New System.Drawing.Point(446, 61)
        Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
        Me.MaritalStatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.MaritalStatusComboBox.TabIndex = 15
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "Occupation", True))
        Me.OccupationTextBox.Location = New System.Drawing.Point(446, 88)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OccupationTextBox.TabIndex = 17
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(446, 114)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(200, 21)
        Me.StatusComboBox.TabIndex = 19
        '
        'SymptomsTextBox
        '
        Me.SymptomsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "Symptoms", True))
        Me.SymptomsTextBox.Location = New System.Drawing.Point(446, 141)
        Me.SymptomsTextBox.Name = "SymptomsTextBox"
        Me.SymptomsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SymptomsTextBox.TabIndex = 21
        '
        'AdmissionDateDateTimePicker
        '
        Me.AdmissionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Patient_s_InformationBindingSource, "AdmissionDate", True))
        Me.AdmissionDateDateTimePicker.Location = New System.Drawing.Point(446, 167)
        Me.AdmissionDateDateTimePicker.Name = "AdmissionDateDateTimePicker"
        Me.AdmissionDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AdmissionDateDateTimePicker.TabIndex = 23
        '
        'AssignedDoctorTextBox
        '
        Me.AssignedDoctorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "AssignedDoctor", True))
        Me.AssignedDoctorTextBox.Location = New System.Drawing.Point(446, 193)
        Me.AssignedDoctorTextBox.Name = "AssignedDoctorTextBox"
        Me.AssignedDoctorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AssignedDoctorTextBox.TabIndex = 27
        '
        'RoomNumberTextBox
        '
        Me.RoomNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_s_InformationBindingSource, "RoomNumber", True))
        Me.RoomNumberTextBox.Location = New System.Drawing.Point(446, 219)
        Me.RoomNumberTextBox.Name = "RoomNumberTextBox"
        Me.RoomNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RoomNumberTextBox.TabIndex = 29
        '
        'Patient_s_InformationTableAdapter
        '
        Me.Patient_s_InformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Patient_s_InformationTableAdapter = Me.Patient_s_InformationTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._HospitalData___CopyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Patient_s_InformationBindingNavigator
        '
        Me.Patient_s_InformationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patient_s_InformationBindingNavigator.BindingSource = Me.Patient_s_InformationBindingSource
        Me.Patient_s_InformationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Patient_s_InformationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Patient_s_InformationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Patient_s_InformationBindingNavigatorSaveItem})
        Me.Patient_s_InformationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Patient_s_InformationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Patient_s_InformationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Patient_s_InformationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Patient_s_InformationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Patient_s_InformationBindingNavigator.Name = "Patient_s_InformationBindingNavigator"
        Me.Patient_s_InformationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Patient_s_InformationBindingNavigator.Size = New System.Drawing.Size(887, 25)
        Me.Patient_s_InformationBindingNavigator.TabIndex = 33
        Me.Patient_s_InformationBindingNavigator.Text = "BindingNavigator1"
        Me.Patient_s_InformationBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'Patient_s_InformationBindingNavigatorSaveItem
        '
        Me.Patient_s_InformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient_s_InformationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Patient_s_InformationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Patient_s_InformationBindingNavigatorSaveItem.Name = "Patient_s_InformationBindingNavigatorSaveItem"
        Me.Patient_s_InformationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Patient_s_InformationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 636)
        Me.Controls.Add(Me.Patient_s_InformationBindingNavigator)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "MHospital Care"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.Patient_s_InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._HospitalData___CopyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_s_InformationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patient_s_InformationBindingNavigator.ResumeLayout(False)
        Me.Patient_s_InformationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PICTUREPANEL As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents _HospitalData___CopyDataSet As WindowsApplication1._HospitalData___CopyDataSet
    Friend WithEvents Patient_s_InformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_s_InformationTableAdapter As WindowsApplication1._HospitalData___CopyDataSetTableAdapters.Patient_s_InformationTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._HospitalData___CopyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_s_InformationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Patient_s_InformationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaritalStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SymptomsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmissionDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AssignedDoctorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoomNumberTextBox As System.Windows.Forms.TextBox

End Class
