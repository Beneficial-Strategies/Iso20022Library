// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action date.
/// </summary>
[IsoId("_Qo3AUR9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate80
{
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event.
    /// </summary>
    [IsoId("_Qo3AVR9REeuFz_FaCzCLgQ")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat49Choice_? ResponseDeadline { get; init; }

    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_Qo3AXR9REeuFz_FaCzCLgQ")]
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; }

    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_Qo3AZR9REeuFz_FaCzCLgQ")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat49Choice_? MarketDeadline { get; init; }

    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_Qo3AbR9REeuFz_FaCzCLgQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat49Choice_? ExpiryDate { get; init; }

    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_Qo3AdR9REeuFz_FaCzCLgQ")]
    [DisplayName("Cover Expiration Deadline")]
    [IsoXmlTag("CoverXprtnDdln")]
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; }

    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_Qo3AfR9REeuFz_FaCzCLgQ")]
    [DisplayName("Protect Deadline")]
    [IsoXmlTag("PrtctDdln")]
    public DateFormat43Choice_? ProtectDeadline { get; init; }

    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    [IsoId("_Qo3AhR9REeuFz_FaCzCLgQ")]
    [DisplayName("Trading Date")]
    [IsoXmlTag("TradgDt")]
    public DateFormat49Choice_? TradingDate { get; init; }
}
