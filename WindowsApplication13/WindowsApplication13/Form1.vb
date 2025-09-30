Public Class Form1
    Dim i As Integer
    Dim x, y, w, k As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = Chr(13) + Chr(10)
        x = "جامعة الملك سعود" + w
        x = x + "مركز التدريب وخدمة المجتمع" + w
        x = x + "دبلوم الحاسب الآلي" + w
        x = x + "إعداد الأستاذ حذيفة عبدالرحمن" + w
        x = x + "للعام الدراسي 1442  "
        y = "حول المشروع"
        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
