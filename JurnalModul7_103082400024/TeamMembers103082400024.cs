using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class members
{
    [JsonPropertyName("firstName")]
    public string firstName { get; set; }
    [JsonPropertyName("lastName")]
    public string lastName { get; set; }
    [JsonPropertyName("gender")]
    public string gender { get; set; }
    [JsonPropertyName("age")]
    public int age { get; set; }
    [JsonPropertyName("nim")]
    public string nim { get; set; }
}

public class TeamMembers103082400024
{
    public List<members> members { get; set; }

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103082400024.json");
        
        TeamMembers103082400024 teamMembers = JsonSerializer.Deserialize<TeamMembers103082400024>(jsonString);
        Console.WriteLine("Team Members:");
        for (int i = 0; i < teamMembers.members.Count; i++)
        {
            Console.WriteLine($"{teamMembers.members[i].nim} - {teamMembers.members[i].firstName} {teamMembers.members[i].lastName}" +
                $" ({teamMembers.members[i].age} - {teamMembers.members[i].gender})");
        }
    }    
}