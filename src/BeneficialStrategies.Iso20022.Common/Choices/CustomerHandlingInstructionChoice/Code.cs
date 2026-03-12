// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CustomerHandlingInstructionChoice
{
    /// <summary>
    /// Customer handling instruction is defined using a code.
    /// </summary>
    [IsoId("_Q-K2dNp-Ed-ak6NoX_4Aeg_-1440303164")]
    [DisplayName("Code")]
    public partial record Code : CustomerHandlingInstructionChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Firms that are taking in orders manually but routing for execution electronically and for reporting to OATS must capture the client&apos;s handling instructions.This is intended for compliance reporting only ( OATS Phase III regulatory requirement).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CustomerHandlingInstructions1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
