// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepairReason19Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_hP47sQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Code")]
    public partial record Code : RepairReason19Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction is in repair.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepairReason7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
