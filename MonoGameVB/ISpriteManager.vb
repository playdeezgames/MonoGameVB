Public Interface ISpriteManager(Of TSpriteIdentifier, TTextureIdentifier)
    Function GetSprite(spriteIdentifier As TSpriteIdentifier) As Sprite(Of TTextureIdentifier)
End Interface
