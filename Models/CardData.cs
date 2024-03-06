namespace DuelystPatchNotes.Models
{
    public class CardData
    {
        public string Name {  get; set; }
        public int ID { get; set; }
        public Faction Faction { get; set; }
        public string Rarity { get; set; }
        public string Description { get; set; }
        public List<int> relatedCards { get; set; }
        public Animations Resource { get; set; }
        public int Mana { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public string CardType { get; set; }
        public List<string> Tribes { get; set; }
    }
}
