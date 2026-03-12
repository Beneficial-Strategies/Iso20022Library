// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestmentNeed2Choice
{
    /// <summary>
    /// Investment need expressed as a code.
    /// </summary>
    [IsoId("_bmAnM6DtEequlaOyi6MUhw")]
    [DisplayName("Code")]
    public partial record Code : InvestmentNeed2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an investment need.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentNeed2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
