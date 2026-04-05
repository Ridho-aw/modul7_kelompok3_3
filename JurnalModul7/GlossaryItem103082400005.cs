using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static JurnalModul7.DataMahasiswa103082400005;

namespace JurnalModul7
{
    internal class GlossaryItem103082400005
    {
        public class GlossaryRoot
        {
            [JsonPropertyName("glossary")]
            public Glossary Glossary { get; set; }
        }
        public class Glossary
        {
            [JsonPropertyName("title")]
            public string title {  get; set; }
            [JsonPropertyName("GlossDiv")]
            public GlossDiv GlossDiv { get; set; }

        }

        public class GlossDiv
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("GlossList")]
            public GlossList GlossList {  get; set; }
             
        }

        public class GlossList
        {
            [JsonPropertyName("GlossEntry")]
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public class GlossDefDetail
            {
                [JsonPropertyName("para")]
                public string Para { get; set; }

                [JsonPropertyName("GlossSeeAlso")]
                public List<string> GlossSeeAlso { get; set; }
            }

            [JsonPropertyName("ID")]
            public string ID {  get; set; }

            [JsonPropertyName("SortAs")]
            public string SortAs {  get; set; }

            [JsonPropertyName("GlossTerm")]
            public string GlossTerm {  get; set; }

            [JsonPropertyName("Acronym")]
            public string Acronym { get; set; }

            [JsonPropertyName("Abbrev")]
            public string Abbrev {  get; set; }

            [JsonPropertyName("GlossDef")]
            public GlossDefDetail GlossDef { get; set; }

            [JsonPropertyName("GlossSee")]
            public string GlossSee {  get; set; }
        }

       
        public static void ReadJSON()
        {
            string stringJson = File.ReadAllText("../../../jurnal7_3_103082400005.json");

            try
            {
                GlossaryRoot root = JsonSerializer.Deserialize<GlossaryRoot>(stringJson);
                GlossEntry glossEntry = root.Glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine("Glosary Info: ");
                Console.WriteLine(
                    $"\nID: {glossEntry.ID}" +
                    $"\nSort As: {glossEntry.SortAs}" +
                    $"\nGloss Term: {glossEntry.GlossTerm}" +
                    $"\nAcronym: {glossEntry.Acronym}" +
                    $"\nAbbrev: {glossEntry.Abbrev}" +
                    $"\n====================================" +
                    $"\nGloss Def: " +
                    $"\nPara: {glossEntry.GlossDef.Para}"
                    );

                Console.WriteLine("\nGloss See Also: ");
                foreach(string glossSeeItem in glossEntry.GlossDef.GlossSeeAlso)
                {
                    Console.WriteLine(glossSeeItem);
                }
                Console.WriteLine($"===================================");
                Console.WriteLine($"\nGloss See:  {glossEntry.GlossSee}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal memuat JSON: {ex.Message}");
            }
        }

    }
}
