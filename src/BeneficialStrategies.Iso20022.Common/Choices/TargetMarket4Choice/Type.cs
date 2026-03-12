// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TargetMarket4Choice
{
    /// <summary>
    /// Specifies how the financial product is in scope of the target market parameter.
    /// </summary>
    [IsoId("_tt5tcNdhEeibyvRfU9vJ7w")]
    [DisplayName("Type")]
    public partial record Type : TargetMarket4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investor.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required InvestorType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
