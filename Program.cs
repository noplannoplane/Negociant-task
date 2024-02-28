using System;
using System.Collections.Generic;
using System.Linq;

public class Flag
{
    public string Country { get; set; }
    public List<string> Colors { get; set; }
    public List<string> Patterns { get; set; }
    public string DominantLineDirection { get; set; }
    public bool HasCross { get; set; }
    public bool HasTriangles { get; set; }
    public bool HasCrescent { get; set; }
    public bool HasText { get; set; }
    public string AdditionalInfo { get; set; }

    public Flag(string country, List<string> colors, List<string> patterns, string lineDirection,
                bool hasCross, bool hasTriangles, bool hasCrescent, bool hasText, string additionalInfo)
    {
        Country = country;
        Colors = colors;
        Patterns = patterns;
        DominantLineDirection = lineDirection;
        HasCross = hasCross;
        HasTriangles = hasTriangles;
        HasCrescent = hasCrescent;
        HasText = hasText;
        AdditionalInfo = additionalInfo;
    }
}

class Program
{
    static void Main()
    {
        List<Flag> flags = new List<Flag>()
        {
            new Flag("Russia", new List<string> { "white", "blue", "red" }, new List<string> { "horizontal lines" },
                     "horizontal", false, false, false, true, "Capital: Moscow, Year of Adoption: 1993"),
            new Flag("USA", new List<string> { "red", "blue", "white" }, new List<string>(), "horizontal",
                     true, false, false, false, "Capital: Washington D.C., Year of Adoption: 1777"),
            new Flag("France", new List<string> { "blue", "white", "red" }, new List<string> { "tricolor" },
                     "horizontal", false, false, false, false, "Capital: Paris, Year of Adoption: 1794"),
            new Flag("China", new List<string> { "red", "yellow" }, new List<string> { "5 stars" },
                     "horizontal", false, false, false, false, "Capital: Beijing, Year of Adoption: 1949"),
            new Flag("Brazil", new List<string> { "green", "yellow" }, new List<string> { "starry sky" },
                     "horizontal", false, false, false, false, "Capital: Brasília, Year of Adoption: 1889"),
            new Flag("India", new List<string> { "orange", "white", "green" }, new List<string> { "spinning wheel" },
                     "horizontal", false, false, false, false, "Capital: New Delhi, Year of Adoption: 1947"),
            new Flag("United Kingdom", new List<string> { "blue", "white", "red" }, new List<string> { "Union Jack" },
                     "diagonal", true, false, false, true, "Capital: London, Year of Adoption: 1801"),
            new Flag("Germany", new List<string> { "black", "red", "gold" }, new List<string> { "horizontal stripes" },
                     "horizontal", false, false, false, false, "Capital: Berlin, Year of Adoption: 1919"),
            new Flag("Japan", new List<string> { "white", "red" }, new List<string> { "red circle" },
                     "none", false, false, false, false, "Capital: Tokyo, Year of Adoption: 1999"),
            new Flag("Canada", new List<string> { "red", "white" }, new List<string> { "red maple leaf" },
                     "none", false, false, false, false, "Capital: Ottawa, Year of Adoption: 1965"),
            new Flag("Australia", new List<string> { "blue", "white", "red" }, new List<string> { "Commonwealth Star" },
                     "none", false, false, false, false, "Capital: Canberra, Year of Adoption: 1908"),
            new Flag("South Korea", new List<string> { "white", "red", "blue" }, new List<string> { "Yin Yang symbol" },
                     "diagonal", false, false, false, false, "Capital: Seoul, Year of Adoption: 1883"),
            new Flag("Mexico", new List<string> { "green", "white", "red" }, new List<string> { "eagle and snake" },
                     "none", false, false, false, true, "Capital: Mexico City, Year of Adoption: 1968"),
            new Flag("South Africa", new List<string> { "black", "green", "yellow", "white" }, new List<string> { "Y-shape" },
                     "none", false, false, false, true, "Capital: Pretoria, Year of Adoption: 1994"),
            new Flag("Thailand", new List<string> { "red", "white", "blue" }, new List<string> { "5 horizontal stripes" },
                     "horizontal", false, false, false, true, "Capital: Bangkok, Year of Adoption: 1917"),
            new Flag("Sweden", new List<string> { "blue", "yellow" }, new List<string> { "scandinavian cross" },
                     "none", true, false, false, false, "Capital: Stockholm, Year of Adoption: 1906"),
            new Flag("Italy", new List<string> { "green", "white", "red" }, new List<string> { "tricolor" },
                     "vertical", false, false, false, true, "Capital: Rome, Year of Adoption: 1946"),
            new Flag("Turkey", new List<string> { "red", "white" }, new List<string> { "moon and star" },
                     "none", false, false, true, true, "Capital: Ankara, Year of Adoption: 1844"),
            new Flag("Argentina", new List<string> { "blue", "white" }, new List<string> { "sun of May" },
                     "horizontal", false, false, false, false, "Capital: Buenos Aires, Year of Adoption: 1818"),
            new Flag("Netherlands", new List<string> { "red", "white", "blue" }, new List<string> { "tricolor" },
                     "horizontal", false, false, false, false, "Capital: Amsterdam, Year of Adoption: 1937")
        };

        var filteredFlags = flags.Where(flag => flag.Colors.Contains("red") && flag.HasCross);

        Console.WriteLine("Флаги, где присутствует красный цвет и крест:");
        foreach (var flag in filteredFlags)
        {
            Console.WriteLine($"Страна: {flag.Country}");
            Console.WriteLine($"Дополнительная информация: {flag.AdditionalInfo}");
            Console.WriteLine();
        }
    }
}