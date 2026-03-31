// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName4Choice
{
    /// <summary>
    /// Where no identifier exists, standardized name of the index, including its term (such as ‘EURIBOR6M’, ‘LIBOR3M’).
    /// </summary>
    [IsoId("_1yco4wnVEeWa7rBfPECYsw")]
    [DisplayName("Name")]
    public record Name : BenchmarkCurveName4Choice_
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
