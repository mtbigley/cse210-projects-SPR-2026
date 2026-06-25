using System;

public class Fraction
{
    private int _top; // initialize top private
    private int _bottom; // initialize bottom private

    public Fraction() // constructor to set default to 1/1
    {
        _top = 1;
        _bottom = 1; 
    }

    public Fraction(int input_top) // One parameter for top and initializes denominator to 1
    {
        _top = input_top;
        _bottom = 1;
    }

    public Fraction(int input_top, int input_bottom) // two parameters, one for top and bottom
    {
        _top = input_top;
        _bottom = input_bottom;
    }

    public int GetFractionBottom() // get fraction bottom int
    {
        int denominator = _bottom;

        return denominator; 
    } 

    public int GetFractionTop() // get fraction top int
    {
        int numerator = _top; 

        return numerator; 
    }

    public void SetFractionBottom(int bottom) // set fraction bottom
    {
        _bottom = bottom;
    }

    public void SetFractionTop(int top) // set fraction top 
    {
        _top = top; 
    }

    public string GetFractionString() // retrieve fraction into string 
    {
        string fractionString = $"{_top}/{_bottom}"; 

        return fractionString; 
    }

    public double GetDecimalValue() // convert current fraction into decimal form
    {
        double DecValue = _top / _bottom; 

        return DecValue; 
    }
}