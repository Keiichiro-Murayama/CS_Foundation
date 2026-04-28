namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string[] stations = 
        {
            "品川",
            "大崎",
            "五反田",
            "目黒",
            "恵比寿",
            "渋谷",
            "原宿",
            "代々木",
            "新宿"
        };

        System.Console.Write("駅名を入力してください->");
        var input = Console.ReadLine();
            
        foreach (var station in stations)
        {
            if (station == input)
            {
             continue;   
            }
            System.Console.WriteLine(station);
        }
    }
}
