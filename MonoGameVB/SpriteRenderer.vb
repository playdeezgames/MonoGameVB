Imports Common
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class SpriteRenderer
    Implements ISpriteRenderer(Of SpriteIdentifier, HueIdentifier)

    Private _textureManager As ITextureManager(Of TextureIdentifier)
    Private _spriteManager As ISpriteManager(Of SpriteIdentifier, TextureIdentifier)
    Private _hues As Dictionary(Of HueIdentifier, Color)
    Private _spriteBatch As SpriteBatch
    Private _scale As Integer = 4

    Public Sub New(textureManager As ITextureManager(Of TextureIdentifier), spriteManager As ISpriteManager(Of SpriteIdentifier, TextureIdentifier), hues As Dictionary(Of HueIdentifier, Color), spriteBatch As SpriteBatch)
        _textureManager = textureManager
        _spriteBatch = spriteBatch
        _spriteManager = spriteManager
        _hues = hues
    End Sub

    Public Sub Draw(spriteIdentifier As SpriteIdentifier, position As XY(Of Integer), hueIdentifier As HueIdentifier) Implements ISpriteRenderer(Of SpriteIdentifier, HueIdentifier).Draw
        Dim sprite = _spriteManager.GetSprite(spriteIdentifier)
        Dim texture = _textureManager.GetTexture(sprite.TextureIdentifier)
        Dim sourceRectangle As New Rectangle(sprite.Source.X, sprite.Source.Y, sprite.Size.X, sprite.Size.Y)
        Dim destinationRectangle As New Rectangle((position.X + sprite.Offset.X) * _scale, (position.Y + sprite.Offset.Y) * _scale, sprite.Size.X * _scale, sprite.Size.Y * _scale)
        _spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, _hues(hueIdentifier))
    End Sub
End Class
