// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceType4Choice
{
    /// <summary>
    /// Estimated price, for valuation purposes.
    /// </summary>
    [IsoId("_y7Yrk7QBEee1Ke-6rZgsrA")]
    [DisplayName("Indicative")]
    public partial record Indicative : PriceType4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specification of the price type.
        /// </summary>
        [IsoId("_yehJYbQBEee1Ke-6rZgsrA")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required YieldedOrValueType1Choice_ Type { get; init; } 
        
        /// <summary>
        /// Value of the price, for example, as a currency and value.
        /// </summary>
        [IsoId("_yehJY7QBEee1Ke-6rZgsrA")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required PriceRateOrAmount3Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
