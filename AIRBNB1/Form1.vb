Public Class frmairbnbreservations







    Private Sub btndisplaycost_Click(sender As Object, e As EventArgs) Handles btndisplaycost.Click

        Dim strNumberOfDays = txtnights.Text
        'MsgBox(strNumberOfDays)
        Dim intNumberofDays As Integer
        intNumberofDays = Convert.ToInt32(strNumberOfDays)



        Dim _decPricePerNight As Decimal = 79D
        Dim dectotal As Decimal = _decPricePerNight * intNumberofDays
        'MsgBox(dectotal)
        lblprice.Text = dectotal.ToString("c")



    End Sub




    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnights.Text = ""
        lblprice.Text = ""
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub


End Class
