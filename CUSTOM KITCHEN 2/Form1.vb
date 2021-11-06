Public Class Form1
    Public Shared kitchenStyles() As String = {
            "Small L-shaped kitchen",
            "Medium L-shaped kitchen",
            "Large L-shaped kitchen",
            "Small straight kitchen",
            "Medium straight kitchen",
            "Large straight kitchen",
            "Large island kitchen"
    }

    Public Shared dimensions(,) As Integer = {
        {250, 180},
        {350, 240},
        {450, 350},
        {150, 60},
        {350, 60},
        {500, 60},
        {450, 450}
    }

    Public Shared counterTopNames() As String = {
        "Laminate",
        "Wood block",
        "Granite"
    }

    Public Shared counterTopsPricing(,) As Integer = {
        {3500, 4500, 5750},
        {6500, 7750, 9500},
        {8250, 9500, 12500},
        {1000, 1500, 2200},
        {5250, 6200, 8000},
        {6750, 8500, 11000},
        {12500, 15000, 23000}
    }

    Public Shared kitchenAppliancesNames() As String = {
        "Basic Fridge Freezer",
        "American Style Fridge Freezer",
        "Hob",
        "Single Oven",
        "Double Oven",
        "Dishwasher"
    }

    Public Shared kitchenAppliancesPrices() As Integer = {
        180,
        750,
        400,
        340,
        550,
        270
    }

    Public Shared kitchenInstallationCost() As Integer = {
        1250,
        2750,
        3750,
        750,
        1500,
        2500,
        4750
    }

    Public Shared shippingCost As Integer = 95

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged

    End Sub
    Private Sub lblWidth_Click(sender As Object, e As EventArgs) Handles lblWidth.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub btnEnterSpecification_Click(sender As Object, e As EventArgs) Handles btnEnterSpecification.Click
        Dim length As Integer = Convert.ToInt32(txtLength.Text)
        Dim width As Integer = Convert.ToInt32(txtWidth.Text)
        Dim maximumBudget As Integer = Convert.ToInt32(txtMaximumBudget.Text)


        If length < 150 Then
            MessageBox.Show("Kitchen length value can only be a minimum of 150!")
            txtLength.Text = "150"
            length = Convert.ToInt32(txtLength.Text)
        ElseIf length > 600 Then
            MessageBox.Show("Kitchen length value can only be a maximum 0f 600!")
            txtLength.Text = "600"
            length = Convert.ToInt32(txtLength.Text)
        End If
        If width < 120 Then
            MessageBox.Show("Kitchen width value can only be a minimum of 120!")
            txtWidth.Text = "120"
            width = Convert.ToInt32(txtWidth.Text)
        ElseIf width > 600 Then
            MessageBox.Show("Kitchen width value can only be a maximum of 600!")
            txtWidth.Text = "600"
            width = Convert.ToInt32(txtWidth.Text)
        End If
        If maximumBudget < 1000 Then
            MessageBox.Show("Total budget entered can only be a minimum of 1,000!")
            txtMaximumBudget.Text = "1000"
            maximumBudget = Convert.ToInt32(txtMaximumBudget.Text)
        ElseIf maximumBudget > 25000 Then

            MessageBox.Show("Total budget entered can only be a maximum of 25,000!")
            txtMaximumBudget.Text = "25000"
            maximumBudget = Convert.ToInt32(txtMaximumBudget.Text)
        End If
        MessageBox.Show("Valid")



    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Me.Hide()
        FrmCustomer_Detail.Visible = True

    End Sub
End Class
