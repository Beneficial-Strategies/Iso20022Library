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
[IsoId("_vfrsRWG1EeORiK3bBeBzGg")]
[DisplayName("Corporate Action SD")]
public record CorporateActionSD8
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_6JqisWG1EeORiK3bBeBzGg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// DTC generated number to distinguish between the series of lotteries run against a particular redemption.
    /// </summary>
    [IsoId("_Q8ahwGG2EeORiK3bBeBzGg")]
    [DisplayName("Lottery Sequence Number")]
    [IsoXmlTag("LtrySeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? LotterySequenceNumber { get; init; }
}
