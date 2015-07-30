Public Class Menu_Page
    Dim AddOutfits As Create_Outfit
    Dim AllOutfits As All_Outfits
    Dim Search As Search_Page
    Dim Fave As Favourite_Outfits
    Dim Suggest As Suggestions
    Dim Wish As Wish_List

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddOutfit.Click
        AddOutfits = New Create_Outfit()
        Me.Close()
        AddOutfits.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAllOutfits.Click
        AllOutfits = New All_Outfits()
        Me.Close()
        AllOutfits.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search = New Search_Page()
        Me.Close()
        Search_Page.Show()
    End Sub

    Private Sub btnFave_Click(sender As Object, e As EventArgs) Handles btnFave.Click
        Fave = New Favourite_Outfits()
        Me.Close()
        Favourite_Outfits.Show()
    End Sub

    Private Sub btnSuggestions_Click(sender As Object, e As EventArgs) Handles btnSuggestions.Click
        Suggest = New Suggestions()
        Me.Close()
        Suggestions.Show()
    End Sub

    Private Sub btnWish_Click(sender As Object, e As EventArgs) Handles btnWish.Click
        Wish = New Wish_List()
        Me.Close()
        Wish_List.Show()
    End Sub
End Class