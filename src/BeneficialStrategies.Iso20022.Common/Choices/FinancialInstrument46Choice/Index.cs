// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument46Choice
{
    /// <summary>
    /// Name of the index on which the financial instrument is based.
    /// </summary>
    [IsoId("_X1A7UL38EeWvRsMSLyTf-A")]
    [DisplayName("Index")]
    public record Index : FinancialInstrument46Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Indx")]
        public required BenchmarkCurveName2Code Value { get; init; }
    }
}
