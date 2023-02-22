Public Class frmairbnbreservations
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub txtnights_TextChanged(sender As Object, e As EventArgs) Handles txtnights.TextChanged
        'Dim strNumberOfDays
        'Dim strNumberOfDays = txtNumberOfDays.text
        Dim intNumberofDays As Integer
        intNumberofDays = 4

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint
        'decTotalCost As Decimal
    End Sub

    Private Sub btndisplaycost_Click(sender As Object, e As EventArgs) Handles btndisplaycost.Click
        lblprice.Visible = True
        'dim decTotalCost As Decimal = $79.00
        Dim _decPricePerNight As Decimal = 79D
        lblprice.Visible = True


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblprice.Click
        Dim decTotalCost As Decimal


        lblprice.Visible = True
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        btnclear.
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub
End Class
