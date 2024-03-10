namespace DuelystPatchNotes.Models
{
    public class Tribes
    {
        public const string Arcanyst = "Arcanyst";
        public const string Dervish = "Dervish";
        public const string Golem = "Golem";
        public const string Mech = "Mech";
        public const string Structure = "Structure";
        public const string Vespyr = "Vespyr";

        public static List<string> ToList =>
        [
            Arcanyst, Dervish, Golem, Mech, Structure, Vespyr
        ];
    }
}
