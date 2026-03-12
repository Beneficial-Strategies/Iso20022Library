// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceType2Choice
{
    /// <summary>
    /// Estimated price, for valuation purposes.
    /// </summary>
    [IsoId("_XLcRB9p-Ed-ak6NoX_4Aeg_-1042385228")]
    [DisplayName("Indicative")]
    public partial record Indicative : PriceType2Choice_
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
