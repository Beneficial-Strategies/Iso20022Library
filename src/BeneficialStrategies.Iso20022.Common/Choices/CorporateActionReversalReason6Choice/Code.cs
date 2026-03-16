// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionReversalReason6Choice
{
    /// <summary>
    /// Standard code to specify the reason for the reversal.
    /// </summary>
    [IsoId("_TsubFF99Ee262vCSVgjImg")]
    [DisplayName("Code")]
    public record Code : CorporateActionReversalReason6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why a reversal of payment is taking place in corporate action processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionReversalReason2Code Value { get; init; }
    }
}
