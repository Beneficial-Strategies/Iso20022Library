// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReport33Choice
{
    /// <summary>
    /// Port Out.
    /// </summary>
    [DisplayName("Port Out")]
    public partial record PortOut : TradeReport33Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PortOut")]
        public required TradeData43 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
