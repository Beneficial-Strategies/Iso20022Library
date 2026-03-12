// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnitPriceType1Choice
{
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_RfZ7Q9p-Ed-ak6NoX_4Aeg_1241168218")]
    [DisplayName("Type")]
    public partial record Type : UnitPriceType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of price and information about the price.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required TypeOfPrice13Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
