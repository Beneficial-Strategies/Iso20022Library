// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, for example, RTR.L for Reuters quoted in London.
    /// </summary>
    [IsoId("_CSq4OyGQEeW7gKYhAMEFCw")]
    [DisplayName("Ticker Symbol")]
    public partial record TickerSymbol : SecurityIdentification23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Letters that identify a stock traded on a stock exchange. The Ticker Symbol is a short and convenient way of identifying a stock, for example, RTR.L for Reuters quoted in London.
        /// </summary>
        [IsoXmlTag("TckrSymb")]
        [IsoSimpleType(IsoSimpleType.TickerIdentifier)]
        public required IsoTickerIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
