// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.
/// </summary>
[IsoId("_vFk_wKp1EeamNLogr5TkIQ")]
[DisplayName("Intra Day Requirement")]
public record IntraDayRequirement1
{
    /// <summary>
    /// Total aggregate value of collateral called intraday, excluding repayments.
    /// </summary>
    [IsoId("_tJOLUKp2EeamNLogr5TkIQ")]
    [DisplayName("Intra Day Margin Call")]
    [IsoXmlTag("IntraDayMrgnCall")]
    public required ActiveCurrencyAndAmount IntraDayMarginCall { get; init; }

    /// <summary>
    /// Peak increase in initial margin liability for the account during the day.
    /// </summary>
    [IsoId("_y6cjEKp2EeamNLogr5TkIQ")]
    [DisplayName("Peak Initial Margin Liability")]
    [IsoXmlTag("PeakInitlMrgnLblty")]
    public required ActiveCurrencyAndAmount PeakInitialMarginLiability { get; init; }

    /// <summary>
    /// Peak loss uncollateralised variation margin liability on the margin account during the day.
    /// </summary>
    [IsoId("_4uHK0Kp2EeamNLogr5TkIQ")]
    [DisplayName("Peak Variation Margin Liability")]
    [IsoXmlTag("PeakVartnMrgnLblty")]
    public required ActiveCurrencyAndAmount PeakVariationMarginLiability { get; init; }

    /// <summary>
    /// Peak intraday liability (sum of increase in initial margin relative to end of day plus sum of decrease in variation margin relative to end of day) for a margin account during the day. Liabilities are shown as positive integers.
    /// </summary>
    [IsoId("_-L_v0Kp2EeamNLogr5TkIQ")]
    [DisplayName("Aggregate Peak Liability")]
    [IsoXmlTag("AggtPeakLblty")]
    public required ActiveCurrencyAndAmount AggregatePeakLiability { get; init; }

    /// <summary>
    /// Identification of the account used to calculate margin requirements and determine intraday calls.
    /// </summary>
    [IsoId("_QtEHsPneEeadN4WGmMtGCQ")]
    [DisplayName("Margin Account Identification")]
    [IsoXmlTag("MrgnAcctId")]
    public required GenericIdentification165 MarginAccountIdentification { get; init; }
}
