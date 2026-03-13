// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the physical parameters of a shareholders meeting. Several dates and places can be defined for a meeting.
/// </summary>
[IsoId("_TKY2Y9p-Ed-ak6NoX_4Aeg_795834246")]
[DisplayName("Meeting")]
public partial record Meeting2
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TKY2ZNp-Ed-ak6NoX_4Aeg_795834504")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required DateFormat2Choice_ DateAndTime { get; init; } 
    
    /// <summary>
    /// Indicates the status of a meeting date.
    /// </summary>
    [IsoId("_TKY2Zdp-Ed-ak6NoX_4Aeg_795834512")]
    [DisplayName("Date Status")]
    [IsoXmlTag("DtSts")]
    public MeetingDateStatus1Code? DateStatus { get; init; } 
    
    /// <summary>
    /// Specifies whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_TKY2Ztp-Ed-ak6NoX_4Aeg_795834537")]
    [DisplayName("Quorum Required")]
    [IsoXmlTag("QrmReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator QuorumRequired { get; init; } 
    
    /// <summary>
    /// Specifies location where meeting will take place.
    /// </summary>
    [IsoId("_TKY2Z9p-Ed-ak6NoX_4Aeg_205631143")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<LocationFormat1Choice_> Location { get; init; } = [];
    
    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    [IsoId("_TKY2aNp-Ed-ak6NoX_4Aeg_795834554")]
    [DisplayName("Quorum Quantity")]
    [IsoXmlTag("QrmQty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuorumQuantity { get; init; } 
    
    /// <summary>
    /// Minimum quantity of securities, expressed as a percentage, required to hold a meeting.
    /// </summary>
    [IsoId("_TKY2adp-Ed-ak6NoX_4Aeg_795834597")]
    [DisplayName("Quorum Quantity Percentage")]
    [IsoXmlTag("QrmQtyPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? QuorumQuantityPercentage { get; init; } 
    
    
    #nullable disable
    
}
