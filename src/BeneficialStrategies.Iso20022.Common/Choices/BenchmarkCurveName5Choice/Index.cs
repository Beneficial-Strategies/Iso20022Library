// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName5Choice
{
    /// <summary>
    /// Index name where the underlying is an index.
    /// </summary>
    [IsoId("_97LgsyrpEeWiy6-TnRWhpA")]
    [DisplayName("Index")]
    public record Index : BenchmarkCurveName5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Indx")]
        public required BenchmarkCurveName2Code Value { get; init; }
    }
}
