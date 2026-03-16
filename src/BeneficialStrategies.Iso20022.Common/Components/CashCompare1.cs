// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to cash and related fields used as a collateral.
/// </summary>
[IsoId("_kl1m0dMGEem1A4OOmCK97A")]
[DisplayName("Cash Compare")]
public record CashCompare1
{
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_qdgk0NMGEem1A4OOmCK97A")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required CompareAmountAndDirection1 Value { get; init; }

    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_3kK5ENMGEem1A4OOmCK97A")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    public required ComparePercentageRate2 HaircutOrMargin { get; init; }
}
