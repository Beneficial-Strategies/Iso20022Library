// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SuspendedStatusReason5Choice
{
    /// <summary>
    /// Suspended reason expressed as a code.
    /// </summary>
    [IsoId("_o0mHQUHlEea8I67lh6qdSQ")]
    [DisplayName("Code")]
    public partial record Code : SuspendedStatusReason5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for a suspended status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SuspendedStatusReason3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
