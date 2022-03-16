namespace LW3_II
{
    class Element
    {
        public int value { get; set; }
        public Element(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Element el = obj as Element;
            if (el as Element == null)
            {
                return false;
            }
            return el.value == this.value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}
