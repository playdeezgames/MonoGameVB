Friend Class SpriteRenderer
    Implements ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)

    Private ReadOnly _textureManager As ITextureManager(Of TextureIdentifier)
    Private ReadOnly _spriteManager As ISpriteManager(Of SpriteIdentifier)
    Private ReadOnly _hues As Dictionary(Of HueIdentifier, Color)
    Private ReadOnly _spriteBatch As SpriteBatch
    Private ReadOnly _scale As Integer = 4

    Public Sub New(textureManager As ITextureManager(Of TextureIdentifier), spriteManager As ISpriteManager(Of SpriteIdentifier), hues As Dictionary(Of HueIdentifier, Color), spriteBatch As SpriteBatch)
        _textureManager = textureManager
        _spriteBatch = spriteBatch
        _spriteManager = spriteManager
        _hues = hues
    End Sub

    Public Sub Draw(spriteIdentifier As SpriteIdentifier, position As XY(Of Integer), hueIdentifier As HueIdentifier) Implements ISpriteRenderer(Of SpriteIdentifier, HueIdentifier).Draw
        Dim sprite = DirectCast(_spriteManager.GetSprite(spriteIdentifier), Sprite(Of TextureIdentifier))
        Dim texture = _textureManager.GetTexture(sprite.TextureIdentifier)
        Dim sourceRectangle As New Rectangle(sprite.Source.X, sprite.Source.Y, CInt(sprite.Size.X), CInt(sprite.Size.Y))
        Dim destinationRectangle As New Rectangle((position.X + sprite.Offset.X) * _scale, (position.Y + sprite.Offset.Y) * _scale, CInt(sprite.Size.X * _scale), CInt(sprite.Size.Y * _scale))
        _spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, _hues(hueIdentifier))
    End Sub
End Class
