// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceType5Choice
{
    /// <summary>
    /// Last reported price of a financial instrument in a market, determined by supply and demand.
    /// </summary>
    [IsoId("_SKL8Dc3yEee5nJBZsW8MFQ")]
    [DisplayName("Market")]
    public partial record Market : PriceType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_WimvZdp-Ed-ak6NoX_4Aeg_-1813914755")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required YieldedOrValueType1Choice_ Type { get; init; } 
        
        /// <summary>
        /// Value of the price, for example, as a currency and value.
        /// </summary>
        [IsoId("_WimvZtp-Ed-ak6NoX_4Aeg_373068769")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required PriceRateOrAmount1Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
