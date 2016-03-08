using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrandmasBoy.Service.Hubs
{
    public class GameHub : Hub
    {
        private static int counter;
        public int Ping()
        {
            return ++counter;
        }
    }
}