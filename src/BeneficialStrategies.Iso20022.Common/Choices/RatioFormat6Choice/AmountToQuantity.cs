// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat6Choice
{
    /// <summary>
    /// Ratio expressed as an amount to quantity ratio.
    /// </summary>
    [IsoId("_Q1-jydp-Ed-ak6NoX_4Aeg_-1315079997")]
    [DisplayName("Amount To Quantity")]
    public partial record AmountToQuantity : RatioFormat6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_UHySzdp-Ed-ak6NoX_4Aeg_1510604904")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_UHySztp-Ed-ak6NoX_4Aeg_1510604921")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
