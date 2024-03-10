namespace DuelystPatchNotes.Models
{
    public class CardType
    {
        public const string General = "General";
        public const string Minion = "Minion";
        public const string Artifact = "Artifact";
        public const string Spell = "Spell";

        public static List<string> ToList =>
        [
            General, Minion, Artifact, Spell
        ];
    }
}
