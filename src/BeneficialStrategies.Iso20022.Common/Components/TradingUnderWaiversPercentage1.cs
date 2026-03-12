// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details for the trading under waiver of the instrument.
/// </summary>
[IsoId("__YT0wJuKEeaPcol5ibnfBQ")]
[DisplayName("Trading Under Waivers Percentage")]
public partial record TradingUnderWaiversPercentage1
{
    #nullable enable
    
    /// <summary>
    /// Total percentage of trading under waiver of the instrument in this specific reporting period on this trading venue.
    /// </summary>
    [IsoId("_V9BX0JuLEeaPcol5ibnfBQ")]
    [DisplayName("Trading Under Waiver Percentage")]
    [IsoXmlTag("TradgUdrWvrPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate TradingUnderWaiverPercentage { get; init; } 
    
    /// <summary>
    /// The venue this trading under waiver percentage is in relation to.
    /// </summary>
    [IsoId("_ri_asJuLEeaPcol5ibnfBQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public required IsoMICIdentifier TradingVenue { get; init; } 
    
    /// <summary>
    /// Information for interpreting the result.
    /// </summary>
    [IsoId("_wreiAJuMEeaPcol5ibnfBQ")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Disclaimer { get; init; } 
    
    
    #nullable disable
    
}
