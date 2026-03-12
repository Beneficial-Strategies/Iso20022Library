// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionReversalReason5Choice
{
    /// <summary>
    /// Standard code to specify the reason for the reversal.
    /// </summary>
    [IsoId("_sJvG8TQVEe2o-K1dwNg8Gg")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionReversalReason5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why a reversal of payment is taking place in corporate action processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionReversalReason2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
