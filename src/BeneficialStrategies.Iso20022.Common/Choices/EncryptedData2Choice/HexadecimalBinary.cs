// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EncryptedData2Choice
{
    /// <summary>
    /// Hexadecimal Binary.
    /// </summary>
    [DisplayName("Hexadecimal Binary")]
    public record HexadecimalBinary : EncryptedData2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("HexBinry")]
        public required IsoMax9999HexBinaryText Value { get; init; }
    }
}
