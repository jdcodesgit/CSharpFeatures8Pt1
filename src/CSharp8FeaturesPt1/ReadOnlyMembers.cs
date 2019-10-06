namespace CSharp8FeaturesPt1
{
    internal struct ReadOnlyMembers
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public readonly int Area => Length * Width;
        public readonly override string ToString() => $"Area of {Length} x {Width} = {Area}";
    }
}
