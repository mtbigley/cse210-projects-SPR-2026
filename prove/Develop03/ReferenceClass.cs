using System; 

public class Reference
{
    private string _book; // e.g. mosiah, mark, D&C, etc
    private int _chapter; // Chapter number
    private int _verse; // Verse number
    private int _endVerse; // End verse number

    public Reference(string book, int chapter, int verse) // single verse constructor
    {
        // input and store book, chapter, verse
        _book = book; 
        _chapter = chapter; 
        _verse = verse; 
        _endVerse = 0; // set value to 0 since this is the single verse constructor
    }

    public Reference(string book, int chapter, int verse, int endVerse) // multiple verse constructor
    {
        // same inputs with the addition of endverse
        _book = book; 
        _chapter = chapter; 
        _verse = verse; 
        _endVerse = endVerse; 
    }

    public string GetDisplayText() // display reference formatted
    {
        if (_endVerse == 0) // if ingle verse
        {
            return $"{_book} {_chapter}:{_verse}"; 
        }
        else // if endverse has a nonzero value 
        {
            return $"{_book} {_chapter}:{_verse}:{_endVerse}"; 
        }
    }
}