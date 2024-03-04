List<string> personList = new List<string>();

//taking user input for message display
while (true)
{
    Console.WriteLine("Please enter name or Press enter without any name to finish ");
    string inputName = Console.ReadLine().Trim();

    if (string.IsNullOrWhiteSpace(inputName))
        break;

    personList.Add(inputName);
}
if(personList.Count > 0)
GenerateLikeNotificationMessage(personList);

//Provide appropriate name according to person count
void GenerateLikeNotificationMessage(List<string> userNameList)
{
    switch (userNameList.Count)
    {
        case 1:
            Console.WriteLine($"{userNameList[0]} likes your post");
            break;
        case 2:
            Console.WriteLine($"{userNameList[0]} and {userNameList[1]} like your post");
            break;
        default:
            Console.WriteLine($"{userNameList[0]}, {userNameList[1]} and {userNameList.Count - 2} others like your post");
            break;
    }
}