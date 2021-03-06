﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public string DateOfIncident { get; set; }
        public string DateOfClaim { get; set; }
        public bool IsValid { get; set; }
    
        public Claim(int id, string type, string description, decimal claimAmount, string dateOfIncident, string dateOfClaim, bool isValid)
        {
            ClaimID = id;
            Type = type;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
        public Claim()
        {

        }
        public override string ToString()
        {
            return $"Claim ID: {ClaimID}\n" +
                $"Type: {Type}\n" +
                $"Description: {Description}\n" +
                $"Amount: {ClaimAmount:c}\n" +
                $"Date of Incident: {DateOfIncident}\n" +
                $"Date of Claim: {DateOfClaim}\n" +
                $"Valid: {IsValid}\n";
        }


    }
                            
}
