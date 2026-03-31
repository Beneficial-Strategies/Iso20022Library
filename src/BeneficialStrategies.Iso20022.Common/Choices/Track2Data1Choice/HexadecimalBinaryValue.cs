// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Track2Data1Choice
{
    /// <summary>
    /// Value of track 2 data expressed in a hex binary form.
    /// Binary, length of 19 with maximum 37 hexadecimal text characters.
    /// When an odd number of hexadecimal text characters is present, a zero must be appended to the end of the string to pad to an even number of hexadecimal text characters.
    /// </summary>
    [IsoId("_jYXPMd8aEeeNTcLLmuYy-w")]
    [DisplayName("Hexadecimal Binary Value")]
    public record HexadecimalBinaryValue : Track2Data1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 19 binary bytes (38 hexadecimal text characters).
        /// Used only for hex binary data only, supports only characters A-F and 0-9.
        /// </summary>
        [IsoXmlTag("HexBinryVal")]
        [IsoSimpleType(IsoSimpleType.Max19HexBinaryText)]
        public required IsoMax19HexBinaryText Value { get; init; }
    }
}
