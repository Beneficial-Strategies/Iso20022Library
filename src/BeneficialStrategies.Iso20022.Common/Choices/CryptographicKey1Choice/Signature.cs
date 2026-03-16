// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice
{
    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    public record Signature : CryptographicKey1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Sgntr")]
        public required IsoSHA256SignatureText Value { get; init; }
    }
}
