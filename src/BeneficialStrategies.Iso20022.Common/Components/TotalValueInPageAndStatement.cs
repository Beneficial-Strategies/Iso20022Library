// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value of total holdings reported.
/// </summary>
[IsoId("_Q7Cp9tp-Ed-ak6NoX_4Aeg_-277574684")]
[DisplayName("Total Value In Page And Statement")]
public record TotalValueInPageAndStatement
{
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_Q7Cp99p-Ed-ak6NoX_4Aeg_-1277686772")]
    [DisplayName("Total Holdings Value Of Page")]
    [IsoXmlTag("TtlHldgsValOfPg")]
    public ActiveCurrencyAndAmount? TotalHoldingsValueOfPage { get; init; }

    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_Q7Ma8Np-Ed-ak6NoX_4Aeg_-1254598967")]
    [DisplayName("Total Holdings Value Of Statement")]
    [IsoXmlTag("TtlHldgsValOfStmt")]
    public required ActiveCurrencyAndAmount TotalHoldingsValueOfStatement { get; init; }
}
