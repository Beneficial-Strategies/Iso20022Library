// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods.
/// </summary>
[IsoId("_TfjOGdp-Ed-ak6NoX_4Aeg_-1268934712")]
[DisplayName("Corporate Action Period")]
public record CorporateActionPeriod2
{
    /// <summary>
    /// Period during which the assented line is available.
    /// </summary>
    [IsoId("_Tfs_ENp-Ed-ak6NoX_4Aeg_251714713")]
    [DisplayName("Assented Line Period")]
    [IsoXmlTag("AssntdLinePrd")]
    public Period1? AssentedLinePeriod { get; init; }

    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, eg, offer period.
    /// </summary>
    [IsoId("_Tfs_Edp-Ed-ak6NoX_4Aeg_205021481")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period1? ActionPeriod { get; init; }

    /// <summary>
    /// Period during which the privilege is not available, eg, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    [IsoId("_Tfs_Etp-Ed-ak6NoX_4Aeg_-1027220303")]
    [DisplayName("Privilege Suspension Period")]
    [IsoXmlTag("PrvlgSspnsnPrd")]
    public Period1? PrivilegeSuspensionPeriod { get; init; }

    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, eg, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_Tfs_E9p-Ed-ak6NoX_4Aeg_-954261746")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period1? ParallelTradingPeriod { get; init; }

    /// <summary>
    /// Period (last day included) during which an account owner can surrender or sell securities to the issuer and receive the sale proceeds.
    /// </summary>
    [IsoId("_Tfs_FNp-Ed-ak6NoX_4Aeg_-910856320")]
    [DisplayName("Sell Thru Issuer Period")]
    [IsoXmlTag("SellThruIssrPrd")]
    public Period1? SellThruIssuerPeriod { get; init; }

    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    [IsoId("_Tfs_Fdp-Ed-ak6NoX_4Aeg_-868373428")]
    [DisplayName("Revocability Period")]
    [IsoXmlTag("RvcbltyPrd")]
    public Period1? RevocabilityPeriod { get; init; }

    /// <summary>
    /// Period during which the price of a security is determined (for outturn securities).
    /// </summary>
    [IsoId("_Tfs_Ftp-Ed-ak6NoX_4Aeg_-823779950")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period1? PriceCalculationPeriod { get; init; }
}
