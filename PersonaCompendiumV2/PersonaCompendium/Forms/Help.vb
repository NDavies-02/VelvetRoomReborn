Public Class Help
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.Text = "Compendium
View All - Done
This, like the view all books in the library program, will be a simple list box, calling items from the simple All Personas text file – no arcana’s.
Arcana Search
Search the main text file for personas with a specified arcana – import the file into an array (x,y) and say y was the Arcana, the results would be all the x values at all positions with matching y.
Register Personas
This is a dummy feature, simply showing a message box, and another one if confirmed.
 
Fusion
Basic
Let the user enter 2 personas, and generate an output based on this. For initial implementation, get a random persona (the random persona should be a function in possibly module 1 for reuse around the program, by generating a random number, and selecting a persona from the array generated from the text file – once again, see library program).

Advanced
Probably wont implement this. Show a message box in its place for now.
Strengthen
Probably will not implement this till later. Show a message box in its place for now.
This requires the sacrifice of a persona, following the initial persona selection. Could, for simplicity, copy the basic fusion, but instead of outputting a new persona, output a new message box saying they have levelled up their persona.
For now, changes will not be saved to the persona text file.
Itemize
Turns one persona into an item, such as a random skill card
Network - Done
Allow the user to input the name of any persona. Ignore the input and choose a random Persona from the array.

Any
Re-use a getrandompersona method.
Info tab
Simply shows about box, update details as see fit.
Config
Reset App
Regenerates the initial text files and settings for the applications config.
Help and Support
Show basic assistance, recent changelogs and if distributed, contact details.

GitHub: github.com/nathandavies386"

    End Sub
End Class