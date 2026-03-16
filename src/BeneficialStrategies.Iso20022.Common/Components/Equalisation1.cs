// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
/// </summary>
[IsoId("_TToR8Np-Ed-ak6NoX_4Aeg_-2110798678")]
[DisplayName("Equalisation")]
public record Equalisation1
{
    /// <summary>
    /// Amount of money resulting from the calculation of the equalisation.
    /// </summary>
    [IsoId("_TToR8dp-Ed-ak6NoX_4Aeg_-2039690036")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Rate used for calculation of the equalisation.
    /// </summary>
    [IsoId("_TToR8tp-Ed-ak6NoX_4Aeg_-2039690011")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
