public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103082400024 mahasiswa = new DataMahasiswa103082400024();
        mahasiswa.ReadJSON();

        Console.WriteLine();
        TeamMembers103082400024 teamMembers = new TeamMembers103082400024();
        teamMembers.ReadJSON();

        Console.WriteLine();
        GlossaryItem103082400024 glossaryItem = new GlossaryItem103082400024();
        glossaryItem.ReadJSON();
    }
}