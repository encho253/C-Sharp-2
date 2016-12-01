using System;
using System.Text;

/// <summary>
/// Write a program that parses an URL address given in the format:
/// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
/// </summary>
class ParseURL
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string urlAdress = Console.ReadLine();
        SplitProtocolServerResource(urlAdress);
    }
    /// <summary>
    /// Splits the protocol server resource.
    /// </summary>
    /// <param name="urlAddress">The URL address.</param>
    static void SplitProtocolServerResource(string urlAddress)
    {
        StringBuilder builder = new StringBuilder();

        int http = urlAddress.IndexOf("://");
        int server = urlAddress.IndexOf("/",(http + 3));
        int resource = urlAddress.IndexOf("/",server - 1);
        char[] arr = urlAddress.ToCharArray();

        for (int i = 0; i < urlAddress.Length; i++)
        {
            builder.Append(urlAddress[i]);

            if (i == http - 1)
            {
                Console.WriteLine("[protocol] = {0}",builder.ToString());
                builder.Clear();
                i += 3;
            }
            else if (i == server - 1)
            {
                Console.WriteLine("[server] = {0}", builder.ToString());
                builder.Clear();
            }
            else if (i == urlAddress.Length - 1)
            {
                Console.WriteLine("[resource] = {0}", builder.ToString());
                builder.Clear();
            }
        }
    }
}