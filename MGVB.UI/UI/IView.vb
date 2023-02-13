Public Interface IView(Of TSpriteIdentifier, THueIdentifier, TCommand)
    Function OnCommand(command As TCommand) As CommandResult
    Sub OnUpdate(elapsed As TimeSpan)
    Sub OnDraw(spriteRenderer As ISpriteRenderer(Of TSpriteIdentifier, THueIdentifier))
End Interface
