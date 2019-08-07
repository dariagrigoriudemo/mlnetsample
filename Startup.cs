using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.ML;
using SentimentAnalysisFunctionsApp;
using SentimentAnalysisFunctionsApp.DataModels;


[assembly: WebJobsStartup(typeof(Startup))]
namespace SentimentAnalysisFunctionsApp
{
    class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddPredictionEnginePool<SentimentData, SentimentPrediction>()
                .FromFile("MLModels/sentiment_model.zip");
        }
    }
}