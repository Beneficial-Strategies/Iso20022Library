// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Number3Choice
{
    /// <summary>
    /// Number of maximum 3 numeric text.
    /// </summary>
    [IsoId("_QrP6ddp-Ed-ak6NoX_4Aeg_-969476750")]
    [DisplayName("Short")]
    public partial record Short : Number3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of 3 digits.
        /// </summary>
        [IsoXmlTag("Shrt")]
        [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
        public required IsoExact3NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
