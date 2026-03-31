// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FloatingRateIdentification4Choice
{
    /// <summary>
    /// List of floating rate curves.
    /// </summary>
    [IsoId("_MBEjcSjFEeuKKc2MztSwPw")]
    [DisplayName("Code")]
    public record Code : FloatingRateIdentification4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BenchmarkCurveName5Code Value { get; init; }
    }
}
