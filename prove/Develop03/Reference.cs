using System;
public class Reference
{
    private string _book = "Alma";
    private string _chapter = " 26:";
    private string _verse = "27";

    private string GetFullReference()
    {
        return _book + _chapter + _verse;
    }

    public string FormalReference()
    {
        return GetFullReference();

    }
}