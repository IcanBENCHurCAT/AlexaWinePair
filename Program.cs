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
        public SkillResponse GetWine(SkillRequest value)
        {
            try
            {
                IFood request = null;
                var intentReq = value.Request as IntentRequest;
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
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught:");
                Console.WriteLine(e);
            }

            return ResponseBuilder. Tell("What would you like to pair?");
        }
    }
}
