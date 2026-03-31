// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maximum amount allowed over a specific period of time.
/// </summary>
[IsoId("_Qotj09p-Ed-ak6NoX_4Aeg_540897")]
[DisplayName("Maximum Amount By Period")]
public record MaximumAmountByPeriod1
{
    /// <summary>
    /// Maximum amount allowed over a specific period of time.
    /// </summary>
    [IsoId("_Qotj1Np-Ed-ak6NoX_4Aeg_-998319567")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public required ActiveCurrencyAndAmount MaximumAmount { get; init; }

    /// <summary>
    /// Period specified as a number of days.
    /// </summary>
    [IsoId("_Qotj1dp-Ed-ak6NoX_4Aeg_1020263959")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText NumberOfDays { get; init; }
}
