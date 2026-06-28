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

    public bool IsHidden() // returns the state of _isHidden
    {
        return _isHidden; 
    }

    public string GetDisplayText() // Dispay text unless _isHidden is true 
    {
        if (_isHidden == true)
        {
            string hiddenword = "";

            for (int i = 0; i < _text.Length; i++) // return underscores for each letter in the length of the word 
            {
                hiddenword += "_"; 
            }

            return hiddenword; 
        }
        else
        {
            return _text; // display word normal if _isHidden is false 
        }
    }
}