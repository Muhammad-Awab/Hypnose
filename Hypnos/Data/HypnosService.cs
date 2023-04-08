using Hypnos.Pages;
using static System.Formats.Asn1.AsnWriter;

namespace Hypnos.Data
{
    public class HypnosService
    {
        private static List<HypnosQuestion>? Quesions;

        static HypnosService()
        {
            Quesions = new List<HypnosQuestion>()
            {
                new HypnosQuestion
                {
                    Qno=1,
                    Category="sa",
                    Title="Sleep Apnea",
                    Question = "Do you snore loudly?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=2,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Do you often feel tired, sleepy or fatigued during the daytime?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=3,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Has anyone observed you stop breating in your seelp?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=4,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Do you have (or are you being treated for) high blood pressure?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=5,
                    Category="sa",Title="Sleep Apnea",
                    Question = "In the following situations, how likely are you to nap or fall aspleep?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=6,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Sitting and reading ?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=7,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Sitting and watching TV?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=8,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Sitting inactive in a public space?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3

                },
                   new HypnosQuestion
                {
                    Qno=9,
                    Category="sa",Title="Sleep Apnea",
                    Question = "As a passenger in a car for one hour without a break?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=10,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Lying down to rest in the afternoon ?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=11,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Sitting and talking to someone?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                   new HypnosQuestion
                {
                    Qno=12,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Sitting quietfly after lunch without alcohol?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                        new HypnosQuestion
                {
                    Qno=13,
                    Category="sa",
                            Title="Sleep Apnea",
                    Question = "In a care, while stopped for a few minutes in traffic?",
                    Choices = new List<string> { "Never", "slight", "moderate", "high","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                             new HypnosQuestion
                {
                    Qno=14,
                    Category="sa",Title="Sleep Apnea",
                    Question = "How many times do you typically wake up during the nighttime?",
                    Choices = new List<string> { "0", "1-3", ">3","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                                  new HypnosQuestion
                {
                    Qno=15,
                    Category="sa",Title="Sleep Apnea",
                    Question = "What position do you believe you spend most of your sleep time in ?",
                    Choices = new List<string> { "Back,", "side", "stomach", "recliner","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                                       new HypnosQuestion
                {
                    Qno=16,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Do you often wake up with a dry mouth or morning headache?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                                            new HypnosQuestion
                {
                    Qno=17,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Do you often take scheduled or unscheduled naps?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                                            new HypnosQuestion
                {
                    Qno=18,
                    Category="sa",Title="Sleep Apnea",
                    Question = "Have you gained weight in last 3-5 years?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                },
                                            new HypnosQuestion
                {
                    Qno=19,
                    Category="TC",Title="Tobacco Cessation",
                    Question = "Have you gained weight in last 3-5 years?",
                    Choices = new List<string> {"Yes", "No","Please Select"},
                    AnswerIndex = 1,
                    Score = 3
                }
            
            };
        }


        public Task<List<HypnosQuestion>?> GetQuestions()
        {
            
            return Task.FromResult(Quesions);
        }
    }
}
