// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdjustedBalanceTypeSD1Choice
{
    /// <summary>
    /// Repurchase agreement (REPO) between a seller and a buyer whereby the seller agrees to repurchase the securities at an agreed upon price, and usually at a stated time.
    /// </summary>
    [IsoId("_1hE45TL3EeKU9IrkkToqcw_-1292380363")]
    [DisplayName("Repo")]
    public partial record Repo : AdjustedBalanceTypeSD1Choice_
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
