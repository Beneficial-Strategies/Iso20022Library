// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities settlement transaction.
/// </summary>
[IsoId("_oXVjf5aPEfC2_67yGLymgA")]
[DisplayName("Transaction Details184")]
public record TransactionDetails184
{
    [IsoId("_oXVjf5aPEfC2_67yGLymgB")]
    [DisplayName("Transaction Activity")]
    [IsoXmlTag("TxActvty")]
    public required TransactionActivity3Choice_ TransactionActivity { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgC")]
    [DisplayName("Settlement Transaction Or Corporate Action Event Type")]
    [IsoXmlTag("SttlmTxOrCorpActnEvtTp")]
    public SettlementOrCorporateActionEvent35Choice_? SettlementTransactionOrCorporateActionEventType { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgD")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgE")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgF")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails231? SettlementParameters { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgG")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgH")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgI")]
    [DisplayName("Place Of Clearing")]
    [IsoXmlTag("PlcOfClr")]
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgJ")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstgQty")]
    public required Quantity51Choice_ PostingQuantity { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgK")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgL")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstgAmt")]
    public AmountAndDirection3? PostingAmount { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgM")]
    [DisplayName("Digital Payment Posting Settlement")]
    [IsoXmlTag("DgtlPmtPstgSttlm")]
    public DigitalPaymentSettlement2? DigitalPaymentPostingSettlement { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgN")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgO")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgP")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public required DateAndDateTime2Choice_ EffectiveSettlementDate { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public SettlementDate17Choice_? SettlementDate { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgR")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgS")]
    [DisplayName("Acknowledged Status Time Stamp")]
    [IsoXmlTag("AckdStsTmStmp")]
    public IsoISODateTime? AcknowledgedStatusTimeStamp { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgT")]
    [DisplayName("Matched Status Time Stamp")]
    [IsoXmlTag("MtchdStsTmStmp")]
    public IsoISODateTime? MatchedStatusTimeStamp { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgU")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties125? DeliveringSettlementParties { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgV")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties125? ReceivingSettlementParties { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgW")]
    [DisplayName("Reversal Indicator")]
    [IsoXmlTag("RvslInd")]
    public IsoYesNoIndicator? ReversalIndicator { get; init; }

    [IsoId("_oXVjf5aPEfC2_67yGLymgX")]
    [DisplayName("Transaction Additional Details")]
    [IsoXmlTag("TxAddtlDtls")]
    public IsoMax350Text? TransactionAdditionalDetails { get; init; }
}
