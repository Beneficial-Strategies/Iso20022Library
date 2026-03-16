// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the type and amount of the cash reinvestment in a given currency.
/// </summary>
[IsoId("_08jc8JLiEeelrYORFsXWZg")]
[DisplayName("Reinvested Cash Type And Amount")]
public record ReinvestedCashTypeAndAmount1
{
    /// <summary>
    /// Provides details on the type of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_TpPMsJLjEeelrYORFsXWZg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReinvestmentType1Code Type { get; init; }

    /// <summary>
    /// Provides details on the amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_ZdId8JLjEeelrYORFsXWZg")]
    [DisplayName("Reinvested Cash Amount")]
    [IsoXmlTag("RinvstdCshAmt")]
    public required ActiveOrHistoricCurrencyAndAmount ReinvestedCashAmount { get; init; }
}
