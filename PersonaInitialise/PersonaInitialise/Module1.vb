Imports System.IO
Module Module1
    Public Structure Personas
        Public Arcana As String '10
        Public PersonaName As String '25
    End Structure

    Public PersonaArray(200) As Personas
    Const Max = 200
    Public count As Integer

    Sub LoadPersonasFromFile(ByVal filename As String)
        'read from file "Library.txt" in the same sequence and the writing
        ' and store each record in the array BookArray()
        Dim AllPersonas() As String = File.ReadAllLines(Dir$(filename))
        count = 0 'keeps track of how many records are read from file
        For I = 1 To UBound(AllPersonas)
            PersonaArray(I).PersonaName = Trim(Mid(AllPersonas(I), 1, 9))
            '### read the other parts of the string into the structure:
            PersonaArray(I).Arcana = Trim(Mid(AllPersonas(I), 10, 29))

            '### increment count by 1 to keep track of number of lines in file:
            count = count + 1
        Next I
    End Sub
    Sub createNewFile()
        If Dir$("Personas.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Personas.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            MsgBox("A new compendium has been created", vbExclamation, "Warning!")
            'IDEA: Write one persona to the file to begin with, perferably with arcana type. Then, edit the textfile in
            '... the debug folder with all the personas. OR, use this program,Persona Initialise
            'and create an input form - see LibraryFileHandling program and Library Records program, upon which this program is based on. 'This will be a github project
            'BTW, add portfolio updates, and blog about it... (open source the program?)

        End If
    End Sub
    Sub viewAllBooks(ByVal myListbox As ListBox)
        myListbox.Items.Clear()
        For x = 1 To count ' count represents how many records were read from file
            myListbox.Items.Add(PersonaArray(x).PersonaName)
        Next
    End Sub

    Sub writeToFile(ByVal arcana As String, ByVal personaname As String)

        Dim PersonaData As New Personas
        Dim sw As New System.IO.StreamWriter(Dir$("Personas.txt"), True)
        PersonaData.Arcana = LSet(arcana, 10)
        PersonaData.PersonaName = LSet(personaname, 20)
        sw.WriteLine(PersonaData.Arcana & PersonaData.PersonaName)
        sw.Close()
        '###display using a message box that the record has been saved successfully
        MsgBox("Record saved successfully")
    End Sub

    Sub SetPersona()
        Dim Persona As String
        Dim Personas(218) As String
        Dim count1 As Integer
        Dim sr As New StreamReader("Personas.txt")
        For count1 = 1 To 217
            Persona = sr.ReadLine()
            Personas(count1) = Persona
        Next
    End Sub
    Sub SetArcana()
        Dim Arcana As String
        Dim Arcanas(20) As String
        Dim count2 As Integer
        Dim sr As New StreamReader("Personas.txt")
        For count2 = 1 To 20
            Arcana = sr.ReadLine()
            Arcanas(count2) = Arcana
        Next
    End Sub
End Module
