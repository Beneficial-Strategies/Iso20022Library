// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat5Choice
{
    /// <summary>
    /// Provide not eligible balance information in different formats.
    /// </summary>
    [IsoId("_kvec4Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Not Eligible Balance")]
    public partial record NotEligibleBalance : BalanceFormat5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_k7YK0zq5EeWQ1Y7f8kds2A")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public required ShortLong1Code ShortLongPosition { get; init; } 
        
        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_k7YK1Tq5EeWQ1Y7f8kds2A")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}
