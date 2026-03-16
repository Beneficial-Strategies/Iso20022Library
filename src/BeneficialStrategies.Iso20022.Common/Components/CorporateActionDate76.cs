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
[IsoId("_cs43V_fSEeiNZp_PtLohLw")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate76
{
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_cs43W_fSEeiNZp_PtLohLw")]
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat49Choice_? EarlyResponseDeadline { get; init; }

    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_cs43Y_fSEeiNZp_PtLohLw")]
    [DisplayName("Cover Expiration Date")]
    [IsoXmlTag("CoverXprtnDt")]
    public DateFormat49Choice_? CoverExpirationDate { get; init; }

    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_cs43a_fSEeiNZp_PtLohLw")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    public DateFormat49Choice_? ProtectDate { get; init; }

    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_cs43c_fSEeiNZp_PtLohLw")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat49Choice_? MarketDeadline { get; init; }

    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_cs43e_fSEeiNZp_PtLohLw")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat54Choice_? ResponseDeadline { get; init; }

    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_cs43g_fSEeiNZp_PtLohLw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat49Choice_? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_cs43i_fSEeiNZp_PtLohLw")]
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; }

    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_cs43k_fSEeiNZp_PtLohLw")]
    [DisplayName("Depository Cover Expiration Date")]
    [IsoXmlTag("DpstryCoverXprtnDt")]
    public DateFormat49Choice_? DepositoryCoverExpirationDate { get; init; }

    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_cs43m_fSEeiNZp_PtLohLw")]
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public DateFormat49Choice_? StockLendingDeadline { get; init; }

    /// <summary>
    /// Specifies the party borrowing stocks and the associated stock lending deadline assigned to the borrower.
    /// </summary>
    [IsoId("_cs43nffSEeiNZp_PtLohLw")]
    [DisplayName("Borrower Stock Lending Deadline")]
    [IsoXmlTag("BrrwrStockLndgDdln")]
    public ValueList<BorrowerLendingDeadline6> BorrowerStockLendingDeadline { get; init; } = [];
}
