// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction8Choice
{
    /// <summary>
    /// Interbank.
    /// </summary>
    [DisplayName("Interbank")]
    public record Interbank : UnderlyingTransaction8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IntrBk")]
        public required UnderlyingPaymentTransaction8 Value { get; init; }
    }
}
