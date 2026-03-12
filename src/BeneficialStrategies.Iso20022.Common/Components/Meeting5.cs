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
[IsoId("_l-Zlq609EemDtrWpq90Ckg")]
[DisplayName("Meeting")]
public partial record Meeting5
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_mThhFa09EemDtrWpq90Ckg")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required DateFormat58Choice_ DateAndTime { get; init; } 
    
    /// <summary>
    /// Status of the meeting date.
    /// </summary>
    [IsoId("_mThhF609EemDtrWpq90Ckg")]
    [DisplayName("Date Status")]
    [IsoXmlTag("DtSts")]
    public MeetingDateStatus2Code? DateStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_mThhGa09EemDtrWpq90Ckg")]
    [DisplayName("Quorum Required")]
    [IsoXmlTag("QrmReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator QuorumRequired { get; init; } 
    
    /// <summary>
    /// Location at which the meeting will take place.
    /// </summary>
    [IsoId("_mThhG609EemDtrWpq90Ckg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<LocationFormat1Choice_> Location { get; init; } = new ValueList<LocationFormat1Choice_>(){};
    
    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    [IsoId("_mThhHa09EemDtrWpq90Ckg")]
    [DisplayName("Quorum Quantity")]
    [IsoXmlTag("QrmQty")]
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_Hp_Wga0-EemDtrWpq90Ckg")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; } 
    
    
    #nullable disable
    
}
