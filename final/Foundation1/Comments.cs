using System;

public class Comments
{
    public string nameUser;
    public string firstComment;
    public string secondComment;
    public string thirdComment;

    public void ShowFullComments()
    {
        Console.WriteLine($"\nUser: {nameUser}");
        Console.WriteLine($"Comments:\n\t1.{firstComment}\n\t2.{secondComment}\n\t3.{thirdComment}");
    }
}