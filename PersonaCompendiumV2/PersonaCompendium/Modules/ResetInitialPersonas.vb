Imports System.IO
Module ResetInitialPersonas
    Sub Reset()
        If Dir$("Personas.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Personas.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            MsgBox("A new compendium has been created", vbExclamation, "Warning!")
            'IDEA: Write one persona to the file to begin with, perferably with arcana type. Then, edit the textfile in
            '... the debug folder with all the personas. OR, use this program,Persona Initialise
            'and create an input form - see LibraryFileHandling program and Library Records program, upon which this program is based on. 'This will be a github project
            'BTW, add portfolio updates, and blog about it... (open source the program?)

        End If
    End Sub

    Sub WriteAllPersonas()
        'code to write names of personas and their arcanas
    End Sub
End Module

