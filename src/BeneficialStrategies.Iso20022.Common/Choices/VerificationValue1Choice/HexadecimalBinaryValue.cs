// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VerificationValue1Choice
{
    /// <summary>
    /// Value of the data expressed in hexadecimal encoded binary form.
    /// </summary>
    [IsoId("_4EhKqJaNEemfCcEf5rVTyg")]
    [DisplayName("Hexadecimal Binary Value")]
    public record HexadecimalBinaryValue : VerificationValue1Choice_
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
