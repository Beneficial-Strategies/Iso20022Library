// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName6Choice
{
    /// <summary>
    /// Name of the index / benchmark of a floating rate bond.
    /// </summary>
    [IsoId("_ZOcqQyc1EeaCIe3n1Gx9ug")]
    [DisplayName("Index")]
    public partial record Index : BenchmarkCurveName6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Indx")]
        public required BenchmarkCurveName2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
