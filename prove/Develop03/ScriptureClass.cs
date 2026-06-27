using System; 
using System.Collections.Generic; 
public class Scripture()
{
    private List<Word> _words; // list of Word classes each with their own hidden/not hidden attributes. 
    private Reference _reference; // initialize reference class designed to contain book chapter and verse. 

    public Scripture() // constructor default placeholder scripture 
    {
        reference = " ooblar";
        scriptureText = "ooblar"; 
    }
    
}