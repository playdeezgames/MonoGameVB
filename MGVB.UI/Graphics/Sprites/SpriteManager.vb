Friend Class SpriteManager(Of TSpriteIdentifier, TTextureIdentifier)
    Implements ISpriteManager(Of TSpriteIdentifier)

    Private _table As Dictionary(Of TSpriteIdentifier, Sprite(Of TTextureIdentifier))

    Public Sub New(source As Dictionary(Of TSpriteIdentifier, Sprite(Of TTextureIdentifier)))
        _table = source
    End Sub

    Public Function GetSprite(spriteIdentifier As TSpriteIdentifier) As ISprite Implements ISpriteManager(Of TSpriteIdentifier).GetSprite
        Return _table(spriteIdentifier)
    End Function
End Class
