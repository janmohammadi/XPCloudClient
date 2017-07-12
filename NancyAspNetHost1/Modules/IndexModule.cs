using System;
using System.IO;
using Microsoft.AspNet.SignalR.StockTicker;
using Nancy;

namespace NancyAspNetHost1.Modules
{
    public class IndexModule : NancyModule
    {
        static string GlobalLog;
        public IndexModule()
        {
			Get["/Report"] = parameters =>
			{
				return View["report"];
			};
            Get["/QueryTicker"] = parameters =>
            {
                return View["QueryTicker"];
            };
            //         Get["/"] = parameters =>
            //{
            //    return View["index"];

            //};
            //Get["/Report"] = parameters =>
            //{
            //    return View["report"];
            //};
            Get["/"] = parameters => { return HandleQuery(parameters); };

        }

        private String HandleQuery(dynamic parameters)
        {
            String query = "Query: ";
            query += Request.Url.Query;


            WriteToLog(query) ;
            return query;
        }

        private void WriteToLog(string log)
        {


            StockTicker stockeTicker = new StockTicker();
            stockeTicker.SendMessage(log);
          

            System.Diagnostics.Debug.WriteLine(log);

        }
    }
}