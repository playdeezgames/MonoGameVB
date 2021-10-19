Imports Common

Public Class Sprite(Of TTextureIdentifier)
    Implements ISprite
    Private ReadOnly _textureIdentifier As TTextureIdentifier
    Private ReadOnly _source As XY(Of Integer)
    Private ReadOnly _size As XY(Of UInteger)
    Private ReadOnly _offset As XY(Of Integer)

    Public Sub New(
            TextureIdentifier As TTextureIdentifier,
            Source As XY(Of Integer),
            size As XY(Of UInteger),
            offset As XY(Of Integer))
        _textureIdentifier = TextureIdentifier
        _source = Source
        _size = size
        _offset = offset
    End Sub

    Public ReadOnly Property TextureIdentifier As TTextureIdentifier
        Get
            Return _textureIdentifier
        End Get
    End Property

    Public ReadOnly Property Source As XY(Of Integer) Implements ISprite.Source
        Get
            Return _source
        End Get
    End Property

    Public ReadOnly Property Size As XY(Of UInteger) Implements ISprite.Size
        Get
            Return _size
        End Get
    End Property

    Public ReadOnly Property Offset As XY(Of Integer) Implements ISprite.Offset
        Get
            Return _offset
        End Get
    End Property
End Class
