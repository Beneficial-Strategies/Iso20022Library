// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Registration6Choice
{
    /// <summary>
    /// Registration information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AZjk9dokEeC60axPepSq7g_-99947924")]
    [DisplayName("Code")]
    public partial record Code : Registration6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether registration should occur upon receipt.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Registration1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
