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
[IsoId("_TKPsc9p-Ed-ak6NoX_4Aeg_1339167407")]
[DisplayName("Meeting")]
public record Meeting3
{
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TKPsdNp-Ed-ak6NoX_4Aeg_1339167469")]
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required DateFormat2Choice_ DateAndTime { get; init; }

    /// <summary>
    /// Indicates the status of a meeting date.
    /// </summary>
    [IsoId("_TKPsddp-Ed-ak6NoX_4Aeg_1339167530")]
    [DisplayName("Date Status")]
    [IsoXmlTag("DtSts")]
    public MeetingDateStatus1Code? DateStatus { get; init; }

    /// <summary>
    /// Specifies whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_TKPsdtp-Ed-ak6NoX_4Aeg_1339167561")]
    [DisplayName("Quorum Required")]
    [IsoXmlTag("QrmReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator QuorumRequired { get; init; }

    /// <summary>
    /// Specifies location where meeting will take place.
    /// </summary>
    [IsoId("_TKPsd9p-Ed-ak6NoX_4Aeg_1339167932")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<LocationFormat1Choice_> Location { get; init; } = [];

    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    [IsoId("_TKPseNp-Ed-ak6NoX_4Aeg_1339167622")]
    [DisplayName("Quorum Quantity")]
    [IsoXmlTag("QrmQty")]
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; }
}
