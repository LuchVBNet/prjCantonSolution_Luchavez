Imports MaterialSkin

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        'Set Useful Life Items
        For intYear As Integer = 3 To 20
            lstUsefulLife.Items.Add(intYear.ToString)
        Next intYear
    End Sub

    Private Sub btnDepreciation_Click(sender As Object, e As EventArgs) Handles btnDepreciation.Click
        'Declare
        Dim decAssetCost, decSalvageValue As Decimal
        Dim intUsefulLife As Integer
        Dim dblDDB, dblSYD As Double

        'Get Inputs
        Decimal.TryParse(txtAssetCost.Text, decAssetCost)
        Decimal.TryParse(txtSalvageValue.Text, decSalvageValue)
        Integer.TryParse(lstUsefulLife.SelectedItem.ToString, intUsefulLife)

        'Reset Outputs
        txtDDB.Text = "Year" & ControlChars.Tab & "Depreciation" & ControlChars.NewLine
        txtSYD.Text = "Year" & ControlChars.Tab & "Depreciation" & ControlChars.NewLine

        'Process
        For intYear As Integer = 1 To intUsefulLife
            'Calculate
            dblDDB = DDB(decAssetCost, decSalvageValue, intUsefulLife, intYear)
            dblSYD = SYD(decAssetCost, decSalvageValue, intUsefulLife, intYear)
            'Add to Display
            txtDDB.Text = txtDDB.Text & intYear.ToString & ControlChars.Tab & dblDDB.ToString("N2") & ControlChars.NewLine
            txtSYD.Text = txtSYD.Text & intYear.ToString & ControlChars.Tab & dblSYD.ToString("N2") & ControlChars.NewLine
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtSalvageValue.TextChanged, txtAssetCost.TextChanged, lstUsefulLife.SelectedValueChanged
        txtDDB.Clear()
        txtSYD.Clear()
    End Sub

    Private Sub input_Focused(sender As Object, e As EventArgs) Handles txtSalvageValue.Click, txtAssetCost.Click
        Dim t As TextBox = CType(sender, TextBox)
        t.SelectAll()
    End Sub
End Class
