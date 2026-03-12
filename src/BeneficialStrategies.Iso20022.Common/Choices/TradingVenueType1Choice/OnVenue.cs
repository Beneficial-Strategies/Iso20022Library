// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradingVenueType1Choice
{
    /// <summary>
    /// Whether the Securities Financing Transaction was concluded on a domestic trading venue or a foregin trading venue.
    /// </summary>
    [IsoId("_upJw4Hy7Eeu1BeE84IrnAQ")]
    [DisplayName("On Venue")]
    public partial record OnVenue : TradingVenueType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a code for a trade market.
        /// </summary>
        [IsoXmlTag("OnVn")]
        public required TradeMarket2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
