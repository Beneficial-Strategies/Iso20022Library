// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals for the value of the holdings reported in the statement or page.
/// </summary>
[IsoId("_ReNoe9p-Ed-ak6NoX_4Aeg_939590328")]
[DisplayName("Total Value In Page And Statement")]
public partial record TotalValueInPageAndStatement1
{
    #nullable enable
    
    /// <summary>
    /// Total value of positions reported in this message.
    /// </summary>
    [IsoId("_ReNofNp-Ed-ak6NoX_4Aeg_939590346")]
    [DisplayName("Total Holdings Value Of Page")]
    [IsoXmlTag("TtlHldgsValOfPg")]
    public AmountAndDirection6? TotalHoldingsValueOfPage { get; init; } 
    
    /// <summary>
    /// Total value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_ReNofdp-Ed-ak6NoX_4Aeg_939590371")]
    [DisplayName("Total Holdings Value Of Statement")]
    [IsoXmlTag("TtlHldgsValOfStmt")]
    public required AmountAndDirection6 TotalHoldingsValueOfStatement { get; init; } 
    
    /// <summary>
    /// Total book value of positions reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_ReWyYNp-Ed-ak6NoX_4Aeg_-210339509")]
    [DisplayName("Total Book Value Of Statement")]
    [IsoXmlTag("TtlBookValOfStmt")]
    public AmountAndDirection6? TotalBookValueOfStatement { get; init; } 
    
    /// <summary>
    /// Total value of the holdings eligible for collateral purposes reported in this statement (a statement may comprise one or more messages).
    /// </summary>
    [IsoId("_ReWyYdp-Ed-ak6NoX_4Aeg_969143960")]
    [DisplayName("Total Eligible Collateral Value")]
    [IsoXmlTag("TtlElgblCollVal")]
    public AmountAndDirection6? TotalEligibleCollateralValue { get; init; } 
    
    
    #nullable disable
    
}
