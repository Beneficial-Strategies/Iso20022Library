// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionReversalReason4Choice
{
    /// <summary>
    /// Standard code to specify the reason for the reversal.
    /// </summary>
    [IsoId("_ctOKNZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : CorporateActionReversalReason4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// The reason why a reversal of payment is taking place in corporate action processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionReversalReason1Code Value { get; init; }
    }
}
