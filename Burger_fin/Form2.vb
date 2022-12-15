Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form2
    Private Sub Bacon_Cheese_but_Click(sender As Object, e As EventArgs) Handles Bacon_Cheese_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Bacon_Cheese_qty.Text
        label = Bacon_Cheese.Text

        price = qty * Val(Bacon_Cheese_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Black_Pepper_but_Click(sender As Object, e As EventArgs) Handles Black_Pepper_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Black_Pepper_qty.Text
        label = Black_Pepper.Text

        price = qty * Val(Black_Pepper_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Beef_Shawarma_but_Click(sender As Object, e As EventArgs) Handles Beef_Shawarma_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Beef_Shawarma_qty.Text
        label = Beef_Shawarma.Text

        price = qty * Val(Beef_Shawarma_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Baconnaise_Chicken_but_Click(sender As Object, e As EventArgs) Handles Baconnaise_Chicken_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Baconnaise_Chicken_qty.Text
        label = Baconnaise_Chicken.Text

        price = qty * Val(Baconnaise_Chicken_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Veggie_Premuim_but_Click(sender As Object, e As EventArgs) Handles Veggie_Premuim_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Veggie_Premuim_qty.Text
        label = Veggie_Premuim.Text

        price = qty * Val(Veggie_Premuim_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Double_Chicken_Time_but_Click(sender As Object, e As EventArgs) Handles Double_Chicken_Time_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Double_Chicken_Time_qty.Text
        label = Double_Chicken_Time.Text

        price = qty * Val(Double_Chicken_Time_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Chicken_Time_but_Click(sender As Object, e As EventArgs) Handles Chicken_Time_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Chicken_Time_qty.Text
        label = Chicken_Time.Text

        price = qty * Val(Chicken_Time_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Chilicon_Cheese_but_Click(sender As Object, e As EventArgs) Handles Chilicon_Cheese_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Chilicon_Cheese_qty.Text
        label = Chilicon_Cheese.Text

        price = qty * Val(Chilicon_Cheese_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Cheesy_Dog_but_Click(sender As Object, e As EventArgs) Handles Cheesy_Dog_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Cheesy_Dog_qty.Text
        label = Cheesy_Dog.Text

        price = qty * Val(Cheesy_Dog_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Minute_Burger_but_Click(sender As Object, e As EventArgs) Handles Minute_Burger_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Minute_Burger_qty.Text
        label = Minute_Burger.Text

        price = qty * Val(Minute_Burger_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Double_Minute_Burger_but_Click(sender As Object, e As EventArgs) Handles Double_Minute_Burger_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Double_Minute_Burger_qty.Text
        label = Double_Minute_Burger.Text

        price = qty * Val(Double_Minute_Burger_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Cheesy_Burger_but_Click(sender As Object, e As EventArgs) Handles Cheesy_Burger_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Cheesy_Burger_qty.Text
        label = Cheesy_Burger.Text

        price = qty * Val(Cheesy_Burger_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Double_Cheesy_Burger_but_Click(sender As Object, e As EventArgs) Handles Double_Cheesy_Burger_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Double_Cheesy_Burger_qty.Text
        label = Double_Cheesy_Burger.Text

        price = qty * Val(Double_Cheesy_Burger_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Calamantea_but_Click(sender As Object, e As EventArgs) Handles Calamantea_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Calamantea_qty.Text
        label = Calamantea.Text

        price = qty * Val(Calamantea_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Krazy_Winter_but_Click(sender As Object, e As EventArgs) Handles Krazy_Winter_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Krazy_Winter_qty.Text
        label = Krazy_Winter.Text

        price = qty * Val(Krazy_Winter_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Iced_Choco_but_Click(sender As Object, e As EventArgs) Handles Iced_Choco_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Iced_Choco_qty.Text
        label = Iced_Choco.Text

        price = qty * Val(Iced_Choco_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Hot_Choco_but_Click(sender As Object, e As EventArgs) Handles Hot_Choco_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Hot_Choco_qty.Text
        label = Hot_Choco.Text

        price = qty * Val(Hot_Choco_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Nachos_but_Click(sender As Object, e As EventArgs) Handles Nachos_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Nachos_qty.Text
        label = Nachos.Text

        price = qty * Val(Nachos_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Barkada_but_Click(sender As Object, e As EventArgs) Handles Barkada_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Barkada_qty.Text
        label = Barkada.Text

        price = qty * Val(Barkada_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Animeal_but_Click(sender As Object, e As EventArgs) Handles Animeal_but.Click
        Dim qty, price As Integer
        Dim label As String
        qty = Animeal_qty.Text
        label = Animeal.Text

        price = qty * Val(Animeal_but.Text)
        Dim otherItems As String() = {label, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Proceed_but_Click(sender As Object, e As EventArgs) Handles Proceed_but.Click
        Dim Index As Integer
        Dim TotalValue As Double

        For Index = 1 To Me.ListView1.Items.Count - 1
            Dim X As Double = CDbl(Me.ListView1.Items.Item(Index).SubItems(2).Text)
            TotalValue = TotalValue + X
        Next

        Dim vats, tot_vat As Single

        vats = (TotalValue * 12) / 100
        tot_vat = TotalValue + vats

        sub_tot.Text = TotalValue
        tot_due.Text = tot_vat
        vat.Text = vats
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next
    End Sub

    Private Sub num_discounted_MouseLeave(sender As Object, e As EventArgs) Handles num_discounted.MouseLeave
        Dim noD, noC As Integer
        noC = Val(num_customer.Text)
        noD = Val(num_discounted.Text)

        If noD > noC Then
            MsgBox("Invalid Number")

        End If
        Dim disc, due As Single
        Dim no_discount As Integer

        due = Val(sub_tot.Text)
        no_discount = Val(num_discounted.Text)

        If dc1.Checked Or dc2.Checked Then
            disc = (((due * 0.2) - Val(vat.Text)) * no_discount)
        End If


        discounted_amount.Text = disc
    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint
        If dc1.Checked Or dc2.Checked Then
            num_discounted.Enabled = True
        End If

    End Sub

    Private Sub bayad_MouseLeave(sender As Object, e As EventArgs) Handles bayad.MouseLeave
        Dim due, binayad As Single
        due = Val(tot_due.Text)
        binayad = Val(bayad.Text)
        If due > binayad Then
            MsgBox("Invalid Amount")
        End If
        sukli.Text = (Val(bayad.Text) - Val(tot_due.Text)) + Val(discounted_amount.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Date:" & vbTab & vbTab & My.Computer.Clock.LocalTime & vbCrLf & vbCrLf &
               "Name:" & vbTab & vbTab & Val(Costumer_name.Text) & vbCrLf &
               "Subtotal:" & vbTab & vbTab & Val(sub_tot.Text) & vbCrLf &
               "VAT:" & vbTab & vbTab & Val(vat.Text) & vbCrLf &
               "Discounted:" & vbTab & Val(num_discounted.Text) & Space(3) & Val(discounted_amount.Text) & vbCrLf &
               "Total Due:" & vbTab & Val(tot_due.Text) & vbCrLf &
               "Paid:" & vbTab & vbTab & Val(bayad.Text) & vbCrLf &
               "Change:" & vbTab & vbTab & Val(sukli.Text))
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
