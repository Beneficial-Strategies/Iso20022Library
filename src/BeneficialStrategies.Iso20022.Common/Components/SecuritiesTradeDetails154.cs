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
    [IsoId("_1hTj3ZaHEfC2_67yGLymgA")]
    [DisplayName("Notification Sender Transaction Identification")]
    [IsoXmlTag("NtfctnSndrTxId")]
    public IsoMax35Text? NotificationSenderTransactionIdentification { get; init; }

    [IsoId("_1hTj6ZaHEfC2_67yGLymgA")]
    [DisplayName("Notification Receiver Transaction Identification")]
    [IsoXmlTag("NtfctnRcvrTxId")]
    public IsoMax35Text? NotificationReceiverTransactionIdentification { get; init; }

    [IsoId("_1hTj9ZaHEfC2_67yGLymgA")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("_1hTkAZaHEfC2_67yGLymgA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    [IsoId("_1hTkDZaHEfC2_67yGLymgA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    [IsoId("_1hTkGZaHEfC2_67yGLymgA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PortfolioTransferStatus2Choice? Status { get; init; }

    [IsoId("_1hTkH5aHEfC2_67yGLymgA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice? TradeDate { get; init; }

    [IsoId("_1hTkK5aHEfC2_67yGLymgA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice SettlementDate { get; init; }

    [IsoId("_1hTkN5aHEfC2_67yGLymgA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("_1hTkQ5aHEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    [IsoId("_1hTkT5aHEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    [IsoId("_1hTkW5aHEfC2_67yGLymgA")]
    [DisplayName("Reporting")]
    [IsoXmlTag("Rptg")]
    public ValueList<Reporting7Choice> Reporting { get; init; } = [];

    [IsoId("_1hTkZ5aHEfC2_67yGLymgA")]
    [DisplayName("Quantity Details")]
    [IsoXmlTag("QtyDtls")]
    public required Quantity48 QuantityDetails { get; init; }

    [IsoId("_1hTkc5aHEfC2_67yGLymgA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails236? SettlementParameters { get; init; }

    [IsoId("_1hTkf5aHEfC2_67yGLymgA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties128? DeliveringSettlementParties { get; init; }

    [IsoId("_1hTki5aHEfC2_67yGLymgA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties128? ReceivingSettlementParties { get; init; }

    [IsoId("_1hTkl5aHEfC2_67yGLymgA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection52? SettlementAmount { get; init; }

    [IsoId("_1hTko5aHEfC2_67yGLymgA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts29? OtherAmounts { get; init; }

    [IsoId("_PSSrEZaHEfC2_67yGLymgA")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public ValueList<DigitalPaymentSettlement1> DigitalPaymentSettlement { get; init; } = [];

    [IsoId("_1hTkr5aHEfC2_67yGLymgA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties39? OtherBusinessParties { get; init; }

    [IsoId("_1hTku5aHEfC2_67yGLymgA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
