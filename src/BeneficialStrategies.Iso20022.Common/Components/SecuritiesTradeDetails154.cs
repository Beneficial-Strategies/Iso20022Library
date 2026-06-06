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
[IsoId("_1eqfgZaHEfC2_67yGLymgA")]
[DisplayName("Securities Trade Details154")]
public record SecuritiesTradeDetails154
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    [IsoId("_1hTj3ZaHEfC2_67yGLymgA")]
    [DisplayName("Notification Sender Transaction Identification")]
    [IsoXmlTag("NtfctnSndrTxId")]
    public IsoMax35Text? NotificationSenderTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the notification receiver.
    /// </summary>
    [IsoId("_1hTj6ZaHEfC2_67yGLymgA")]
    [DisplayName("Notification Receiver Transaction Identification")]
    [IsoXmlTag("NtfctnRcvrTxId")]
    public IsoMax35Text? NotificationReceiverTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_1hTj9ZaHEfC2_67yGLymgA")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_1hTkAZaHEfC2_67yGLymgA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_1hTkDZaHEfC2_67yGLymgA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Status of the transfer.
    /// </summary>
    [IsoId("_1hTkGZaHEfC2_67yGLymgA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PortfolioTransferStatus2Choice_? Status { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_1hTkH5aHEfC2_67yGLymgA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_1hTkK5aHEfC2_67yGLymgA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_1hTkN5aHEfC2_67yGLymgA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_1hTkQ5aHEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_1hTkT5aHEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_1hTkW5aHEfC2_67yGLymgA")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting7Choice_> Reporting { get; init; } = [];

    /// <summary>
    /// Details about the financial instrument quantity involved in the transfer.
    /// </summary>
    [IsoId("_1hTkZ5aHEfC2_67yGLymgA")]
    [DisplayName("Quantity Details")]
    [IsoXmlTag("QtyDtls")]
    public required Quantity48 QuantityDetails { get; init; }

    /// <summary>
    /// Parameters applied to the settlement of a security transfer.
    /// </summary>
    [IsoId("_1hTkc5aHEfC2_67yGLymgA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails236? SettlementParameters { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_1hTkf5aHEfC2_67yGLymgA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties128? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_1hTki5aHEfC2_67yGLymgA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties128? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_1hTkl5aHEfC2_67yGLymgA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection52? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_1hTko5aHEfC2_67yGLymgA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts29? OtherAmounts { get; init; }

    /// <summary>
    /// Total quantity  of digital asset to be paid or received in exchange for the securities token; or the network fee.
    /// </summary>
    [IsoId("_PSSrEZaHEfC2_67yGLymgA")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public ValueList<DigitalPaymentSettlement1> DigitalPaymentSettlement { get; init; } = [];

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_1hTkr5aHEfC2_67yGLymgA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties39? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1hTku5aHEfC2_67yGLymgA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
