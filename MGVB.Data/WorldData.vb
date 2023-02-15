Public Class WorldData
    Public Property Rooms As New Dictionary(Of RoomIdentifier, RoomData)
    Public Property Nouns As New Dictionary(Of NounIdentifier, String)
    Public Property Verbs As New Dictionary(Of VerbIdentifier, String)
    Public Property Objects As New Dictionary(Of ObjectIdentifier, ObjectData)
End Class
