// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionAndRepairReason26Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_0NImwTs_EeWRTLSN0i0tng")]
    [DisplayName("Code")]
    public partial record Code : RejectionAndRepairReason26Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the request has a rejected or repair status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason24Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
