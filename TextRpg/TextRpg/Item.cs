namespace TextRpg
{
    public class Item
    {
        //아이템쪽 변수선언
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Type { get; set; } // 0: 방어구, 1: 무기
        public float Stat { get; set; }
        public bool IsEquipped { get; set; } // 장착 여부

        public Item(string name, int price, string description, int type, float stat)
        {
            Name = name;
            Price = price;
            Description = description;
            Type = type;
            Stat = stat;
            IsEquipped = false; // 기본값은 장착되지 않음
        }
    }
}
