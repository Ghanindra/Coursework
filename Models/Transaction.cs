﻿using System;

namespace Coursework.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public List<string> Tags { get; set; } // For categorization
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}