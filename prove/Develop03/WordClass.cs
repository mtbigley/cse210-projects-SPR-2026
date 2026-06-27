using System; 

public class Word
{
    private string _text; // string with the word
    private bool _isHidden; // boolean for if the word is hidden or not

    public Word(string text) // Constructor setting default _isHidden value to false for initial display state
    {
        _text = text; 
        _isHidden = false; 
    }

    public void Hide() // Hide word function
    {
        _isHidden = true; // literally just hides the word when called
    }

    public void Show() // Show word 
    {
        _isHidden = false; 
    }

}