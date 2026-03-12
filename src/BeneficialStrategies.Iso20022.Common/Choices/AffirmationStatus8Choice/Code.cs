// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AffirmationStatus8Choice
{
    /// <summary>
    /// Provides the status of the trade at confirmation level at the time the settlement instruction was sent.
    /// </summary>
    [IsoId("_8nU2ATqpEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public partial record Code : AffirmationStatus8Choice_
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
