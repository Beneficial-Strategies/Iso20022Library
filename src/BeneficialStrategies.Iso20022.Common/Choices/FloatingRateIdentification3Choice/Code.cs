// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FloatingRateIdentification3Choice
{
    /// <summary>
    /// List of floating rate curves.
    /// </summary>
    [IsoId("_GRIIQQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Code")]
    public partial record Code : FloatingRateIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BenchmarkCurveName3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
