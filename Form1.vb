Public Class Form1


    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Dim taille = list.SelectedItem.ToString()
        Dim ingredient As String = ""
        If rd1.Checked Then
            ingredient = "Croute fine "
        ElseIf rd2.Checked Then
            ingredient = "Croute classique "
        ElseIf rd3.Checked Then
            ingredient = "Croute epaisse "
        End If

        Dim IngrSupp As String = ""
        If Ch1.Checked Then
            IngrSupp = IngrSupp + "champinion"
        ElseIf Ch2.Checked Then
            IngrSupp = IngrSupp + "olives"
        ElseIf Ch3.Checked Then
            IngrSupp = IngrSupp + "poivrins"
        ElseIf Ch4.Checked Then
            IngrSupp = IngrSupp + "fromage  supplimentaire"

        End If
        Dim msg As String = "   taille:" + taille + "type de croute:" + ingredient + "ingredient supplimentaire:"
        MessageBox.Show(msg)









    End Sub


End Class
