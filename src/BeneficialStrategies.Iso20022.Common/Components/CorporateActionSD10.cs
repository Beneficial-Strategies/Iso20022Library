// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_S9dVw2JhEeOfOt7Y7nAPUA")]
[DisplayName("Corporate Action SD")]
public record CorporateActionSD10
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_S9dVxGJhEeOfOt7Y7nAPUA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// DTC generated number to distinguish between the series of lotteries run against a particular redemption.
    /// </summary>
    [IsoId("_S9dVxWJhEeOfOt7Y7nAPUA")]
    [DisplayName("Lottery Sequence Number")]
    [IsoXmlTag("LtrySeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? LotterySequenceNumber { get; init; }

    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_sTkCZGJhEeOfOt7Y7nAPUA")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LotteryDate { get; init; }
}
