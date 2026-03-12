// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice
{
    /// <summary>
    /// The ratio is expressed as an amount per quantity.
    /// </summary>
    [IsoId("_Rj3khtp-Ed-ak6NoX_4Aeg_1444513832")]
    [DisplayName("Amount To Quantity")]
    public partial record AmountToQuantity : RatioFormat2Choice_
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
