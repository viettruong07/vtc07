using System;
public class LibraryItem
{
    public string Title;
    public string Author;
    public int PublicationYear;

    public override string ToString()
    {
        return "Type: Library Item\nTitle: " + Title + "\nAuthor: " + Author + "\nPublicationYear : " + PublicationYear +"\n";
    }
}

public class Book : LibraryItem
{
    public override string ToString()
    {
        return "Type: Book\nTitle: " + Title + "\nAuthor: " + Author + "\nPublicationYear : " + PublicationYear + "\n";
    }
}

public class Magazine : LibraryItem
{
    public override string ToString()
    {
        return "Type: Magazine\nTitle: " + Title + "\nAuthor: " + Author + "\nPublicationYear : " + PublicationYear +"\n";
        }
}

public class DVD : LibraryItem
{
        public override string ToString()
        {
            return "Type: DVD\nTitle: " + Title + "\nAuthor: " + Author + "\nPublicationYear : " + PublicationYear +"\n";
        }
}