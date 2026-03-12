// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason23Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_M6X9cekHEemm4qhb2yFPOw")]
    [DisplayName("Code")]
    public partial record Code : AcknowledgementReason23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about a processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
