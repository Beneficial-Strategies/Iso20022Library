// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
[IsoId("_bXLIwa2-EeeBVbuVcoH9Nw")]
[DisplayName("Securities Trade Details")]
public record SecuritiesTradeDetails72
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    [IsoId("_bh4j-62-EeeBVbuVcoH9Nw")]
    [DisplayName("Notification Sender Transaction Identification")]
    [IsoXmlTag("NtfctnSndrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NotificationSenderTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    [IsoId("_bh4kA62-EeeBVbuVcoH9Nw")]
    [DisplayName("Notification Receiver Transaction Identification")]
    [IsoXmlTag("NtfctnRcvrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NotificationReceiverTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_bh4kC62-EeeBVbuVcoH9Nw")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_bh4kE62-EeeBVbuVcoH9Nw")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_bh4kG62-EeeBVbuVcoH9Nw")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Status of the transfer.
    /// </summary>
    [IsoId("_T7yYcK3CEeeBVbuVcoH9Nw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PortfolioTransferStatus1Choice_? Status { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_bh4kI62-EeeBVbuVcoH9Nw")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_bh4kK62-EeeBVbuVcoH9Nw")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_bh4kM62-EeeBVbuVcoH9Nw")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_bh4kO62-EeeBVbuVcoH9Nw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_bh4kQ62-EeeBVbuVcoH9Nw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_bh4kS62-EeeBVbuVcoH9Nw")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public Reporting7Choice_? Reporting { get; init; }

    /// <summary>
    /// Details about the financial instrument quantity involved in the transfer.
    /// </summary>
    [IsoId("_bh4kU62-EeeBVbuVcoH9Nw")]
    [DisplayName("Quantity Details")]
    [IsoXmlTag("QtyDtls")]
    public required Quantity14 QuantityDetails { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_bh4kW62-EeeBVbuVcoH9Nw")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails100? SettlementParameters { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_bh4kY62-EeeBVbuVcoH9Nw")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties62? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_bh4ka62-EeeBVbuVcoH9Nw")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties62? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_bh4kc62-EeeBVbuVcoH9Nw")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection52? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_bh4ke62-EeeBVbuVcoH9Nw")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts29? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_bh4kg62-EeeBVbuVcoH9Nw")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties26? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bh4ki62-EeeBVbuVcoH9Nw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
