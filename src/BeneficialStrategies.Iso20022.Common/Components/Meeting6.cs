// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the date and location(s) of a general meeting.
/// </summary>
[IsoId("_8FEVwfM6EeqRfth943bvEA")]
[DisplayName("Meeting")]
public partial record Meeting6
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_8Z26A_M6EeqRfth943bvEA")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required DateFormat58Choice_ DateAndTime { get; init; } 
    
    /// <summary>
    /// Status of the meeting date.
    /// </summary>
    [IsoId("_8Z26BfM6EeqRfth943bvEA")]
    [DisplayName("Date Status")]
    [IsoXmlTag("DtSts")]
    public MeetingDateStatus2Code? DateStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_8Z26B_M6EeqRfth943bvEA")]
    [DisplayName("Quorum Required")]
    [IsoXmlTag("QrmReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? QuorumRequired { get; init; } 
    
    /// <summary>
    /// Location at which the meeting will take place.
    /// </summary>
    [IsoId("_8Z26CfM6EeqRfth943bvEA")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<LocationFormat1Choice_> Location { get; init; } = [];
    
    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    [IsoId("_8Z26C_M6EeqRfth943bvEA")]
    [DisplayName("Quorum Quantity")]
    [IsoXmlTag("QrmQty")]
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_8Z26DfM6EeqRfth943bvEA")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; } 
    
    
    #nullable disable
    
}
