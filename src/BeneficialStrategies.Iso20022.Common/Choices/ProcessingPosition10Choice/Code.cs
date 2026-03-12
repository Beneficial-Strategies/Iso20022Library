// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition10Choice
{
    /// <summary>
    /// Processing position expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_chT0r5KQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : ProcessingPosition10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing position.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingPosition3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
