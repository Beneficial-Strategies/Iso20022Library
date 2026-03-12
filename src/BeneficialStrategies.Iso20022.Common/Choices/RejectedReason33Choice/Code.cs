// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedReason33Choice
{
    /// <summary>
    /// Rejected reason expressed as a code.
    /// </summary>
    [IsoId("_P7n1sQVHEeq4ZaI1b_-GPA")]
    [DisplayName("Code")]
    public partial record Code : RejectedReason33Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a transfer or settlement instruction rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectedStatusReason12Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
