namespace GuitarApp
{
    internal class GuitarSpec
    {
        public Builder builder { get; }
        public string model { get; }
        public Type type { get; }
        public Wood backWood { get; }
        public Wood topWood { get; }
        public int numStrings{ get; }

        public GuitarSpec( Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (!builder.Equals(otherSpec.builder))
            {
                return false;
            }
            if (!model.ToLower().Equals(otherSpec.model.ToLower()))
            {
                return false;
            }
            if (!type.Equals(otherSpec.type))
            {
                return false;
            }
            if (!backWood.Equals(otherSpec.backWood))
            {
                return false;
            }
            if (!topWood.Equals(otherSpec.topWood))
            {
                return false;
            }
            if (!numStrings.Equals(otherSpec.numStrings))
            {
                return false;
            }
            return true;
        }   
    }
}
