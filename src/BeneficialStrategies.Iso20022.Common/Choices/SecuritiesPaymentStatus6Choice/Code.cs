// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesPaymentStatus6Choice
{
    /// <summary>
    /// Securities payment status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5NZ7qZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : SecuritiesPaymentStatus6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the state of payment of a security at a particular time.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesPaymentStatus1Code Value { get; init; }
    }
}
