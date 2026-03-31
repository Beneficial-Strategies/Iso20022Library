// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName13Choice
{
    /// <summary>
    /// Specifies the reference rate or basis rate on which a variable rate is base as a code.
    /// </summary>
    [IsoId("_hUVZgRIkEeyLzJfz3xPQNA")]
    [DisplayName("Code")]
    public record Code : BenchmarkCurveName13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BenchmarkCurveName7Code Value { get; init; }
    }
}
