// See https://aka.ms/new-console-template for more information
Console.Write("Please enter few words separated by a space: ");
string userEnteredData = Console.ReadLine();


if (!string.IsNullOrWhiteSpace(userEnteredData))
{
    string pascalCaseVariable = "";
    string[] spaceSeparatedWords = userEnteredData.Split(' ');

   
    foreach (string str in spaceSeparatedWords)
    {
        pascalCaseVariable += GetPascalString(str);
    }

    Console.WriteLine("The representation of your string in PascalCase appears as : {0}", pascalCaseVariable);

    Console.ReadLine();
}
else
{
    Console.WriteLine("Please enter any text");
    return;
}

string GetPascalString(string userString)
{
    return (char.ToUpper(userString[0]) + userString.ToLower().Substring(1));
}