// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the cash amount and haircut or margin.
/// </summary>
[IsoId("_3b8rIP_-Eemefbt-QjTNnA")]
[DisplayName("Amount Haircut Margin")]
public record AmountHaircutMargin1
{
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_MiDiMP__Eemefbt-QjTNnA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection53 Amount { get; init; }

    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage.
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_QrRaUP__Eemefbt-QjTNnA")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HaircutOrMargin { get; init; }
}
