// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName6Choice
{
    /// <summary>
    /// Provides the name that should be used where no ISIN or standardized name of the index exists, including its term (such as ‘EURIBOR6M’, ‘LIBOR3M’).
    /// </summary>
    [IsoId("_ZOcqRSc1EeaCIe3n1Gx9ug")]
    [DisplayName("Name")]
    public record Name : BenchmarkCurveName6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 25 characters.
        /// </summary>
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25, MinimumLength = 1)]
        public required IsoMax25Text Value { get; init; }
    }
}
