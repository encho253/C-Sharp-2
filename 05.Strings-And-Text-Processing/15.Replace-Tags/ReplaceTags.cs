using System;
using System.Text;

/// <summary>
/// Write a program that replaces in a HTML document given as string all the tags
/// <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).
/// https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Topics/06.%20Strings-and-Text-Processing/homework/15.%20Replace%20tags
/// </summary>
class ReplaceTags
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string text = Console.ReadLine();
        string finalText = ReplaceTagsInHTML(text);
        Console.WriteLine(finalText);
    }
    /// <summary>
    /// Replaces the tags in HTML.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    static string ReplaceTagsInHTML(string text)
    {
        int startPosition = text.IndexOf("<a href=");
        int nameSitePosition = 0;
        int endNameSitePosition = 0;
        string siteName = null;
        string linkName = null;
        int newBuilder = 0;
     
        StringBuilder builder = new StringBuilder();
        StringBuilder finalBuilder = new StringBuilder();

        while (true)
        {
            if (text.IndexOf("<a href=", startPosition) != -1)
            {
                startPosition = text.IndexOf("<a href=",startPosition) + 9;
                nameSitePosition = text.IndexOf("\">", startPosition);
                endNameSitePosition = text.IndexOf("</a>",startPosition);
              
                for (int i = nameSitePosition + 2; i < endNameSitePosition ; i++)
                {
                   builder.Append(text[i]);
                }
                siteName = builder.ToString();
                builder.Clear();

                for (int i = startPosition; i < nameSitePosition; i++)
                {
                    builder.Append(text[i]);
                }
                linkName = builder.ToString();
                builder.Clear();

                for (int i = newBuilder; i < text.Length; i++)
                {
                    if (i == startPosition - 9)
                    {
                        builder.Append("[").Append(siteName).Append("]").Append("(").Append(linkName).Append(")");
                        newBuilder = endNameSitePosition + 4;
                        startPosition = newBuilder;
                        i = newBuilder;

                        if (text.IndexOf("<a href=", startPosition) != -1)
                        {                           
                            break;
                        }
                        else
                        {
                            i--;
                            continue;
                        }                                          
                    }                 
                    else
                    {
                        builder.Append(text[i]);
                    }
                }
                finalBuilder.Append(builder.ToString());
                builder.Clear();
            }
            else
            {
                break;
            }                      
        }
        return finalBuilder.ToString();
    }
}