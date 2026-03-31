// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice
{
    /// <summary>
    /// ILPV4.
    /// </summary>
    [DisplayName("ILPV4")]
    public record ILPV4 : CryptographicKey1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ILPV4")]
        public required IsoHexBinaryText Value { get; init; }
    }
}
