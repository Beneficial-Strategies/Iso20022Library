// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat17Choice
{
    /// <summary>
    /// Ratio expressed as a quotient of amounts.
    /// </summary>
    [IsoId("_vc05p0EKEeWVgfuHGaKtRQ")]
    [DisplayName("Amount To Amount")]
    public partial record AmountToAmount : RatioFormat17Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Numerator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHohytp-Ed-ak6NoX_4Aeg_1560297783")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt1")]
        public required ActiveCurrencyAnd13DecimalAmount Amount1 { get; init; } 
        
        /// <summary>
        /// Denominator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHohy9p-Ed-ak6NoX_4Aeg_1248536401")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt2")]
        public required ActiveCurrencyAnd13DecimalAmount Amount2 { get; init; } 
        
        
        #nullable disable
        
    }
}
