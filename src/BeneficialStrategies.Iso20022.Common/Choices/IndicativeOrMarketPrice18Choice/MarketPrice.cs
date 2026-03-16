// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice18Choice
{
    /// <summary>
    /// Market Price.
    /// </summary>
    [DisplayName("Market Price")]
    public partial record MarketPrice : IndicativeOrMarketPrice18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("MktPric")]
        public required PriceFormat92Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
