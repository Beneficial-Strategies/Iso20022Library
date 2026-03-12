// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName7Choice
{
    /// <summary>
    /// Benchmark curve name expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_HjJ1weLwEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public partial record Code : BenchmarkCurveName7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BenchmarkCurveName1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
