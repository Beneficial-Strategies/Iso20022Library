// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification38Choice
{
    /// <summary>
    /// Ticker Symbol.
    /// </summary>
    [DisplayName("Ticker Symbol")]
    public partial record TickerSymbol : SecurityIdentification38Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TckrSymb")]
        public required IsoTickerIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
