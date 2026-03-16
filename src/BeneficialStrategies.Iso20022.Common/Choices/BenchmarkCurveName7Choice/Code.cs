// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName7Choice
{
    /// <summary>
    /// Benchmark curve name expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_HjJ1weLwEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public record Code : BenchmarkCurveName7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BenchmarkCurveName1Code Value { get; init; }
    }
}
