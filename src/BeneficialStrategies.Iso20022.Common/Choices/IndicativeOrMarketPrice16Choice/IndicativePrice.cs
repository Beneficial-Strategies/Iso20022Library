// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IndicativeOrMarketPrice16Choice
{
    /// <summary>
    /// Indicative Price.
    /// </summary>
    [DisplayName("Indicative Price")]
    public partial record IndicativePrice : IndicativeOrMarketPrice16Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IndctvPric")]
        public required PriceFormat85Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
