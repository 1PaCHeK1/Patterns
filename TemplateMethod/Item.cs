namespace TemplateMethod
{
    internal class Item : System.IComparable<Item>
    {
        public Item(int _Value) => Value = _Value;

        public int Value;
        public int CompareTo(Item other) => other switch
        {
            var x when this.Value > x.Value => 1,
            var x when this.Value < x.Value => -1,
            _ => 0,
        };
    }
}