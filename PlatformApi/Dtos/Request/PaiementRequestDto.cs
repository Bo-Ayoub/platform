﻿using PlatformApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlatformApi.Dtos.Request
{
    public class PaiementRequestDto
    {
        public DateTime datepaiement { get; set; }
        public Vendeur vendeur { get; set; }

        [ForeignKey("Vendeur")]
        public int VendeurId { get; set; }
        public string PaymentMethod { get; set; }

        [ForeignKey("PlanPaiement")]
        public int PlanPaiementId { get; set; }

        public PlanPaiement PlanPaiement { get; set; }
    }
}
