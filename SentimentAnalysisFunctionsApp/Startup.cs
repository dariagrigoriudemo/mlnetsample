using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.ML;
using SentimentAnalysisFunctionsApp;
using SentimentAnalysisFunctionsApp.DataModels;
using System;

[assembly: FunctionsStartup(typeof(Startup))]
namespace SentimentAnalysisFunctionsApp
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            string sentimentModelUri = Environment.GetEnvironmentVariable("SENTIMENT_MODEL_URI");

            builder.Services.AddPredictionEnginePool<SentimentData, SentimentPrediction>()
                .FromUri(sentimentModelUri);
        }
    }
}
