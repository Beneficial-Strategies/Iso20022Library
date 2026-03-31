// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReferenceValue1Choice
{
    /// <summary>
    /// Universally Unique IDentifier (UUID) version 4.
    /// </summary>
    [IsoId("_lTDZIMePEeysUoBKYz1Ytw")]
    [DisplayName("UUID")]
    public record UUID : ReferenceValue1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Universally Unique IDentifier (UUID) version 4, as described in IETC RFC 4122 &quot;Universally Unique IDentifier (UUID) URN Namespace&quot;.
        /// </summary>
        [IsoXmlTag("UUID")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        public required IsoUUIDv4Identifier Value { get; init; }
    }
}
