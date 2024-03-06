using System.IO;

namespace DuelystPatchNotes.Services
{
    public class PatchReader
    {
        public string[] GetPatches()
        {
            string[] files = Directory.GetFiles("./PatchData");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            return files;
        }
    }
}
