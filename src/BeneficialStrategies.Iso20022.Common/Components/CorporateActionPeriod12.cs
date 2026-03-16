// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods related to a corporate action option.
/// </summary>
[IsoId("_jKREwbQYEeeKRKrD60ELBQ")]
[DisplayName("Corporate Action Period")]
public record CorporateActionPeriod12
{
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_jZvEI7QYEeeKRKrD60ELBQ")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period6Choice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_jZvEK7QYEeeKRKrD60ELBQ")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period6Choice_? ParallelTradingPeriod { get; init; }

    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_jZvEM7QYEeeKRKrD60ELBQ")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period6Choice_? ActionPeriod { get; init; }

    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    [IsoId("_jZvEO7QYEeeKRKrD60ELBQ")]
    [DisplayName("Revocability Period")]
    [IsoXmlTag("RvcbltyPrd")]
    public Period6Choice_? RevocabilityPeriod { get; init; }

    /// <summary>
    /// Period during which the privilege is not available, for example, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    [IsoId("_jZvEQ7QYEeeKRKrD60ELBQ")]
    [DisplayName("Privilege Suspension Period")]
    [IsoXmlTag("PrvlgSspnsnPrd")]
    public Period6Choice_? PrivilegeSuspensionPeriod { get; init; }

    /// <summary>
    /// Period during which the participant of the account servicer can revoke change or withdraw its instructions.
    /// </summary>
    [IsoId("_jZvES7QYEeeKRKrD60ELBQ")]
    [DisplayName("Account Servicer Revocability Period")]
    [IsoXmlTag("AcctSvcrRvcbltyPrd")]
    public Period6Choice_? AccountServicerRevocabilityPeriod { get; init; }

    /// <summary>
    /// Period defining the last date on which withdrawal in street name requests on the outturn security will be accepted and the date on which the suspension will be released and withdrawal by transfer processing on the outturn security will resume.
    /// </summary>
    [IsoId("_jZvEU7QYEeeKRKrD60ELBQ")]
    [DisplayName("Depository Suspension Period For Withdrawal")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwl")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; }
}
