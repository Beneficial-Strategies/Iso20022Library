// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReconciliationMatchedStatus6Choice
{
    /// <summary>
    /// Indication that the reports subject of reconciliation match.
    /// </summary>
    [IsoId("_C44f8f_oEemm3skPVSMJQg")]
    [DisplayName("Matched")]
    public partial record Matched : ReconciliationMatchedStatus6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Mtchd")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
