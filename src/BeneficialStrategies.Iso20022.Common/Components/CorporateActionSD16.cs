// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_RM6gQZFCEeanIpS4qvJ1tw")]
[DisplayName("Corporate Action SD")]
public partial record CorporateActionSD16
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_RmW7AZFCEeanIpS4qvJ1tw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// DTC generated number to distinguish between the series of lotteries run against a particular redemption.
    /// </summary>
    [IsoId("_RmW7A5FCEeanIpS4qvJ1tw")]
    [DisplayName("Lottery Sequence Number")]
    [IsoXmlTag("LtrySeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? LotterySequenceNumber { get; init; } 
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_RmW7BZFCEeanIpS4qvJ1tw")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LotteryDate { get; init; } 
    
    /// <summary>
    /// For Reorganization events, date at which instructions will be accepted by agent for payment.
    /// </summary>
    [IsoId("_cm9hsJFCEeanIpS4qvJ1tw")]
    [DisplayName("Process To Date")]
    [IsoXmlTag("PrcToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProcessToDate { get; init; } 
    
    
    #nullable disable
    
}
