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
                        return ResponseBuilder.Ask("Try asking for a meat to pair.", new Reprompt("Would you like to pair a meat?"));
                    }

                    if (intentReq.DialogState == "")
                    {

                    }
                        string intentValue = intentReq.Intent.Slots["meat"].Value;
                    if (intentValue.Contains("beef") ||
                        intentValue.Contains("steak") ||
                        intentValue.Contains("lamb") ||
                        intentValue.Contains("goat") ||
                        intentValue.Contains("veal"))
                    {
                        request = new RedMeat();
                    }
                    else if (intentValue.Contains("cured") ||
                             intentValue.Contains("bacon") ||
                             intentValue.Contains("salami"))
                    {
                        request = new CuredMeat();
                    }
                    else if (intentValue.Contains("pork") ||
                             intentValue.Contains("ham"))
                    {
                        request = new Pork();
                    }
                    else if (intentValue.Contains("chicken") ||
                             intentValue.Contains("poultry") ||
                             intentValue.Contains("light meat") ||
                             intentValue.Contains("dark meat") ||
                             intentValue.Contains("duck") ||
                             intentValue.Contains("turkey") ||
                             intentValue.Contains("goose"))
                    {
                        request = new Poultry();
                    }
                    else if (intentValue.Contains("mollusk") ||
                             intentValue.Contains("clam") ||
                             intentValue.Contains("oyster") ||
                             intentValue.Contains("mussel") ||
                             intentValue.Contains("scallop"))
                    {
                        request = new Mollusk();
                    }
                    else if (intentValue.Contains("shellfish") ||
                             intentValue.Contains("shrimp") ||
                             intentValue.Contains("lobster") ||
                             intentValue.Contains("crab"))
                    {
                        request = new Shellfish();
                    }
                    else if (intentValue.Contains("fish") ||
                             intentValue.Contains("seafood") ||
                             intentValue.Contains("salmon"))
                    {
                        request = new Fish();
                    }
                    

                    if (request == null)
                        Console.WriteLine("Null request sent to matching service with intentValue: " + intentValue);

                    var matches = _winePair.FindBestMatchingWines(request);
                    IWine match1, match2 = match1 = null;
                    if(matches.Count >= 2)
                    {
                        match1 = matches[0];
                        match2 = matches[1];
                    }
                    else if(matches.Count == 1)
                    {
                        match1 = matches[0];
                    }

                    if (match1 == null && match2 == null)
                        throw new Exception("Could not find matching wine.");



                    string response;
                    if (match1 != null && match2 != null)
                        response = string.Format("You should try a {0} wine like {1} or a {2} wine like {3}", match1.Style.ToString(), match1.Name, match2.Style.ToString(), match2.Name);
                    else
                        response = string.Format("You should try a {0} wine like {1}", match1.Style.ToString(), match1.Name);

                    return ResponseBuilder.Tell(response);
                }
                else if (requestType == typeof(LaunchRequest))
                {
                    var response = ResponseBuilder.Ask("What can I pair for you?", new Reprompt("Would you like to pair a wine?"));
                    response.Response.ShouldEndSession = false;
                    return response;
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
