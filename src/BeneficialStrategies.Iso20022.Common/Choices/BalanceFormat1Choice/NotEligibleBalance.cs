// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat1Choice
{
    /// <summary>
    /// Provide not eligible balance information in different formats.
    /// </summary>
    [IsoId("_Q0yQ8Np-Ed-ak6NoX_4Aeg_1869615867")]
    [DisplayName("Not Eligible Balance")]
    public partial record NotEligibleBalance : BalanceFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_Q0VlBtp-Ed-ak6NoX_4Aeg_-1839841874")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_Q0VlB9p-Ed-ak6NoX_4Aeg_838699823")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
