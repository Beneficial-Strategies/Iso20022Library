// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Risk tolerance target market.
/// </summary>
[IsoId("_FBVAgDcYEeidBoT_PugKiA")]
[DisplayName("Other Target Market Risk Tolerance")]
public record OtherTargetMarketRiskTolerance1
{
    /// <summary>
    /// Type of risk tolerance.
    /// </summary>
    [IsoId("_LouyUDcYEeidBoT_PugKiA")]
    [DisplayName("Risk Tolerance Type")]
    [IsoXmlTag("RskTlrnceTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RiskToleranceType { get; init; }

    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of risk tolerance.
    /// </summary>
    [IsoId("_MpBxsDcYEeidBoT_PugKiA")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    public TargetMarket1Choice_? Target { get; init; }

    /// <summary>
    /// Additional information about the target market and the investor&apos;s risk tolerance.
    /// </summary>
    [IsoId("_Q4UcoDcYEeidBoT_PugKiA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
