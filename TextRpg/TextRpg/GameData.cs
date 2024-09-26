namespace TextRpg
{
    public class GameData
    {
        public int level { get; set; }
        public int exp { get; set; }
        public int liveHp { get; set; }
        public int gold { get; set; }
        public Item[] Inventory { get; set; } = new Item[0];
        //리스트를 배열로 저장하는부분 따라하긴했지만 이해하지못함 (공부필요)
    }
}
