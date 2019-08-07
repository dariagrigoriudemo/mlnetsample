using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.ML;
using SentimentAnalysisFunctionsApp;
using SentimentAnalysisFunctionsApp.DataModels;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace SentimentAnalysisFunctionsApp
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddPredictionEnginePool<SentimentData, SentimentPrediction>()
                .FromFile("MLModels/sentiment_model.zip");
        }
    }
}