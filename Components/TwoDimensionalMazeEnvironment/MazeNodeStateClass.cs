namespace MachineLearningApplication_Build_2.Components.TwoDimensionalMazeEnvironment
{
    public class MazeNodeStateClass
    {
        public int Index { get; set; }
        public string BackgroundColor = "whitesmoke";

        public MazeNodeStateClass(int index)
        {
            this.Index = index;
        }

    }
}
