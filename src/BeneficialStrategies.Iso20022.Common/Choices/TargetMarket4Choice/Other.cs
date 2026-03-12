// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TargetMarket4Choice
{
    /// <summary>
    /// Specifies whether the financial product is in scope of the target market parameter.
    /// </summary>
    [IsoId("_ufTVMNdhEeibyvRfU9vJ7w")]
    [DisplayName("Other")]
    public partial record Other : TargetMarket4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether a financial product is in scope of a target market parameter.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required TargetMarket1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
