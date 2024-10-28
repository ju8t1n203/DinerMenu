'Justin Bell
'RCET0265
'Fall24
'Diner Menu
' link
Public Class DinerMenu
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ClearLabels()
        'removes any exsisting labels so the new ones can be added
        If Me.Tag IsNot Nothing Then
            Dim labels() As Label = CType(Me.Tag, Label())
            For Each lbl In labels
                Me.Controls.Remove(lbl)
            Next
            Me.Tag = Nothing
        End If
    End Sub
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        ClearLabels()
        Dim soupName As New Label
        Dim soup As New Label

        'soup name
        soupName.Text = "Stew of Yesterday"
        soupName.Font = New Font("Haettenschweiler", 16, FontStyle.Regular)
        soupName.AutoSize = True

        'soup description
        soup.Text = "This delightful stew contains all perfectly unused ingredients from the day before to create an exciting bundle of flavors!"
        soup.TextAlign = ContentAlignment.MiddleCenter ' Center align the text
        soup.Font = New Font("Haettenschweiler", 14, FontStyle.Regular)
        soup.MaximumSize = New Size(ClientSize.Width - 20, 0) ' Ensure text wraps properly
        soup.AutoSize = True

        'adds controls
        Me.Controls.Add(soupName)
        Me.Controls.Add(soup)

        'location for the labels
        soupName.Location = New Point((ClientSize.Width - soupName.Width) / 2, ClientSize.Height / 3)
        soup.Location = New Point((ClientSize.Width - soup.Width) / 2, soupName.Location.Y + soupName.Height + 10)

        Me.Tag = New Label() {soupName, soup}

    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        ClearLabels()
        Dim saladName As New Label
        Dim salad As New Label

        'salad name
        saladName.Text = "Royale Caesar Salad"
        saladName.Font = New Font("Haettenschweiler", 16, FontStyle.Regular)
        saladName.AutoSize = True

        'salad description
        salad.Text = "Romaine lettuce, croutons, crushed capers, Parmesan cheese, lemon juice, olive oil, egg yolks, worcestershire sauce, anchovies, dijon mustard, black pepper"
        salad.TextAlign = ContentAlignment.MiddleCenter ' Center align the text
        salad.Font = New Font("Haettenschweiler", 14, FontStyle.Regular)
        salad.MaximumSize = New Size(ClientSize.Width - 20, 0) ' Ensure text wraps properly
        salad.AutoSize = True

        'adds controls
        Me.Controls.Add(saladName)
        Me.Controls.Add(salad)

        'location for the labels
        saladName.Location = New Point((ClientSize.Width - saladName.Width) / 2, ClientSize.Height / 3)
        salad.Location = New Point((ClientSize.Width - salad.Width) / 2, saladName.Location.Y + saladName.Height + 10)

        Me.Tag = New Label() {saladName, salad}

    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        ClearLabels()
        Dim fishName As New Label
        Dim fish As New Label

        'fish name
        fishName.Text = "Tsunami Tuna"
        fishName.Font = New Font("Haettenschweiler", 16, FontStyle.Regular)
        fishName.AutoSize = True

        'fish description
        fish.Text = "This wonderful wild caught tuna is prepared with butter, lemon and those tsunami spices to create a life changing dish."
        fish.TextAlign = ContentAlignment.MiddleCenter ' Center align the text
        fish.Font = New Font("Haettenschweiler", 14, FontStyle.Regular)
        fish.MaximumSize = New Size(ClientSize.Width - 20, 0) ' Ensure text wraps properly
        fish.AutoSize = True

        'adds controls
        Me.Controls.Add(fishName)
        Me.Controls.Add(fish)

        'location for the labels
        fishName.Location = New Point((ClientSize.Width - fishName.Width) / 2, ClientSize.Height / 3)
        fish.Location = New Point((ClientSize.Width - fish.Width) / 2, fishName.Location.Y + fishName.Height + 10)

        Me.Tag = New Label() {fishName, fish}

    End Sub
End Class
