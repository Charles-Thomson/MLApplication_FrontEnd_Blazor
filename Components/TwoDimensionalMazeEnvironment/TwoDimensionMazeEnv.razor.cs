using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using static MachineLearningApplication_Build_2.Enums.EnvironmentNodeEnums;


namespace MachineLearningApplication_Build_2.Components.TwoDimensionalMazeEnvironment
{
    public partial class TwoDimensionMazeEnv
    {
        private List<MazeNodeStateClass> EnvironmentNodesData { get; set; } = new List<MazeNodeStateClass>();

        private int TotalNumberOfNodesInEnvironment { get; set; }

      
        public int CurrentEnvironmentDimension_X = 2;

        public int CurrentEnvironmentDimension_Y = 2;

        [Inject]
        private Services.InstanceAttributeStateContainer stateContainer { get; set; } // Ensures it's not null, but this depends on how it's set.


        /// <summary>
        /// Handle the update of value in the state container
        /// When value are updated the handler is triggered and the env is redrawn to the new dimensions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleStateEnvSizeStateChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(stateContainer.EnvironmentDimension_X) || e.PropertyName == nameof(stateContainer.EnvironmentDimension_Y))
            {
                Console.WriteLine($"Property changed recieved by Handle State in Maze: {e.PropertyName}");

                OnEnvironmentDimensionsUpdated();
                InvokeAsync(StateHasChanged);
            }
        }

        private NodeStateEnums NodeSelectionType { get; set; }

        private void HandleNodeSelectionValueChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(stateContainer.NodeSelectionValue))
            {
                Console.WriteLine($"Property changed recieved by Handle State in Maze: {e.PropertyName}");
                NodeSelectionType = stateContainer.NodeSelectionValue;
                Console.WriteLine(NodeSelectionType);
            }
        }

        /// <summary>
        /// Dispose of the event handler
        /// </summary>
        public void Dispose()
        {
            stateContainer.PropertyChanged -= HandleStateEnvSizeStateChange;
            stateContainer.NodeSelectionValueChanged -= HandleNodeSelectionValueChange;
        }

        /// <summary>
        /// Update the current Evnvironment dimension values from the stateContainer
        /// </summary>
        private void UpdateCurrentEnvDimensionsFromStateContainer() {
            CurrentEnvironmentDimension_X = ParseStrToInt(stateContainer.EnvironmentDimension_X);
            CurrentEnvironmentDimension_Y = ParseStrToInt(stateContainer.EnvironmentDimension_Y);
        }

        /// <summary>
        /// Calculate the total number of nodes in the env based on x,y dimensions
        /// </summary>
        /// <returns>int</returns>
        private int CalculateTotalNumberOfNodes() => CurrentEnvironmentDimension_X * CurrentEnvironmentDimension_Y;


        public List<MazeNodeStateClass> GenerateEnvironmentNodes(int TotalNumberOfNodesInEnvironment)
        {
            var generateNodes = Enumerable.Range(0, TotalNumberOfNodesInEnvironment)
                .Select(nodeIndex => new MazeNodeStateClass(nodeIndex, HandleNodeSelection))
                .ToList();

            return generateNodes;
        }


        /// <summary>
        /// When the enviornment size is changed the following methods are called
        /// </summary>
        private void OnEnvironmentDimensionsUpdated() {
            UpdateCurrentEnvDimensionsFromStateContainer();
            TotalNumberOfNodesInEnvironment = CalculateTotalNumberOfNodes();
            EnvironmentNodesData = GenerateEnvironmentNodes(TotalNumberOfNodesInEnvironment);

        }
        private void UpdateStateContainerTotalNumberOfNodes() => stateContainer.EnvironmentNodeStateData = new int[TotalNumberOfNodesInEnvironment];



        protected override void OnInitialized()
        {
            GenerateNewStateContainer();
            stateContainer.PropertyChanged += HandleStateEnvSizeStateChange;
            stateContainer.NodeSelectionValueChanged += HandleNodeSelectionValueChange;

            OnEnvironmentDimensionsUpdated();
        }
        

        /// <summary>
        /// Generate a new stateContainer object if one doe snot exist
        /// </summary>
        public void GenerateNewStateContainer() {
            if (stateContainer == null) {
                stateContainer = new Services.InstanceAttributeStateContainer();
            }
        }


        /// <summary>
        /// Parse a string representation of an int to int
        /// </summary>
        /// <param name="strValue">int value as str</param>
        /// <returns>int</returns>
        private int ParseStrToInt(string? strValue) {
            int result = 0;

            if (strValue == null) return result ;

            if (int.TryParse(strValue, out var intValue)) 
            {
                result = intValue;
            }
            return result;
        }

        /// <summary>
        /// Set a new start node in the Environment
        /// </summary>
        /// <param name="Index"></param>
        public void SetNewStartNode(int Index) => stateContainer.EnvironmentStartState = Index;


        /// <summary>
        /// Remove the previous start node from the environment
        /// </summary>
        public void RemoveOldStartNodeFromEnvironment()
        {
            var Node = EnvironmentNodesData[stateContainer.EnvironmentStartState];
            if (Node == null) return;

            Node.BackgroundColor = NodeBackgroundColorsEnums.Empty;
            stateContainer.EnvironmentNodeStateData[stateContainer.EnvironmentStartState] = 0;
        }


        public void HandleNodeSelection(int nodeIndex) {

            Console.WriteLine($"Node To be updated - index: {nodeIndex}");
            // Get the node from the List
            var SelectedNode = EnvironmentNodesData[nodeIndex];

            

            // Change the colour of the node based on the selection colour
            SelectedNode.BackgroundColor = NodeSelectionType switch
            {
                NodeStateEnums.Empty => NodeBackgroundColorsEnums.Empty,
                NodeStateEnums.Start => NodeBackgroundColorsEnums.Start,
                NodeStateEnums.Obstical => NodeBackgroundColorsEnums.Obstical,
                NodeStateEnums.Goal => NodeBackgroundColorsEnums.Goal,
                _ => NodeBackgroundColorsEnums.Empty
            };

            // Check for new start node
            if (stateContainer.NodeSelectionValue == NodeStateEnums.Start)
            {
                RemoveOldStartNodeFromEnvironment();
                SetNewStartNode(nodeIndex);
                return;
            }

            StateHasChanged();
        }


        ///// <summary>
        ///// Update the maze node state when node is selected
        ///// </summary>
        ///// <param name="Index"></param>
        //public void updateEnvironmentNodeStateData(int Index)
        //{
        //    //CheckEnvironmentNodeStateDataListSize();
        //    Console.WriteLine("Vaslue is being updated");

        //    var SelectedNode = EnvironmentNodesData[Index];
        //    NodeStateEnums CurrentSelectionNode = stateContainer.NodeSelectionValue;

        //    SelectedNode.BackgroundColor = CurrentSelectionNode switch
        //    {
        //        NodeStateEnums.Empty => NodeBackgroundColorsEnums.Empty,
        //        NodeStateEnums.Start => NodeBackgroundColorsEnums.Start,
        //        NodeStateEnums.Obstical => NodeBackgroundColorsEnums.Obstical,
        //        NodeStateEnums.Goal => NodeBackgroundColorsEnums.Goal,
        //        _ => NodeBackgroundColorsEnums.Empty
        //    };

        //    if (stateContainer.NodeSelectionValue == NodeStateEnums.Start)
        //    {
        //        RemoveOldStartNodeFromEnvironment();
        //        SetNewStartNode(Index);
        //        return;
        //    }

        //    StateHasChanged();
        //}

        /// Will pull the satte data when needed - aka lazy 
        
        //private void CheckEnvironmentNodeStateDataListSize()
        //{
        //    if (stateContainer.EnvironmentNodeStateData?.Count == TotalNumberOfNodesInEnvironment) return;
        //    stateContainer.EnvironmentNodeStateData = new List<int>(new int[TotalNumberOfNodesInEnvironment]);
        //}
    }
}
