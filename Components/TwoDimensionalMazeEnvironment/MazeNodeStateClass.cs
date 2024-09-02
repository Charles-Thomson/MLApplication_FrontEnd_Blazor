using Microsoft.AspNetCore.Components;

namespace MachineLearningApplication_Build_2.Components.TwoDimensionalMazeEnvironment
{
    public class MazeNodeStateClass
    {
        public int nodeIndex { get; set; }

        public string BackgroundColor = "whitesmoke";
        


        private Action<int> handleNodeSelection;

        public MazeNodeStateClass(int nodeIndex, Action<int> handleNodeSelection)
        {
            this.nodeIndex = nodeIndex;
            this.handleNodeSelection = handleNodeSelection;
        }
    }
}
