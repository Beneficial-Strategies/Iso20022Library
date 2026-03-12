// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat14Choice
{
    /// <summary>
    /// Provide not eligible balance information in different formats.
    /// </summary>
    [IsoId("_piui8Ti7Eeydid5dcNPKvg")]
    [DisplayName("Not Eligible Balance")]
    public partial record NotEligibleBalance : BalanceFormat14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_pf0_XTi7Eeydid5dcNPKvg")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_pf0_Xzi7Eeydid5dcNPKvg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity36Choice_ Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
