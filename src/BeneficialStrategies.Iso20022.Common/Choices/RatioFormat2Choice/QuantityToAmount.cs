// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice
{
    /// <summary>
    /// Ratio is expressed as a quantity per an amount.
    /// </summary>
    [IsoId("_Rj3kh9p-Ed-ak6NoX_4Aeg_1484223303")]
    [DisplayName("Quantity To Amount")]
    public partial record QuantityToAmount : RatioFormat2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_UH8Dx9p-Ed-ak6NoX_4Aeg_1626446913")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        
        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_UH8DyNp-Ed-ak6NoX_4Aeg_1641222331")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
