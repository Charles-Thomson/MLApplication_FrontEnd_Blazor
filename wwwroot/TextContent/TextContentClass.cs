namespace MachineLearningApplication_Build_2.wwwroot.TextContent
{

    
    public class TextContentClass
    {
        public string? Definition { get; set; }
        public string? Goal { get; set; }
        public string? Process { get; set; }
    }

    public class HomePageTextContent
    {
        public TextContentClass? Default_Card { get; set; }
        public TextContentClass? Supervised_Machine_Learning { get; set; }
        public TextContentClass? Unsupervised_Machine_Learning { get; set; }
        public TextContentClass? Regression_Machine_Learning { get; set; }
        public TextContentClass? Classification_Machine_Learning { get; set; }

    }

    public class InformationSubPageTextContent
    {
        public string? introduction { get; set; }
        public string? process { get; set; }
        public string? goal { get; set; }
    }

    public class InfomartionPageTextContent
    {
        public InformationSubPageTextContent? TextContent { get; set; }

    }


}
