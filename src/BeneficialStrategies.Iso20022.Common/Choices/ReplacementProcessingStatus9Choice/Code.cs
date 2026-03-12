// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReplacementProcessingStatus9Choice
{
    /// <summary>
    /// Provides the processing status of the replacement request.
    /// </summary>
    [IsoId("_8QcPa5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : ReplacementProcessingStatus9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the processing status of the replacement request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ReplacementProcessingStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
