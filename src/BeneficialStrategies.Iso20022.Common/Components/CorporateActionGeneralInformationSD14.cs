// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action general information details.
/// </summary>
[IsoId("_YTNCqGGJEeORiK3bBeBzGg")]
[DisplayName("Corporate Action General Information SD")]
public record CorporateActionGeneralInformationSD14
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_YTNCs2GJEeORiK3bBeBzGg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Unique number systemically assigned to all Lottery and Non-Lottery events announced in DTC Redemptions (REDS) Participant Terminal System (PTS)/ Particinant Browser System(PBS) function.
    /// </summary>
    [IsoId("_YTNCv2GJEeORiK3bBeBzGg")]
    [DisplayName("Redemption Identification")]
    [IsoXmlTag("RedId")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? RedemptionIdentification { get; init; }
}
