// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the physical parameters of a shareholders meeting. Several dates and places can be defined for a meeting.
/// </summary>
[IsoId("_S8SuwVuAEeSmO6RkXg92Lg")]
[DisplayName("Meeting")]
public record Meeting4
{
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TapetVuAEeSmO6RkXg92Lg")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required DateFormat29Choice_ DateAndTime { get; init; }

    /// <summary>
    /// Indicates the status of the meeting date.
    /// </summary>
    [IsoId("_Tapet1uAEeSmO6RkXg92Lg")]
    [DisplayName("Date Status")]
    [IsoXmlTag("DtSts")]
    public MeetingDateStatus1Code? DateStatus { get; init; }

    /// <summary>
    /// Specifies whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_TapeuVuAEeSmO6RkXg92Lg")]
    [DisplayName("Quorum Required")]
    [IsoXmlTag("QrmReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator QuorumRequired { get; init; }

    /// <summary>
    /// Specifies the location where meeting will take place.
    /// </summary>
    [IsoId("_Tapeu1uAEeSmO6RkXg92Lg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<LocationFormat1Choice_> Location { get; init; } = [];

    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    [IsoId("_TapevVuAEeSmO6RkXg92Lg")]
    [DisplayName("Quorum Quantity")]
    [IsoXmlTag("QrmQty")]
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; }
}
