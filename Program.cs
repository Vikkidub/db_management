using db_management;

Nav();
void Nav()
{
    while (true)
    {
        Console.WriteLine("1: Select");
        Console.WriteLine("2: Insert");
        Console.WriteLine("3: Delete");
        var input = Console.ReadLine();
        switch (input)
        {
            case "1":
                var select = new Select();
                select.Query();
                break;

            case "2":
                var insert = new Insert();
                insert.Query();
                break;

            case "3":
                var delete = new Delete();
                delete.Query();
                break;

            default:
                Nav();
                break;
        }
    }
}
