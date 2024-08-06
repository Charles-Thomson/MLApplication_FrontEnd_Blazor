using MachineLearningApplication_Build_2.Services;
using Microsoft.AspNetCore.Components;
using Serilog;

namespace MachineLearningApplication_Build_2.Pages
{
    public partial class Home
    {
        public string Supervised_Learning_Card_Content { get; private set; } = "Supervised Learning (SL) takes a defined input set and desiered output to train a model ...";
        public string Unsupervised_Learning_Card_Content { get; private set; } = "Unsupervised Learnming (ML) takes a unlabeled data to train a model to deisearn patterns and insights ...";
        public string Regression_Card_Content { get; private set; } = "Regression takes a set of input data and known outpus to train a model to determain the outcome of future input sets ...";
        public string Classification_Learning_Card_Content { get; private set; } = "Classification trains a model to desearn input data into a numebr of pre defined clasifications ...";


    }
}
