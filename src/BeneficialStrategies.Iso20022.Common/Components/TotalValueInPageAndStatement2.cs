// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals for the value of the holdings reported in the statement or page.
/// </summary>
[IsoId("_Rctzotp-Ed-ak6NoX_4Aeg_-645016837")]
[DisplayName("Total Value In Page And Statement")]
public record TotalValueInPageAndStatement2
{
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_Rctzo9p-Ed-ak6NoX_4Aeg_-645016819")]
    [DisplayName("Total Holdings Value Of Page")]
    [IsoXmlTag("TtlHldgsValOfPg")]
    public AmountAndDirection6? TotalHoldingsValueOfPage { get; init; }

    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_RctzpNp-Ed-ak6NoX_4Aeg_-645016529")]
    [DisplayName("Total Holdings Value Of Statement")]
    [IsoXmlTag("TtlHldgsValOfStmt")]
    public required AmountAndDirection6 TotalHoldingsValueOfStatement { get; init; }

    /// <summary>
    /// Total book value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_Rctzpdp-Ed-ak6NoX_4Aeg_-645016468")]
    [DisplayName("Total Book Value Of Statement")]
    [IsoXmlTag("TtlBookValOfStmt")]
    public AmountAndDirection6? TotalBookValueOfStatement { get; init; }
}
