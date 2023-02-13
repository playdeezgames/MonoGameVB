Friend Module KeyCommands
    Friend ReadOnly CommandsTable As New Dictionary(Of Keys, Command) From
        {
            {Keys.F4, Command.BACK},
            {Keys.F2, Command.START},
            {Keys.Up, Command.UP},
            {Keys.Down, Command.DOWN},
            {Keys.Left, Command.LEFT},
            {Keys.Right, Command.RIGHT},
            {Keys.Escape, Command.RED},
            {Keys.Space, Command.GREEN},
            {Keys.Enter, Command.BLUE},
            {Keys.Tab, Command.YELLOW},
            {Keys.OemPeriod, Command.NEXT},
            {Keys.OemComma, Command.PREVIOUS}
        }
End Module
