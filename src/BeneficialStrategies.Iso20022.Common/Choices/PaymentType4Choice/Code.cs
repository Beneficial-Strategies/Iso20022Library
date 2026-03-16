// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentType4Choice
{
    /// <summary>
    /// Type, or nature, of the payment, such as express payment.|.
    /// </summary>
    [IsoId("_K7v_8RbwEeOy-PlRuFSUzQ")]
    [DisplayName("Code")]
    public record Code : PaymentType4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type, or nature, of the payment.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentType3Code Value { get; init; }
    }
}
