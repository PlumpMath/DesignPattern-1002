using System;
using System.Collections.Generic;

namespace DesignPattern.CreationalPattern.Singleton.RealWorld
{
    /// <summary>
    ///     The 'Singleton' class
    /// </summary>
    public class LoadBalancer
    {
        private static LoadBalancer instance;

        // Lock synchronization object
        private static readonly object syncLock = new object();
        private readonly Random random = new Random();
        private readonly List<string> servers = new List<string>();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                var index = random.Next(servers.Count);
                return servers[index];
            }
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }

            return instance;
        }
    }
}