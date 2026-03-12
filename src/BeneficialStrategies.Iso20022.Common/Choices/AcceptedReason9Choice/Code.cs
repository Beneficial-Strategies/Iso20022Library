// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason9Choice
{
    /// <summary>
    /// Standard code to specify additional information about the processed instruction.
    /// </summary>
    [IsoId("_LtxaMTt6EeW638lNyHKv7A")]
    [DisplayName("Code")]
    public partial record Code : AcceptedReason9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason8Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
