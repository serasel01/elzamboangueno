using QnAMakerDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using El_Zambo.Controllers;

namespace El_Zambo.Controllers
{
    [Serializable]
    [QnAMakerService("116b3fef79804d98a154a8d6de291c81", "e9e76afe-0676-4970-a2f0-c61a8554e44b")]
    public class QnADialog : QnAMakerDialog<object>
    {
        public override async Task NoMatchHandler(IDialogContext context, string originalQueryText)
        {
            await context.PostAsync("Sorry, I couldn't find an answer for your inquiry.");
            context.Wait(MessageReceived);
        }
    }
}