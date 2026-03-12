// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradingVenueType1Choice
{
    /// <summary>
    /// Whether the Securities Financing Transaction was concluded off-venue.
    /// </summary>
    [IsoId("_5_yR8Hy7Eeu1BeE84IrnAQ")]
    [DisplayName("Off Venue")]
    public partial record OffVenue : TradingVenueType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("OffVn")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
