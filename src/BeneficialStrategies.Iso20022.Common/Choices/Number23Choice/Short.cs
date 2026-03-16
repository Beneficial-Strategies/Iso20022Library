// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Number23Choice
{
    /// <summary>
    /// Number of maximum 3 numeric text.
    /// </summary>
    [IsoId("_5NbJpZNLEeWGlc8L7oPDIg")]
    [DisplayName("Short")]
    public record Short : Number23Choice_
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
