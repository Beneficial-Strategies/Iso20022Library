// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName10Choice
{
    /// <summary>
    /// Provides the name that should be used where no ISIN or standardised name of the index exists, including its term.
    /// </summary>
    [IsoId("_CWO6w6x2Eem81-uIvTF5rQ")]
    [DisplayName("Name")]
    public record Name : BenchmarkCurveName10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters.
        /// </summary>
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Value { get; init; }
    }
}
