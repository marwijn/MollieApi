﻿using System.ComponentModel.DataAnnotations;

namespace Mollie.WebApplicationCoreExample.Models {
    public class SubscriptionRequestModel {
        public string CustomerId { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public string Amount { get; set; }

        [Required]
        public string Description { get; set; }
    }
}