// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Discounts or waivers to charges and commissions.
/// </summary>
[IsoId("_CXqF4YjMEeeqaMoyJI1HbA")]
[DisplayName("Charge Or Commission Discount")]
public record ChargeOrCommissionDiscount2
{
    /// <summary>
    /// Amount of discount or waiver.
    /// </summary>
    [IsoId("_CmiPY4jMEeeqaMoyJI1HbA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Rate of discount or waiver.
    /// </summary>
    [IsoId("_CmiPZYjMEeeqaMoyJI1HbA")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Form of the discount or rebate.
    /// </summary>
    [IsoId("_CmiPZ4jMEeeqaMoyJI1HbA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public WaivingInstruction2Choice_? Basis { get; init; }
}
