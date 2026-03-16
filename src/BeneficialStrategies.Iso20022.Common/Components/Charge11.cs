// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_VIwAiNp-Ed-ak6NoX_4Aeg_2085827171")]
[DisplayName("Charge")]
public record Charge11
{
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_VIwAidp-Ed-ak6NoX_4Aeg_2085827369")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_VIwAitp-Ed-ak6NoX_4Aeg_2085827352")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }

    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_VI5xgNp-Ed-ak6NoX_4Aeg_2085827309")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType1 Type { get; init; }
}
