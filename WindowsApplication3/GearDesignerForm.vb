Public Class GearDesignerForm
    '**TBD** maybe gearList in a tab?

    Dim materials As New List(Of material)
    Dim boxes As New List(Of gearBox)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'declaration of example materials
        Dim steel001 As New material("Steel", 240)
        Dim alu001 As New material("Aluminium", 414)
        Dim brass001 As New material("Brass", 200)
        materials.Add(steel001)
        materials.Add(alu001)
        materials.Add(brass001)

        'declaration of sample gearbox
        Dim GB0001 As New gearBox()
        GB0001.Name = "GB2050St5300"
        GB0001.Material1 = steel001
        GB0001.Material2 = steel001
        GB0001.Modulus = 5
        GB0001.Distance = 300
        GB0001.Torque1 = 200
        GB0001.Torque2 = 500

        Dim GB0002 As New gearBox()
        GB0002.Name = "GB3050AlBr6220"
        GB0002.Material1 = alu001
        GB0002.Material2 = brass001
        GB0002.Modulus = 6
        GB0002.Distance = 220
        GB0002.Torque1 = 300
        GB0002.Torque2 = 500

        boxes.Add(GB0001)
        boxes.Add(GB0002)

        'filling the material dropdowns with values
        For Each mat As material In materials
            InputMaterial1.Items.Add(mat)
            InputMaterial2.Items.Add(mat)
        Next

        'making the gearboxes list
        gearList.View = View.Details
        gearList.GridLines = True
        gearList.Sorting = SortOrder.Ascending
        gearList.Columns.Clear()
        gearList.Columns.Add("Name", 140, HorizontalAlignment.Left)
        gearList.Columns.Add("In", 40, HorizontalAlignment.Left)
        gearList.Columns.Add("Out", 40, HorizontalAlignment.Left)
        gearList.Columns.Add("D", 40, HorizontalAlignment.Left)
        gearList.Columns.Add("m", 40, HorizontalAlignment.Left)
        UpdateGearList()

    End Sub

    Private Sub UpdateGearList()
        For Each G As gearBox In boxes
            Dim exist As Boolean = False
            Dim item As ListViewItem
            For Each element As ListViewItem In gearList.Items
                If element.Tag Is G Then
                    exist = True
                    item = element
                    Exit For
                End If
            Next
            If exist = False Then
                item = New ListViewItem()
                gearList.Items.Add(item)
            End If
            item.Text = G.Name
            item.Name = G.Name
            item.Tag = G
            item.SubItems.Add(G.Torque1)
            item.SubItems.Add(G.Torque2)
            item.SubItems.Add(G.Distance)
            item.SubItems.Add(G.Modulus)
        Next

    End Sub

    Private Sub inputMaterial1_TextChanged(sender As Object, e As EventArgs) Handles InputMaterial1.TextChanged
        Dim input As String
        If TypeOf InputMaterial1.SelectedItem Is material Then
            input = InputMaterial1.SelectedItem.ToString
        Else
            input = InputMaterial1.Text
        End If
        InputSigma1.Text = ""
        InputSigma1.ReadOnly = False
        For Each mat As material In materials
            If mat.Name = input Then
                InputSigma1.Text = mat.Sigma
                '**TBD** readonly does not work all the time, especially not when loading existing gear
                InputSigma1.ReadOnly = True
                InputMaterial1.Focus()
            End If
        Next
    End Sub

    Private Sub inputMaterial2_TextChanged(sender As Object, e As EventArgs) Handles InputMaterial2.TextChanged
        Dim input As String
        If TypeOf InputMaterial2.SelectedItem Is material Then
            input = InputMaterial2.SelectedItem.ToString
        Else
            input = InputMaterial2.Text
        End If
        InputSigma2.Text = ""
        InputSigma2.ReadOnly = False
        For Each mat As material In materials
            If mat.Name = input Then
                InputSigma2.Text = mat.Sigma
                InputSigma2.ReadOnly = True
                InputMaterial2.Focus()
            End If
        Next
    End Sub

    'checking while leaving certain inputBoxes if content is Double, then throwing an alert:
    Private Sub checkForDouble(sender As TextBox, e As EventArgs) Handles _
        InputTorque2.Leave, InputTorque1.Leave, InputRatio.Leave, InputDistance.Leave, InputModul.Leave, InputSigma1.TextChanged, InputSigma2.TextChanged
        If sender.Text <> String.Empty Then
            If Not IsNumeric(sender.Text) Then
                MsgBox("Please enter a numeric value that is not 0")
                sender.BackColor = Color.Red
                sender.Focus()
            Else
                sender.BackColor = Color.White
                If Not InputDistance.Text = "" And _
                    Not InputModul.Text = "" And _
                    Not InputRatio.Text = "" And _
                    Not InputSigma1.Text = "" And _
                    Not InputSigma2.Text = "" And _
                    Not InputTorque1.Text = "" And _
                    Not InputTorque2.Text = "" Then
                    BtnGo.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub InputTorque2_TextChanged(sender As Object, e As EventArgs) Handles InputTorque2.TextChanged
        If IsNumeric(InputTorque2.Text) And IsNumeric(InputTorque1.Text) Then
            InputRatio.Text = InputTorque1.Text / InputTorque2.Text
        End If
    End Sub

    Private Sub InputTorque1_TextChanged(sender As Object, e As EventArgs) Handles InputTorque1.TextChanged
        If IsNumeric(InputTorque1.Text) And IsNumeric(InputTorque2.Text) Then
            InputRatio.Text = InputTorque1.Text / InputTorque2.Text
        End If
    End Sub


    Private Sub InputRatio_TextChanged(sender As Object, e As EventArgs) Handles InputRatio.TextChanged
        If IsNumeric(InputRatio.Text) And IsNumeric(InputTorque1.Text) Then
            InputTorque2.Text = InputTorque1.Text / InputRatio.Text
        End If
    End Sub

    Private Sub InputTorque2_TextChanged_1(sender As Object, e As EventArgs) Handles InputTorque2.TextChanged

    End Sub

    Private Sub BtnMatMgm_Click(sender As Object, e As EventArgs) Handles BtnMatMgm.Click
        MaterialManagerForm.ShowDialog()
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        Dim material1 As material
        If TypeOf InputMaterial1.SelectedItem Is material Then
            material1 = InputMaterial1.SelectedItem
        Else
            material1 = New material(InputMaterial1.Text, InputSigma1.Text)
        End If

        Dim material2 As material
        If TypeOf InputMaterial2.SelectedItem Is material Then
            material2 = InputMaterial2.SelectedItem
        Else
            material2 = New material(InputMaterial2.Text, InputSigma2.Text)
        End If

        Dim gbName As String
        If cbSave.Checked = True Then
            gbName = tbNewName.Text
        Else
            gbName = "temporyGearbox"
        End If

        '**TBD** checkup "does name exist?" 
        Dim NewGearBox As New gearBox()
        NewGearBox.Name = gbName
        NewGearBox.Material1 = material1
        NewGearBox.Material2 = material2
        NewGearBox.Modulus = InputModul.Text
        NewGearBox.Distance = InputDistance.Text
        NewGearBox.Torque1 = InputTorque1.Text
        NewGearBox.Torque2 = InputTorque2.Text

        boxes.Add(NewGearBox)
        UpdateGearList()
    End Sub

    Private Sub gearList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gearList.SelectedIndexChanged
        If gearList.SelectedItems.Count > 0 Then
            PropertyGrid1.SelectedObject = gearList.SelectedItems(0).Tag
        End If
        '**TBD** if no selection, load/delete greyed out
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        If gearList.SelectedItems.Count > 0 Then
            Dim gb As gearBox = gearList.SelectedItems(0).Tag
            InputDistance.Text = gb.Distance
            InputMaterial1.SelectedItem = gb.Material1
            InputMaterial2.SelectedItem = gb.Material2
            InputModul.Text = gb.Modulus
            InputTorque1.Text = gb.Torque1
            InputTorque2.Text = gb.Torque2
            tbNewName.Text = gb.Name & " (changed)"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If gearList.SelectedItems.Count > 0 Then
            Dim gb As gearBox = gearList.SelectedItems(0).Tag
            '**TBD** pop-up are you sure?
            '**TBD** kill the object.
        End If
    End Sub
End Class