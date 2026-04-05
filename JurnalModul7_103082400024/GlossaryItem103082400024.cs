using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class GlossaryTumbal
{
    [JsonPropertyName("glossary")]
    public Glossary Glossary { get; set; }
}

public class Glossary
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("GlossDiv")]
    public GlossDiv GlossDiv { get; set; }
}

public class GlossDiv
{
    [JsonPropertyName("Title")]
    public string Title { get; set; }

    [JsonPropertyName("GlossList")]
    public GlossList GlossList { get; set; }
}

public class GlossList
{
    [JsonPropertyName("GlossEntry")]
    public GlossEntry GlossEntry { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class GlossDef
{
    [JsonPropertyName("para")]
    public string Para { get; set; }

    [JsonPropertyName("GlossSeeAlso")]
    public List<string> GlossSeeAlso { get; set; }
}
public class GlossaryItem103082400024
{
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_3_103082400024.json");
        GlossaryTumbal data = JsonSerializer.Deserialize<GlossaryTumbal>(jsonString);
        var entry = data.Glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("HASIL PARSING GLOSSENTRY");
        Console.WriteLine($"ID           : {entry.ID}");
        Console.WriteLine($"Term         : {entry.GlossTerm}");
        Console.WriteLine($"Acronym      : {entry.Acronym}");
        Console.WriteLine($"Abbreviation : {entry.Abbrev}");
        Console.WriteLine($"Definition   : {entry.GlossDef?.Para}");
        Console.Write($"See Also     :");
        for (int i = 0; i < entry.GlossDef.GlossSeeAlso.Count; i++)
        {
            Console.Write($" {entry.GlossDef.GlossSeeAlso[i]}");
        }
        Console.WriteLine();
        Console.WriteLine($"Ref (See)    : {entry.GlossSee}");
    }
}
