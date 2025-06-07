
//Load sample data
using MLlearning;


static void Predict(string? LTpredictInput)
{
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = $"{LTpredictInput}",
    };

    //Load model and predict output
    var result = SentimentModel.Predict(sampleData);

    var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
    Console.Write("Press any key to continue...");
    Console.ReadKey();
}


while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to the first Sentiment Model!");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("1: Predict sentiment");
    Console.WriteLine("2: Exit");
    Console.Write(":> ");
    var input = Console.ReadLine();
    if (input == "1")
    {
        Console.Write("Write what to predict:> ");
        var LTpredict = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Sentence: {LTpredict}");
        Console.WriteLine("");
        Predict(LTpredict);
        

    } else if (input == "2")
    {
        Environment.Exit(0);
    } else
    {
        Console.WriteLine("Invalid");
    }





}
