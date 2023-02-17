Friend Module Grammar
    Friend ValidSentences As IReadOnlyList(Of (VerbIdentifier, NounIdentifier?)) =
        New List(Of (VerbIdentifier, NounIdentifier?)) From
        {
            (VerbIdentifier.North, Nothing),
            (VerbIdentifier.South, Nothing),
            (VerbIdentifier.East, Nothing),
            (VerbIdentifier.West, Nothing),
            (VerbIdentifier.Up, Nothing),
            (VerbIdentifier.Down, Nothing)
        }
End Module
