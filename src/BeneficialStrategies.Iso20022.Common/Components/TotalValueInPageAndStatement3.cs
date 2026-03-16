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
[IsoId("_XN02o9p-Ed-ak6NoX_4Aeg_1095060082")]
[DisplayName("Total Value In Page And Statement")]
public record TotalValueInPageAndStatement3
{
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_XN02pNp-Ed-ak6NoX_4Aeg_854357249")]
    [DisplayName("Total Holdings Value Of Page")]
    [IsoXmlTag("TtlHldgsValOfPg")]
    public AmountAndDirection14? TotalHoldingsValueOfPage { get; init; }

    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XN02pdp-Ed-ak6NoX_4Aeg_-2023020744")]
    [DisplayName("Total Holdings Value Of Statement")]
    [IsoXmlTag("TtlHldgsValOfStmt")]
    public required AmountAndDirection14 TotalHoldingsValueOfStatement { get; init; }

    /// <summary>
    /// Total book value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XN02ptp-Ed-ak6NoX_4Aeg_163962780")]
    [DisplayName("Total Book Value Of Statement")]
    [IsoXmlTag("TtlBookValOfStmt")]
    public AmountAndDirection14? TotalBookValueOfStatement { get; init; }

    /// <summary>
    /// Total value of the holdings eligible for collateral purposes reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_XN02p9p-Ed-ak6NoX_4Aeg_1581552083")]
    [DisplayName("Total Eligible Collateral Value")]
    [IsoXmlTag("TtlElgblCollVal")]
    public AmountAndDirection14? TotalEligibleCollateralValue { get; init; }
}
