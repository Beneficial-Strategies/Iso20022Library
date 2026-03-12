// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD1Choice
{
    /// <summary>
    /// Securities undelivered (FAIL) transaction position. FAIL occurs due to the failure of selling clients to deliver the securities to their brokers so the latter can deliver them to the buying brokers.  .
    /// </summary>
    [IsoId("_1hOp4DL3EeKU9IrkkToqcw_792720376")]
    [DisplayName("Fail")]
    public partial record Fail : AdjustedBalanceTypeSD1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_XXqIGNp-Ed-ak6NoX_4Aeg_-1296276978")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_XXqIGdp-Ed-ak6NoX_4Aeg_1296503350")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
