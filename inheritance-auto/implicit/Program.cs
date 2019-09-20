using System;
using static System.Console;

public class Example
{
   public static void Main()
   {
      var book = new Book("The Tempest",  "0971655819", "Shakespeare, William",
                          "Public Domain Press");
      ShowPublicationInfo(book);
      book.Publish(new DateTime(2016, 8, 18));
      ShowPublicationInfo(book);

      var book2 = new Book("The Tempest", "Classic Works Press", "Shakespeare, William");
      Write($"{book.Title} and {book2.Title} are the same publication: " +
            $"{((Publication) book).Equals(book2)}");
   }

   public static void ShowPublicationInfo(Publication pub)
   {
       string pubDate = pub.GetPublicationDate();
       WriteLine($"{pub.Title}, " +
                 $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}"); 
   }
}
// The example displays the following output:
//        The Tempest, Not Yet Published by Public Domain Press
//        The Tempest, published on 8/18/2016 by Public Domain Press
//        The Tempest and The Tempest are the same publication: False