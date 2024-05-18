//bool IsPathCrossing(string path)
//{
//    List<Tuple<int, int>> positions = new List<Tuple<int, int>>();
//    int x = 0;
//    int y = 0;
//    positions.Add(new Tuple<int, int>(x, y));

//    foreach (char direction in path)
//    {
//        if (direction == 'N')
//        {
//            y += 1;
//        }
//        if (direction == 'S')
//        {
//            y -= 1;
//        }
//        if (direction == 'E')
//        {
//            x += 1;
//        }
//        if (direction == 'W')
//        {
//            x -= 1;
//        }

//        Tuple<int, int> newPosition = new Tuple<int, int>(x, y);
//        if (positions.Contains(newPosition))
//        {
//            return true;
//        }
//        positions.Add(newPosition);
//    }
//    return false;
//}
//Console.WriteLine(IsPathCrossing("NES"));

//var person = (Name: "John", Age: 30);
//Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");


//var people = new List<(string Name, int Age)>
//{
//    ("John", 30),
//    ("Jane", 25),
//    ("Jake", 35)
//};

//var result = people.Where(p => p.Age > 25)
//             .Select(p => (p.Name, p.Age)).ToList();

//foreach (var person in result)
//{
//    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//}

//(int Sum, int Difference) Calculate(int a, int b)
//{
//    return (a + b, a - b);
//}

//var result = Calculate(10, 5);
//Console.WriteLine($"Sum: {result.Sum}, Difference: {result.Difference}");


//public readonly struct ImmutablePoint
//{
//    public int X { get; }
//    public int Y { get; }

//    public ImmutablePoint(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public ImmutablePoint Move(int deltaX, int deltaY)
//    {
//        return new ImmutablePoint(X + deltaX, Y + deltaY);
//    }
 
//    public override string ToString() => $"({X}, {Y})";
//}

//public class Program
//{
//    public static void Main()
//    {
//        // начальная точка
//        ImmutablePoint point = new ImmutablePoint(3, 4);
//        Console.WriteLine("Initial Point: " + point);

//        // Перемещение точки
//        ImmutablePoint movedPoint = point.Move(5, -2);
//        Console.WriteLine("Moved Point: " + movedPoint);

//        // Демонстрация неизменяемости
//        Console.WriteLine(" Point after Move: " + point);
//    }
//}
