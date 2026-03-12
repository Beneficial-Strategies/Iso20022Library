// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus7Choice
{
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_A6DC4dokEeC60axPepSq7g_597413673")]
    [DisplayName("Code")]
    public partial record Code : AffirmationStatus7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the affirmation status of a trade.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AffirmationStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
