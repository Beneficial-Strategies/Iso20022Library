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
[IsoId("_L7GM8MRrEeij-rSPpvD-Tw")]
[DisplayName("Total Value In Page And Statement")]
public record TotalValueInPageAndStatement5
{
    /// <summary>
    /// Total value of exposure reported in this message.
    /// </summary>
    [IsoId("_8TX0sMRrEeij-rSPpvD-Tw")]
    [DisplayName("Total Exposure Value Of Page")]
    [IsoXmlTag("TtlXpsrValOfPg")]
    public ActiveOrHistoricCurrencyAndAmount? TotalExposureValueOfPage { get; init; }

    /// <summary>
    /// Total value of collateral held reported in this message.
    /// </summary>
    [IsoId("_Hzfo8MRsEeij-rSPpvD-Tw")]
    [DisplayName("Total Collateral Held Value Of Page")]
    [IsoXmlTag("TtlCollHeldValOfPg")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralHeldValueOfPage { get; init; }
}
