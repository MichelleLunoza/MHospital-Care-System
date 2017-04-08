Public Class Form1

    Private Sub Patient_s_InformationBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Patient_s_InformationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patient_s_InformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._HospitalData___CopyDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_HospitalData___CopyDataSet._Patient_s_Information' table. You can move, or remove it, as needed.
        Me.Patient_s_InformationTableAdapter.Fill(Me._HospitalData___CopyDataSet._Patient_s_Information)
        Panel6.Visible = False


        PatientIDTextBox.Enabled = False
        PatientLastNameTextBox.Enabled = False
        PatientFirstNameTextBox.Enabled = False
        GenderComboBox.Enabled = False
        AgeTextBox.Enabled = False
        AddressTextBox.Enabled = False
        ContactNumberTextBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        OccupationTextBox.Enabled = False
        StatusComboBox.Enabled = False
        SymptomsTextBox.Enabled = False
        AdmissionDateDateTimePicker.Enabled = False
        AssignedDoctorTextBox.Enabled = False
        RoomNumberTextBox.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.Visible = False
        Panel6.Visible = True

        PatientIDTextBox.Enabled = False
        PatientLastNameTextBox.Enabled = False
        PatientFirstNameTextBox.Enabled = False
        GenderComboBox.Enabled = False
        AgeTextBox.Enabled = False
        AddressTextBox.Enabled = False
        ContactNumberTextBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        OccupationTextBox.Enabled = False
        StatusComboBox.Enabled = False
        SymptomsTextBox.Enabled = False
        AdmissionDateDateTimePicker.Enabled = False
        AssignedDoctorTextBox.Enabled = False
        RoomNumberTextBox.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Panel6.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Panel6.Visible = True
        PictureBox1.Visible = False

        PatientIDTextBox.Enabled = True
        PatientLastNameTextBox.Enabled = True
        PatientFirstNameTextBox.Enabled = True
        GenderComboBox.Enabled = True
        AgeTextBox.Enabled = True
        AddressTextBox.Enabled = True
        ContactNumberTextBox.Enabled = True
        MaritalStatusComboBox.Enabled = True
        OccupationTextBox.Enabled = True
        StatusComboBox.Enabled = True
        SymptomsTextBox.Enabled = True
        AdmissionDateDateTimePicker.Enabled = True
        AssignedDoctorTextBox.Enabled = True
        RoomNumberTextBox.Enabled = True
    End Sub

   
End Class
