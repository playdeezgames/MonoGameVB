Public Class SpriteRenderer(Of TSpriteIdentifier, THueIdentifier, TTextureIdentifier)
    Implements ISpriteRenderer(Of TSpriteIdentifier, THueIdentifier)

    Private ReadOnly _textureManager As ITextureManager(Of TTextureIdentifier)
    Private ReadOnly _spriteManager As ISpriteManager(Of TSpriteIdentifier)
    Private ReadOnly _hues As IReadOnlyDictionary(Of THueIdentifier, Color)
    Private ReadOnly _spriteBatch As SpriteBatch
    Private ReadOnly _scale As Integer = 4

    Public Sub New(
                  textureManager As ITextureManager(Of TTextureIdentifier),
                  spriteManager As ISpriteManager(Of TSpriteIdentifier),
                  hues As IReadOnlyDictionary(Of THueIdentifier, Color),
                  spriteBatch As SpriteBatch)
        _textureManager = textureManager
        _spriteBatch = spriteBatch
        _spriteManager = spriteManager
        _hues = hues
    End Sub

    Public Sub Draw(
                   spriteIdentifier As TSpriteIdentifier,
                   position As XY(Of Integer),
                   hueIdentifier As THueIdentifier) Implements ISpriteRenderer(Of TSpriteIdentifier, THueIdentifier).Draw
        Dim sprite = DirectCast(_spriteManager.GetSprite(spriteIdentifier), Sprite(Of TTextureIdentifier))
        Dim texture = _textureManager.GetTexture(sprite.TextureIdentifier)
        Dim sourceRectangle As New Rectangle(sprite.Source.X, sprite.Source.Y, CInt(sprite.Size.X), CInt(sprite.Size.Y))
        Dim destinationRectangle As New Rectangle((position.X + sprite.Offset.X) * _scale, (position.Y + sprite.Offset.Y) * _scale, CInt(sprite.Size.X * _scale), CInt(sprite.Size.Y * _scale))
        _spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, _hues(hueIdentifier))
    End Sub
End Class
