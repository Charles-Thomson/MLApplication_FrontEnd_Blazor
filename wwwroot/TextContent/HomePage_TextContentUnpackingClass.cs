namespace MachineLearningApplication_Build_2.wwwroot.TextContent
{

    
    public class HomePage_TextContentUnpackingClass
    {
        public string? Definition { get; set; }
        public string? Goal { get; set; }
        public string? Process { get; set; }
    }

    public class HomePageTextContent
    {
        public HomePage_TextContentUnpackingClass? Default_Card { get; set; }
        public HomePage_TextContentUnpackingClass? Supervised_Machine_Learning { get; set; }
        public HomePage_TextContentUnpackingClass? Unsupervised_Machine_Learning { get; set; }
        public HomePage_TextContentUnpackingClass? Regression_Machine_Learning { get; set; }
        public HomePage_TextContentUnpackingClass? Classification_Machine_Learning { get; set; }

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
