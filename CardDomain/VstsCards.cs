using CardDomain.Interfaces;
using Microsoft.TeamFoundation.Core.WebApi.Types;
using Microsoft.TeamFoundation.Work.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardDomain
{
	public class VstsCards : IVstsCards
	{
		ICardConfig _config;

		public VstsCards(ICardConfig config)
		{
			_config = config;
		}


		public void Wat()
		{
			var uri = new Uri(_config.Url);

			using (var connection = new VssConnection(uri, new VssBasicCredential(string.Empty, _config.Token)))
			using (var workClient = connection.GetClient<WorkHttpClient>())
			using (var workItemClient = connection.GetClient<WorkItemTrackingHttpClient>())
			{
				//var teamContext = new TeamContext("", "");
				//var iterations = workClient.GetTeamIterationsAsync(teamContext).Result;

				//var cards = workClient.GetIterationWorkItemsAsync(teamContext, iterations.FirstOrDefault(i => i.Name == "").Id).Result;
				//var workItems = new List<WorkItem>();

				//foreach (var card in cards.WorkItemRelations)
				//	workItems.Add(workItemClient.GetWorkItemAsync(card.Target.Id, expand: WorkItemExpand.All).Result);

				var asdfasdf = 9;
			}
		}
	}
}
