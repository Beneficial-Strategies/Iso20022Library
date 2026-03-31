// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Number2Choice
{
    /// <summary>
    /// Number of maximum 3 numeric text.
    /// </summary>
    [IsoId("_Qu0y5dp-Ed-ak6NoX_4Aeg_-630213750")]
    [DisplayName("Short")]
    public record Short : Number2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of 3 digits.
        /// </summary>
        [IsoXmlTag("Shrt")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        public required IsoExact3NumericText Value { get; init; }
    }
}
