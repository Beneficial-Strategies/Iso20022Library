// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other target market parameter.
/// </summary>
[IsoId("_d1KFQD8VEeih8-WNbS6hbA")]
[DisplayName("Other Target Market")]
public record OtherTargetMarket1
{
    /// <summary>
    /// Type of target market parameter.
    /// </summary>
    [IsoId("_lV2PgD8VEeih8-WNbS6hbA")]
    [DisplayName("Target Market Type")]
    [IsoXmlTag("TrgtMktTp")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text TargetMarketType { get; init; }

    /// <summary>
    /// Additional information about the target market.
    /// </summary>
    [IsoId("_qN1SIT8VEeih8-WNbS6hbA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
