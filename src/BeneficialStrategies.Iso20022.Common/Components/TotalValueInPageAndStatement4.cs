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
[IsoId("_XOasgtp-Ed-ak6NoX_4Aeg_565469517")]
[DisplayName("Total Value In Page And Statement")]
public record TotalValueInPageAndStatement4
{
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_XOasg9p-Ed-ak6NoX_4Aeg_-1606793861")]
    [DisplayName("Total Holdings Value Of Page")]
    [IsoXmlTag("TtlHldgsValOfPg")]
    public AmountAndDirection14? TotalHoldingsValueOfPage { get; init; }

    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XOashNp-Ed-ak6NoX_4Aeg_580189663")]
    [DisplayName("Total Holdings Value Of Statement")]
    [IsoXmlTag("TtlHldgsValOfStmt")]
    public required AmountAndDirection14 TotalHoldingsValueOfStatement { get; init; }

    /// <summary>
    /// Total book value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XOashdp-Ed-ak6NoX_4Aeg_1997778966")]
    [DisplayName("Total Book Value Of Statement")]
    [IsoXmlTag("TtlBookValOfStmt")]
    public AmountAndDirection14? TotalBookValueOfStatement { get; init; }
}
