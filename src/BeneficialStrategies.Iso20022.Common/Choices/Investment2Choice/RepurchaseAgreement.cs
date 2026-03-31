// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Investment2Choice
{
    /// <summary>
    /// Repurchase Agreement.
    /// </summary>
    [DisplayName("Repurchase Agreement")]
    public record RepurchaseAgreement : Investment2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RpAgrmt")]
        public required RepurchaseAgreement2 Value { get; init; }
    }
}
