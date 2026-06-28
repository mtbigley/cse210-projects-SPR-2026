using System; 
using System.Collections.Generic; 
public class Scripture
{
    private List<Word> _words; // list of Word classes each with their own hidden/not hidden attributes. 
    private Reference _reference; // initialize reference class designed to contain book chapter and verse. 

    public Scripture(Reference reference, string scriptureText) // default constructor
    {
        _reference = reference; // store the reference class into a variable

        _words = new List<Word>(); // initialize list to store word objects

        string[] words = scriptureText.Split(" "); // just learned about the .split method in c# this is super handy-- splits string into words and stores them in the list separated by spaces

        foreach (string currentWord in words) // Pass each split word string into the Word class
        {
            Word newWord = new Word(currentWord); 

            _words.Add(newWord); 
        }
    }

    public string GetDisplayText()
    {
        string displayText = ""; // initialize display string

        displayText += _reference.GetDisplayText(); // add reference text and space
        displayText += " "; 

        foreach (Word word in _words) // add words and spaces to displaytext string 
        {
            displayText += word.GetDisplayText(); 
            displayText += " ";
        }

        return displayText; // return final display text 
    }

    public void HideRandomWords() // hides 3 random words
    {
        Random random = new Random(); // generate random numebr

        for (int i = 0; i < 3; i++) // hide randomly selected word using generated number
        {
            int randomNumber = random.Next(_words.Count); 

            _words[randomNumber].Hide(); 
        }
    }

    public bool IsCompletelyHidden() // true if every word is hid
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) // if a word is visible return false
            {
                return false; 
            }
        }
    return true; 
    }
    
}