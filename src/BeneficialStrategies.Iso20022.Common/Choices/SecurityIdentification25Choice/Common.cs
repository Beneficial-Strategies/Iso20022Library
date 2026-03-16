// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
    /// </summary>
    [IsoId("_cH-V1znxEeabspMEjqY5TQ")]
    [DisplayName("Common")]
    public record Common : SecurityIdentification25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
        /// </summary>
        [IsoXmlTag("Cmon")]
        [IsoSimpleType(IsoSimpleType.EuroclearClearstreamIdentifier)]
        public required IsoEuroclearClearstreamIdentifier Value { get; init; }
    }
}
