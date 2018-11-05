using System;
using Amazon.Lambda.Core;
using Alexa.NET.Response;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using WinePairLambda.Core.Models;
using WinePairLambda.Core.Models.Foods;
using WinePairLambda.DependencyInjection;
using Alexa.NET;

namespace WinePairLambda
{
    public class Program
    {
        private static IWinePairService _winePair = new WinePair();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public SkillResponse GetWine(SkillRequest input, ILambdaContext context)
        {
            try
            {
                var requestType = input.GetRequestType();
                if (requestType == typeof(IntentRequest))
                {
                    IFood request = null;
                    var intentReq = input.Request as IntentRequest;
                    if (intentReq.Intent.Name == "AMAZON.HelpIntent")
                    {
                        return ResponseBuilder.Ask("Try asking for a meat to pair. Would you like to pair a wine with meat?", new Reprompt("Would you like to hear a joke?"));
                    }
                    string intentValue = intentReq.Intent.Slots["meat"].Value;
                    if (intentValue == "beef" ||
                        intentValue == "steak" ||
                        intentValue == "lamb" ||
                        intentValue == "goat" ||
                        intentValue == "veal")
                    {
                        request = new RedMeat();
                    }
                    else if (intentValue == "cured meat" ||
                             intentValue == "bacon" ||
                             intentValue == "salami")
                    {
                        request = new CuredMeat();
                    }
                    else if (intentValue == "pork" ||
                             intentValue == "ham")
                    {
                        request = new Pork();
                    }
                    else if (intentValue == "chicken" ||
                             intentValue == "poultry" ||
                             intentValue == "light meat" ||
                             intentValue == "dark meat" ||
                             intentValue == "duck" ||
                             intentValue == "turkey" ||
                             intentValue == "goose")
                    {
                        request = new Poultry();
                    }
                    else if (intentValue == "mollusk" ||
                             intentValue == "clams" ||
                             intentValue == "oysters" ||
                             intentValue == "mussels" ||
                             intentValue == "scallops")
                    {
                        request = new Mollusk();
                    }
                    else if (intentValue == "fish" ||
                             intentValue == "seafood" ||
                             intentValue == "salmon")
                    {
                        request = new Fish();
                    }
                    else if (intentValue == "shellfish" ||
                             intentValue == "shrimp" ||
                             intentValue == "lobster" ||
                             intentValue == "crab")
                    {
                        request = new Shellfish();
                    }

                    if (request == null)
                        Console.WriteLine("Null request sent to matching service");

                    var match = _winePair.FindMatchingWine(request);

                    string response = String.Format("You should try a {0} wine like {1}", match.Style.ToString(), match.Name);

                    return ResponseBuilder.Tell(response);
                }
                else if (requestType == typeof(LaunchRequest))
                {
                    var response = ResponseBuilder.Ask("What can I pair for you?", new Reprompt("Would you like to pair a wine?"));
                    response.Response.ShouldEndSession = false;
                    return response;
                }
                else if (requestType == typeof(AudioPlayerRequest))
                {
                    var audioRequest = input.Request as AudioPlayerRequest;

                    // these are events sent when the audio state has changed on the device
                    // determine what exactly happened
                    if (audioRequest.AudioRequestType == AudioRequestType.PlaybackNearlyFinished)
                    {
                        // queue up another audio file
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write("Exception Caught: ");
                Console.WriteLine(e);
            }

            return ResponseBuilder.Ask("What would you like to pair?", new Reprompt("What would you like to pair?"));
        }
    }
}
