using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MachineLearningApplication_Build_2.Enums.EnvironmentNodeEnums;


namespace MachineLearningApplication_Build_2.Components.TwoDimensionalMazeEnvironment
{
    public partial class TwoDimensionMazeEnv
    {
        private List<MazeNodeStateClass> EnvironmentNodesData { get; set; } = new List<MazeNodeStateClass>();

        private int TotalNumberOfNodesInEnvironment { get; set; }

        //private int _currentEnvironmentDimension_X { get; set; }
        //private int _currentEnvironmentDimension_Y { get; set; }

        //[CascadingParameter(Name = "CurrentEnvironmentDimension_X")]
        //public int CurrentEnvironmentDimension_X
        //{
        //    get => _currentEnvironmentDimension_X;
        //    set
        //    {
        //        _currentEnvironmentDimension_X = value;
        //        UpdateEnvironmentDimensions(value, CurrentEnvironmentDimension_Y);
        //    }
        //}

        //[CascadingParameter(Name = "CurrentEnvironmentDimension_Y")]
        //public int CurrentEnvironmentDimension_Y
        //{
        //    get => _currentEnvironmentDimension_Y;
        //    set
        //    {
        //        _currentEnvironmentDimension_Y = value;
        //        UpdateEnvironmentDimensions(CurrentEnvironmentDimension_X, value);
        //    }
        //}

        public int CurrentEnvironmentDimension_X = 2;

        public int CurrentEnvironmentDimension_Y = 2;


        public TwoDimensionMazeEnv() {
            UpdateEnvironmentDimensions(2, 2);


        }

        public void UpdateEnvironmentDimensions(int CurrentEnvironmentDimension_X, int CurrentEnvironmentDimension_Y)
        {
            Log.Information($"Environment Dimensions being updated with values {CurrentEnvironmentDimension_X} - {CurrentEnvironmentDimension_Y}");
            TotalNumberOfNodesInEnvironment = CurrentEnvironmentDimension_X * CurrentEnvironmentDimension_Y;
            Console.WriteLine($"Total number of new states : {TotalNumberOfNodesInEnvironment}");

            //List<int> holder = new List<int>(5);

            //stateContainer.EnvironmentNodeStateData = holder;

            EnvironmentNodesData = GenerateEnvironmentNodes(TotalNumberOfNodesInEnvironment);
        }

        public List<MazeNodeStateClass> GenerateEnvironmentNodes(int environmentSizeAsInt)
        {

            if (environmentSizeAsInt < 0) throw new ArgumentException("Environment size must be a positive integer.");

            var generateNodes = Enumerable.Range(0, environmentSizeAsInt)
                .Select(index => new MazeNodeStateClass(index))
                .ToList();

            return generateNodes;
        }

        public void SetNewStartNode(int Index) => stateContainer.EnvironmentStartState = Index;

        public void RemoveOldStartNodeFromEnvironment()
        {
            var Node = EnvironmentNodesData[stateContainer.EnvironmentStartState];
            if (Node == null) return;

            Node.BackgroundColor = NodeBackgroundColorsEnums.Empty;
            stateContainer.EnvironmentNodeStateData[stateContainer.EnvironmentStartState] = 0;
        }

        public void updateEnvironmentNodeStateData(int Index)
        {
            CheckEnvironmentNodeStateDataListSize();
            Console.WriteLine("Vaslue is being updated");

            var SelectedNode = EnvironmentNodesData[Index];
            NodeStateEnums CurrentSelectionNode = stateContainer.NodeSelectionValue;

            SelectedNode.BackgroundColor = CurrentSelectionNode switch
            {
                NodeStateEnums.Empty => NodeBackgroundColorsEnums.Empty,
                NodeStateEnums.Start => NodeBackgroundColorsEnums.Start,
                NodeStateEnums.Obstical => NodeBackgroundColorsEnums.Obstical,
                NodeStateEnums.Goal => NodeBackgroundColorsEnums.Goal,
                _ => NodeBackgroundColorsEnums.Empty
            };

            if (stateContainer.NodeSelectionValue == NodeStateEnums.Start)
            {
                RemoveOldStartNodeFromEnvironment();
                SetNewStartNode(Index);
                return;
            }

            stateContainer.EnvironmentNodeStateData[Index] = (int)CurrentSelectionNode;
            StateHasChanged();
        }

        private void CheckEnvironmentNodeStateDataListSize()
        {
            if (stateContainer.EnvironmentNodeStateData?.Count == TotalNumberOfNodesInEnvironment) return;
            stateContainer.EnvironmentNodeStateData = new List<int>(new int[TotalNumberOfNodesInEnvironment]);
        }
    }
}
