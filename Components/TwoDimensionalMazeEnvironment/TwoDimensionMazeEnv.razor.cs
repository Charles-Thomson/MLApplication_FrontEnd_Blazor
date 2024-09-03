using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using static MachineLearningApplication_Build_2.Enums.EnvironmentNodeEnums;


namespace MachineLearningApplication_Build_2.Components.TwoDimensionalMazeEnvironment
{
    public partial class TwoDimensionMazeEnv
    {
        private int CurrentEnvironmentDimension_X { get; set; }

        private int CurrentEnvironmentDimension_Y { get; set; }

        private NodeStateEnums NodeSelectionType { get; set; }
        private int TotalNumberOfNodesInEnvironment { get; set; }

        private List<MazeNodeStateClass> EnvironmentNodesData { get; set; } = new List<MazeNodeStateClass>();

        [Inject]
        private Services.InstanceAttributeStateContainer stateContainer { get; set; } // Ensures it's not null, but this depends on how it's set.

        protected override void OnInitialized()
        {
            GenerateNewStateContainer();
            stateContainer.PropertyChanged += HandleStateEnvSizeStateChange;
            stateContainer.NodeSelectionValueChanged += HandleNodeSelectionValueChange;

            OnEnvironmentDimensionsUpdated();
        }

        /// <summary>
        /// When the enviornment size is changed the following methods are called
        /// </summary>
        private void OnEnvironmentDimensionsUpdated()
        {
            UpdateCurrentEnvDimensionsFromStateContainer();
            TotalNumberOfNodesInEnvironment = CalculateTotalNumberOfNodes();
            EnvironmentNodesData = GenerateEnvironmentNodes(TotalNumberOfNodesInEnvironment);
            UpdateStateContainerTotalNumberOfNodes();
        }

        public void GenerateNewStateContainer()
        {
            if (stateContainer == null)
            {
                stateContainer = new Services.InstanceAttributeStateContainer();
            }
        }

        private void UpdateStateContainerTotalNumberOfNodes() => stateContainer.EnvironmentNodeStateData = new int[TotalNumberOfNodesInEnvironment];


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
                OnEnvironmentDimensionsUpdated();
                InvokeAsync(StateHasChanged);
            }
        }

        private void HandleNodeSelectionValueChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(stateContainer.NodeSelectionValue))
            {
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
        /// Handle the updating of a node in the environment
        /// </summary>
        /// <param name="nodeIndex"></param>
        private void HandleNodeSelection(int nodeIndex) {

            Console.WriteLine($"Node To be updated - index: {nodeIndex}");
            // Get the node from the List
            var SelectedNode = EnvironmentNodesData[nodeIndex];

            // Change the colour of the node based on the selection colour
            SelectedNode.BackgroundColor = GetBackGroundColour(NodeSelectionType);

            UpdateNodeStateDataInStateContainer(nodeIndex, (int)NodeSelectionType);

            // Check for new start node
            if (NodeSelectionType == NodeStateEnums.Start)
            {
                HandleStartNodeChange(nodeIndex);
                return;
            }
            StateHasChanged();
        }


        /// <summary>
        /// Handle the change of the enviornment start node
        /// </summary>
        /// <param name="nodeIndex"></param>
        private void HandleStartNodeChange(int nodeIndex) {
            RemoveOldStartNodeFromEnvironment();
            UpdateEnvironmentStartStateInStateContainer(nodeIndex);
        }

        ///// <summary>
        ///// Set a new start node in the Environment
        ///// </summary>
        ///// <param name="Index"></param>
        //private void SetStartNodeIndex(int Index)
        //{
        //    StartNodeIndex = Index;
        //    UpdateEnvironmentStartStateInStateContainer(Index);
        //}


        /// <summary>
        /// Remove the previous start node from the environment
        /// </summary>
        private void RemoveOldStartNodeFromEnvironment()
        {
            int StartNodeIndex = stateContainer.EnvironmentStartState;
            if (StartNodeIndex == null) return;

            var Node = EnvironmentNodesData[StartNodeIndex];

            if (Node.BackgroundColor == NodeBackgroundColorsEnums.Start)
            {
                Node.BackgroundColor = NodeBackgroundColorsEnums.Empty;
            }
        }


        /// <summary>
        /// Retunr the beackground colour based on selection type
        /// </summary>
        /// <param name="selectionType"></param>
        /// <returns>New colour as string</returns>
        private string GetBackGroundColour(NodeStateEnums selectionType) {

            return selectionType switch
            {
                NodeStateEnums.Empty => NodeBackgroundColorsEnums.Empty,
                NodeStateEnums.Start => NodeBackgroundColorsEnums.Start,
                NodeStateEnums.Obstical => NodeBackgroundColorsEnums.Obstical,
                NodeStateEnums.Goal => NodeBackgroundColorsEnums.Goal,
                _ => NodeBackgroundColorsEnums.Empty
            };
        }

        /// <summary>
        /// Update the state class EnvironmentNodeStateData with chnages to the environment
        /// </summary>
        /// <param name="nodeIndex">Index of updated</param>
        private void UpdateNodeStateDataInStateContainer(int nodeIndex, int value) {
            stateContainer.EnvironmentNodeStateData[nodeIndex] = value;
        }

        private void UpdateEnvironmentStartStateInStateContainer(int nodeIndex)
        {
            stateContainer.EnvironmentStartState = nodeIndex;
        }

        /// <summary>
        /// Parse a string representation of an int to int
        /// </summary>
        /// <param name="strValue">int value as str</param>
        /// <returns>int</returns>
        private int ParseStrToInt(string? strValue)
        {
            int result = 0;

            if (strValue == null) return result;

            if (int.TryParse(strValue, out var intValue))
            {
                result = intValue;
            }
            return result;
        }
    }
}
