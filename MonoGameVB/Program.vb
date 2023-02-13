Module Program
    <STAThread>
    Sub Main(args As String())
        Using presenter As New Presenter()
            presenter.Run()
        End Using
    End Sub
End Module

