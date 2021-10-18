Module Sprites
    Friend ReadOnly SpriteSources As New Dictionary(Of SpriteIdentifier, ISprite) From
        {
            {SpriteIdentifier.BACKGROUND, New Sprite(Of TextureIdentifier)(TextureIdentifier.BACKGROUND, New XY(Of Integer)(0, 0), New XY(Of UInteger)(1280, 720), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_00, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(0, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_01, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(8, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_02, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(16, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_03, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(24, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_04, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(32, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_05, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(40, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_06, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(48, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_07, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(56, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_08, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(64, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_09, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(72, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_0A, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(80, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_0B, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(88, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_0C, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(96, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_0D, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(104, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_0E, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(112, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))},
            {SpriteIdentifier.CHARACTER_0F, New Sprite(Of TextureIdentifier)(TextureIdentifier.ROM_FONT_8X8, New XY(Of Integer)(120, 0), New XY(Of UInteger)(8, 8), New XY(Of Integer)(0, 0))}
        }
End Module
