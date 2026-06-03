// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of lottery event.
/// </summary>
[IsoId("_ogGV4JSbEfCQbtmJ-bHX4Q")]
[DisplayName("Corporate Action Lottery Event1")]
public record CorporateActionLotteryEvent1
{
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_FCtawJScEfCQbtmJ-bHX4Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public LotteryTypeFormat4Choice_? Type { get; init; }

    /// <summary>
    /// Details the lottery feature.
    /// </summary>
    [IsoId("_bWIZgJScEfCQbtmJ-bHX4Q")]
    [DisplayName("Feature Type")]
    [IsoXmlTag("FeatrTp")]
    public LotteryFeatureType1Code? FeatureType { get; init; }
}
