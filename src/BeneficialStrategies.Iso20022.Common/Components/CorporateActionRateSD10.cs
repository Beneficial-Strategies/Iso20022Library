// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
[IsoId("_IeDD4b5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Rate SD")]
public record CorporateActionRateSD10
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_IuabIb5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Corresponding rate of the security being disbursed as a result of the corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_IuabI75XEeexmbB7KsjCwA")]
    [DisplayName("Declared Security Rate")]
    [IsoXmlTag("DclrdSctyRate")]
    public CorporateActionRateSD7Choice_? DeclaredSecurityRate { get; init; }

    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_IuabMb5XEeexmbB7KsjCwA")]
    [DisplayName("Estimated Rate Flag")]
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; }

    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_IuabOb5XEeexmbB7KsjCwA")]
    [DisplayName("Declared Fee Rate")]
    [IsoXmlTag("DclrdFeeRate")]
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; }
}
