namespace DuelystPatchNotes.Models
{
    public class Patch
    {
        public string Version { get; set; }
        public bool IsLatest => Version == "Latest";
    }
}
