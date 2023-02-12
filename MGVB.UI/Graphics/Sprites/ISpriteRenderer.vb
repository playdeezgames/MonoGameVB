Public Interface ISpriteRenderer(
                   Of TSpriteIdentifier,
                       THueIdentifier)
    Sub Draw(
            spriteIdentifier As TSpriteIdentifier,
            position As XY(Of Integer),
            hueIdentifier As THueIdentifier)
End Interface
