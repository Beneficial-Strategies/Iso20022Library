// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber17Choice
{
    /// <summary>
    /// Message type number of the document referenced.
    /// </summary>
    [IsoId("_dPmKtZBgEeakHoV5BVecAQ")]
    [DisplayName("Short Number")]
    public record ShortNumber : DocumentNumber17Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of 3 digits.
        /// </summary>
        [IsoXmlTag("ShrtNb")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        public required IsoExact3NumericText Value { get; init; }
    }
}
