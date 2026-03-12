// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AssetClassAttributes1Choice
{
    /// <summary>
    /// Asset class is a non-financial instrument of type interest rate.
    /// </summary>
    [IsoId("_id4oJe94EeW7gabYEJmWIA")]
    [DisplayName("Interest")]
    public partial record Interest : AssetClassAttributes1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Currency in which leg 2 of the contract is denominated, in case of multi-currency or cross-currency swaps.
        /// Currency in which leg 2 of the swap is denominated, in case of swaptions where the underlying swap is multi-currency.
        /// </summary>
        [IsoId("_pqvkNcnYEeWpf-ImB_F2gQ")]
        [DisplayName("Other Notional Currency")]
        [IsoXmlTag("OthrNtnlCcy")]
        public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; } 
        
        
        #nullable disable
        
    }
}
