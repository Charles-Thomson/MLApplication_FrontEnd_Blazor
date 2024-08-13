namespace MachineLearningApplication_Build_2.Structs
{
    public class IconAndDescriptionStruct<T1, T2, T3, T4>
    {
        public T1 IconType { get; set; }
        public T2 IconColor { get; set; }

        public T3 IconSize { get; set; }

        public T4 Description { get; set; }

        public IconAndDescriptionStruct(T1 iconType, T2 iconColor, T3 iconSize, T4 description) {
            IconType = iconType;
            IconColor = iconColor;
            IconSize = iconSize;
            Description = description;
        }

    }
}
