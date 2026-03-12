// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MarginTerms1Choice
{
    /// <summary>
    /// Elements used to calculate the collateral margin call for the segregated independent amount.
    /// </summary>
    [IsoId("_QmogNNp-Ed-ak6NoX_4Aeg_1633105891")]
    [DisplayName("Segregated Independent Amount Margin")]
    public partial record SegregatedIndependentAmountMargin : MarginTerms1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of segregated independent amount).
        /// </summary>
        [IsoId("_UnXxwdp-Ed-ak6NoX_4Aeg_-1412205814")]
        [DisplayName("Minimum Transfer Amount")]
        [IsoXmlTag("MinTrfAmt")]
        public required ActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
        
        /// <summary>
        /// Amount specified to avoid the need to transfer uneven amounts of independent amount collateral.
        /// </summary>
        [IsoId("_UnXxwtp-Ed-ak6NoX_4Aeg_-756493516")]
        [DisplayName("Rounding Amount")]
        [IsoXmlTag("RndgAmt")]
        public ActiveCurrencyAndAmount? RoundingAmount { get; init; } 
        
        /// <summary>
        /// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
        /// </summary>
        [IsoId("_UnXxw9p-Ed-ak6NoX_4Aeg_-1527248442")]
        [DisplayName("Rounding Method")]
        [IsoXmlTag("RndgMtd")]
        public RoundingMethod1Code? RoundingMethod { get; init; } 
        
        
        #nullable disable
        
    }
}
