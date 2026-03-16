// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to cash and related informations used as a collateral.
/// </summary>
[IsoId("_AVJ6ta5jEeuo-IflVgGqiA")]
[DisplayName("Cash Compare")]
public record CashCompare3
{
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_AjwXYa5jEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public CompareAmountAndDirection2? Value { get; init; }

    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_AjwXY65jEeuo-IflVgGqiA")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    public ComparePercentageRate3? HaircutOrMargin { get; init; }
}
