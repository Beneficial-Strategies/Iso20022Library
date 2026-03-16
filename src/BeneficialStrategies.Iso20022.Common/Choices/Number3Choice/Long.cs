// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Number3Choice
{
    /// <summary>
    /// Number of maximum 5 numeric text. Is only to be used in a delta statement.
    /// </summary>
    [IsoId("_QrP6dtp-Ed-ak6NoX_4Aeg_1752980794")]
    [DisplayName("Long")]
    public record Long : Number3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of 5 digits.
        /// </summary>
        [IsoXmlTag("Lng")]
        [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
        public required IsoExact5NumericText Value { get; init; }
    }
}
