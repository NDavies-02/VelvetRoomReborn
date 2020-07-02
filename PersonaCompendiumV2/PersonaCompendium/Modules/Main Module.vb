Imports System.IO
Module Module1
    Public Structure PersonasNoArcana 'for use with Persona text file - no Arcanas
        Public Persona As String '20
        Public Arcana As String '10
    End Structure
    Public PersonaArray As String()
    Public count As Integer

    Public Structure PersonaswArcana
        Public Persona As String '20
        Public Arcana As String '10
    End Structure
    Public SortedPersonaArray(200) As PersonaswArcana
    'Const Max2 = 200 CURRENTLY UNUSED
    Public count2 As Integer

    Sub Main()
    End Sub

    Sub LoadPersonas()
        Dim noArcResource As String = My.Resources.PersonasNoArcana
        PersonaArray = noArcResource.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
    End Sub

    Sub ViewAllPersonas(ByVal myListbox As ListBox)
        LoadPersonas()
        myListbox.Items.Clear()
        Try
            For x = 0 To PersonaArray.Length
                myListbox.Items.Add(PersonaArray(x))
            Next
        Catch e As System.IndexOutOfRangeException
        End Try
    End Sub

    Function GetRandomPersona()
        LoadPersonas()
        Dim randomno As Integer
        Dim randomPersona As String
choosePersona: randomno = CInt(Int((200 * Rnd()) + 1))
            Try
            randomPersona = PersonaArray(randomno)
            If randomPersona = "" Then
                GoTo choosePersona
            End If
            Return randomPersona
        Catch f As System.IndexOutOfRangeException
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

End Module

