// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName13Choice
{
    /// <summary>
    /// Specifies the reference rate or basis rate on which a variable rate is base as a code.
    /// </summary>
    [IsoId("_hUVZgRIkEeyLzJfz3xPQNA")]
    [DisplayName("Code")]
    public partial record Code : BenchmarkCurveName13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BenchmarkCurveName7Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
