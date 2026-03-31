// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EncryptedData1Choice
{
    /// <summary>
    /// Hexadecimal binary encoded encrypted data.
    /// </summary>
    [IsoId("_-on81ekLEemeDPHh-U9b6w")]
    [DisplayName("Hexadecimal Binary Value")]
    public record HexadecimalBinaryValue : EncryptedData1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 9999 binary bytes (19998 hexadecimal text characters).
        /// Used only for hex binary data only, supports only characters A-F and 0-9.
        /// </summary>
        [IsoXmlTag("HexBinryVal")]
        [IsoSimpleType(IsoSimpleType.Max9999HexBinaryText)]
        public required IsoMax9999HexBinaryText Value { get; init; }
    }
}
