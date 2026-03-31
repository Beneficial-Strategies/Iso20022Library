// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Meeting7.
/// </summary>
[IsoId("_hzqvsZK5Ee-l-O3vIHRmRw")]
[DisplayName("Meeting7")]
public record Meeting7
{
    /// <summary>
    /// Date And Time.
    /// </summary>
    [DisplayName("Date And Time")]
    [IsoXmlTag("DtAndTm")]
    public required DateFormat58Choice_ DateAndTime { get; init; }

    /// <summary>
    /// Date Status.
    /// </summary>
    [DisplayName("Date Status")]
    [IsoXmlTag("DtSts")]
    public MeetingDateStatus2Code? DateStatus { get; init; }

    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public required LocationFormat1Choice_ Location { get; init; }

    /// <summary>
    /// Quorum Quantity.
    /// </summary>
    [DisplayName("Quorum Quantity")]
    [IsoXmlTag("QrmQty")]
    public QuorumQuantity2Choice_? QuorumQuantity { get; init; }

    /// <summary>
    /// Quorum Required.
    /// </summary>
    [DisplayName("Quorum Required")]
    [IsoXmlTag("QrmReqrd")]
    public IsoYesNoIndicator? QuorumRequired { get; init; }

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public IsoMax2048Text? URLAddress { get; init; }
}
