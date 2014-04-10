using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using Utilities;

namespace PingService
{

    public class PingResponder : IPingResponder
    {

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Ping")]
        public string Ping()
        {
            return "Pong";
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "RollDice?count={count}&sides={sides}")]
        public int RollDice(int count, int sides)
        {
            return Utilities.Dice.Roll(count, sides);
        }
    }
}
