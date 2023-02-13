Public Class SpriteManager(Of TSpriteIdentifier, TTextureIdentifier)
    Implements ISpriteManager(Of TSpriteIdentifier)

    Private ReadOnly _table As IReadOnlyDictionary(Of TSpriteIdentifier, ISprite)

    Public Sub New(source As IReadOnlyDictionary(Of TSpriteIdentifier, ISprite))
        _table = source
    End Sub

    Public Function GetSprite(spriteIdentifier As TSpriteIdentifier) As ISprite Implements ISpriteManager(Of TSpriteIdentifier).GetSprite
        Return _table(spriteIdentifier)
    End Function
End Class
