/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 9
 */

/* Спроектируйте и сериализуйте класс «Склад» с элементом
 * «Корпус» с усложненными элементами «Инструменты», «Материалы»,
 * «Электрические компоненты». В каждый элемент входит элемент 
 * «наименование» с элементами масса, габариты, количество.
 */

using System.Xml.Serialization;

// Класс "Склад"
public class Warehouse
{
    // Корпус
    public string body { set; get; } = "Untitled";
    // Инструменты
    public Appellation[] tools { set; get; } = new Appellation[0];
    // Материалы
    public Appellation[] materials { set; get; } = new Appellation[0];
    // Электрические компоненты
    public Appellation[] electrical_components { set; get; } = new Appellation[0];

    // Конструктор по умолчанию
    public Warehouse() { }

    // Конструктор с параметрами
    public Warehouse(string body, Appellation[] tools, Appellation[] materials, Appellation[] electrical_components)
    {
        this.body = body;
        this.tools = tools;
        this.materials = materials;
        this.electrical_components = electrical_components;
    }
}

// Класс Наименования
public class Appellation
{
    // Название (Логически будет непонятно, что за масса или габариты без названия)
    public string name { set; get; } = "Not specified";
    // Масса
    public int weight { set; get; } = 1;
    // Габариты (Высота, ширина, длина)
    public string dimensions { set; get; } = "1x1x1";
    // Количество
    public int quantity { set; get; } = 1;

    // Конструктор по умолчанию
    public Appellation() { }

    // Конструктор с параметрами
    public Appellation(string name, int weight, string dimensions, int quantity)
    {
        this.name = name;
        this.weight = weight;
        this.dimensions = dimensions;
        this.quantity = quantity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(90, 35);
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        // Создание объектов класса "Наименование"
        var tool1 = new Appellation("Лопата штыковая", 2, "1500х230х170", 2);
        var tool2 = new Appellation("Лопата совковая", 2, "1400х230х170", 4);
        var tool3 = new Appellation("Топор", 1, "178x92x49", 11);
        var material1 = new Appellation("Алюминий волнистый", 940, "32x6x0,3", 110);
        var material2 = new Appellation("Сталь волнистая", 9600, "1x100x30", 74);
        var electrical_component1 = new Appellation("Кабель на основе витой пары", 1000, "390x230x410", 305);
        var electrical_component2 = new Appellation("Коммутационный шнур", 7600, "400x400x260 ", 200);
        var electrical_component3 = new Appellation("Коммутационная панель", 1090, "520x410x240 ", 12);

        // Создание объектов класса "Склад"
        Warehouse[] WareHouse = new Warehouse[]
        {
            new Warehouse("А", new Appellation[]{tool1,tool2}, new Appellation[]{material1,material2}, new Appellation[]{electrical_component1}),
            new Warehouse("Б1", new Appellation[]{tool2}, new Appellation[]{material1}, new Appellation[]{electrical_component1}),
            new Warehouse("Б2", new Appellation[]{tool3}, new Appellation[]{material2}, new Appellation[]{electrical_component2,electrical_component3})
        };

        XmlSerializer formatter = new XmlSerializer(typeof(Warehouse[]));
        using (FileStream fs = new FileStream("warehouses.xml", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, WareHouse);
        }

        using (FileStream fs = new FileStream("warehouses.xml", FileMode.OpenOrCreate))
        {
            Warehouse[] newWarehouse = formatter.Deserialize(fs) as Warehouse[];
            if (newWarehouse != null)
            {
                foreach (Warehouse warehouse in newWarehouse)
                {
                    Console.WriteLine($"\nКорпус: {warehouse.body}");
                    Console.WriteLine("Инструменты:");
                    foreach (Appellation Appel in warehouse.tools)
                    {
                        Console.WriteLine($"\"{Appel.name}\", Вес: {Appel.weight} кг, Габариты: {Appel.dimensions} мм, Кол-во: {Appel.quantity} шт.");
                    }
                    Console.WriteLine("Материалы:");
                    foreach (Appellation Appel in warehouse.materials)
                    {
                        Console.WriteLine($"\"{Appel.name}\", Вес: {Appel.weight} гр/м, Габариты: {Appel.dimensions} мм, Кол-во: {Appel.quantity} шт.");
                    }
                    Console.WriteLine("Электрические компоненты:");
                    foreach (Appellation Appel in warehouse.electrical_components)
                    {
                        Console.WriteLine($"\"{Appel.name}\", Вес: {Appel.weight} гр, Габариты: {Appel.dimensions} мм, Кол-во: {Appel.quantity} шт.");
                    }
                }
            }
        }
        Console.ReadKey();
    }
}