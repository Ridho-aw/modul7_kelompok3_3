using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JurnalModul7
{
    internal class TeamMembers103082400018
    {

        public class TeamMembers
        {
            public class Member
            {
                [JsonPropertyName("firstName")]
                public string FirstName { get; set; }
                [JsonPropertyName("lastName")]
                public string LastName { get; set; }
                [JsonPropertyName("gender")]
                public string Gender { get; set; }
                [JsonPropertyName("age")]
                public int Age {  get; set; }
                [JsonPropertyName("nim")]
                public string Nim {  get; set; }

            }

            [JsonPropertyName("members")]
            public List<Member> Members { get; set; }

        }

        public static void readJSON()
        {
            string strtingJSON = File.ReadAllText("../../../jurnal7_2_103082400018.json");

            try
            {
                TeamMembers teamMembers = JsonSerializer.Deserialize<TeamMembers>(strtingJSON);

                Console.WriteLine("Team member list:");
                foreach (var member in teamMembers.Members)
                {
                    Console.WriteLine($"{member.Nim} {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tidak dapat memuat JSON: {ex.Message}");
            }
        }
    }
}
