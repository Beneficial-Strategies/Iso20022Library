// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_ctbk7ZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate55
{
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_ctbk75KQEeWHWpTQn1FFVg")]
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat34Choice_? EarlyResponseDeadline { get; init; }

    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_ctbk95KQEeWHWpTQn1FFVg")]
    [DisplayName("Cover Expiration Date")]
    [IsoXmlTag("CoverXprtnDt")]
    public DateFormat34Choice_? CoverExpirationDate { get; init; }

    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_ctbk_5KQEeWHWpTQn1FFVg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    public DateFormat34Choice_? ProtectDate { get; init; }

    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_ctblB5KQEeWHWpTQn1FFVg")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat34Choice_? MarketDeadline { get; init; }

    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_ctblD5KQEeWHWpTQn1FFVg")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat38Choice_? ResponseDeadline { get; init; }

    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_ctblF5KQEeWHWpTQn1FFVg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat34Choice_? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_ctblH5KQEeWHWpTQn1FFVg")]
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat34Choice_? SubscriptionCostDebitDate { get; init; }

    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_ctblJ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Depository Cover Expiration Date")]
    [IsoXmlTag("DpstryCoverXprtnDt")]
    public DateFormat34Choice_? DepositoryCoverExpirationDate { get; init; }

    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_ctblL5KQEeWHWpTQn1FFVg")]
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public DateFormat34Choice_? StockLendingDeadline { get; init; }

    /// <summary>
    /// Specifies the party borrowing stocks and the associated stock lending deadline assigned to the borrower.
    /// </summary>
    [IsoId("_ctblMZKQEeWHWpTQn1FFVg")]
    [DisplayName("Borrower Stock Lending Deadline")]
    [IsoXmlTag("BrrwrStockLndgDdln")]
    public BorrowerLendingDeadline2? BorrowerStockLendingDeadline { get; init; }
}
