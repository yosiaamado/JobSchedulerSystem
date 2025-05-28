﻿namespace JobScheduler.Frontend.Class.InternalClass
{
    public class ConnectionDto
    {
        public string Name { get; set; } = string.Empty;
        public string Host { get; set; } = string.Empty;
        public string PortString { get; set; } = "";
        public int Port { get; set; }
        public string DatabaseName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
