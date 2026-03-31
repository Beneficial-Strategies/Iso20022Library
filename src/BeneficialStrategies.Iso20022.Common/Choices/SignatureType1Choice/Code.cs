// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SignatureType1Choice
{
    /// <summary>
    /// Signature type expressed as a code.
    /// </summary>
    [IsoId("_rszToDoHEeabspMEjqY5TQ")]
    [DisplayName("Code")]
    public record Code : SignatureType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of signature.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SignatureType2Code Value { get; init; }
    }
}
