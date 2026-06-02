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
[IsoId("_dMdmAaNjEfC9id413JK-Ig")]
[DisplayName("Corporate Action Date110")]
public record CorporateActionDate110
{
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, giving the holder eligibility to incentives.
    /// </summary>
    [IsoId("_dVTY8aNjEfC9id413JK-Ig")]
    [DisplayName("Early Response Deadline")]
    [IsoXmlTag("EarlyRspnDdln")]
    public DateFormat43Choice? EarlyResponseDeadline { get; init; }

    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_dVUAAaNjEfC9id413JK-Ig")]
    [DisplayName("Cover Expiration Deadline")]
    [IsoXmlTag("CoverXprtnDdln")]
    public DateFormat43Choice? CoverExpirationDeadline { get; init; }

    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_dVUACaNjEfC9id413JK-Ig")]
    [DisplayName("Protect Deadline")]
    [IsoXmlTag("PrtctDdln")]
    public DateFormat43Choice? ProtectDeadline { get; init; }

    /// <summary>
    /// Issuer or issuer's agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [IsoId("_dVUAEaNjEfC9id413JK-Ig")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat43Choice? MarketDeadline { get; init; }

    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event.
    /// </summary>
    [IsoId("_dVUAGaNjEfC9id413JK-Ig")]
    [DisplayName("Response Deadline")]
    [IsoXmlTag("RspnDdln")]
    public DateFormat44Choice? ResponseDeadline { get; init; }

    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [IsoId("_dVUAIaNjEfC9id413JK-Ig")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat43Choice? ExpiryDate { get; init; }

    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [IsoId("_dVUAKaNjEfC9id413JK-Ig")]
    [DisplayName("Subscription Cost Debit Date")]
    [IsoXmlTag("SbcptCostDbtDt")]
    public DateFormat43Choice? SubscriptionCostDebitDate { get; init; }

    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_dVUAMaNjEfC9id413JK-Ig")]
    [DisplayName("Depository Cover Expiration Date")]
    [IsoXmlTag("DpstryCoverXprtnDt")]
    public DateFormat43Choice? DepositoryCoverExpirationDate { get; init; }

    /// <summary>
    /// Date/time set as the deadline to respond for which the underlying security is out on loan.
    /// </summary>
    [IsoId("_dVUAOaNjEfC9id413JK-Ig")]
    [DisplayName("Stock Lending Deadline")]
    [IsoXmlTag("StockLndgDdln")]
    public DateFormat43Choice? StockLendingDeadline { get; init; }

    /// <summary>
    /// Specifies the party borrowing stocks and the associated stock lending deadline assigned to the borrower.
    /// </summary>
    [IsoId("_dVUAO6NjEfC9id413JK-Ig")]
    [DisplayName("Borrower Stock Lending Deadline")]
    [IsoXmlTag("BrrwrStockLndgDdln")]
    public ValueList<BorrowerLendingDeadline5> BorrowerStockLendingDeadline { get; init; } = [];

    /// <summary>
    /// Date until which the blocking of securities can occur upon instructing this option.
    /// </summary>
    [IsoId("_dVUAPaNjEfC9id413JK-Ig")]
    [DisplayName("End Of Securities Blocking Period")]
    [IsoXmlTag("EndOfSctiesBlckgPrd")]
    public DateFormat59Choice? EndOfSecuritiesBlockingPeriod { get; init; }

    /// <summary>
    /// Date/Time by when the documentation must be provided.
    /// </summary>
    [IsoId("_dVUAP6NjEfC9id413JK-Ig")]
    [DisplayName("Documentation Deadline")]
    [IsoXmlTag("DcmnttnDdln")]
    public DateFormat46Choice? DocumentationDeadline { get; init; }
}
