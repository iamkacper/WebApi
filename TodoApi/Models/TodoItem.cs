﻿namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public long CardNumber { get; set; }
        public long Amount { get; set; }
        public string? Currency { get; set; }
        public string? Secret { get; set; }

    }
}