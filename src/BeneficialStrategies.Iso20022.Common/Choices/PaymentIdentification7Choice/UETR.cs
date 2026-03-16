// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification7Choice
{
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_LMT0IQKzEe2X55dNQNVKfg")]
    [DisplayName("UETR")]
    public record UETR : PaymentIdentification7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Universally Unique IDentifier (UUID) version 4, as described in IETC RFC 4122 &quot;Universally Unique IDentifier (UUID) URN Namespace&quot;.
        /// </summary>
        [IsoXmlTag("UETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        public required IsoUUIDv4Identifier Value { get; init; }
    }
}
