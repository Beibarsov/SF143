//  создаём пустой список с типом данных Contact
var phoneBook = new List<Contact>();

// добавляем контакты
phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));


var phoneBookSorted = phoneBook.OrderBy(x => x.Name).ThenBy(x => x.LastName);

while (true)
{
    var Keychar = Console.ReadKey().KeyChar.ToString();
    Console.Clear();
    int numPage;
    if (!int.TryParse(Keychar, out numPage))
    {
        Console.WriteLine("Нажата не цифра");
        continue;
    };

    var result = phoneBookSorted.Skip(numPage * 2 - 2).Take(2);
    if (result.Count() == 0)
    {
        Console.WriteLine("Такой страницы не существует");
        continue;
    }

    foreach (var item in result)
    {
        Console.WriteLine($"имя и фамилия: {item.Name} {item.LastName}, телефон: {item.PhoneNumber}");
    }

}