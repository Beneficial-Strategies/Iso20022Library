// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_DDzm4ZaFEfC2_67yGLymgA")]
[DisplayName("Securities Financing Transaction Details59")]
public record SecuritiesFinancingTransactionDetails59
{
    [IsoId("_DGqtr5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; }

    [IsoId("_DGqtt5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Financing Unique Transaction Identifier")]
    [IsoXmlTag("SctiesFincgUnqTxIdr")]
    public IsoUTIIdentifier? SecuritiesFinancingUniqueTransactionIdentifier { get; init; }

    [IsoId("_DGqtuZaFEfC2_67yGLymgA")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    [IsoId("_DGqtwZaFEfC2_67yGLymgA")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    [IsoId("_DGqtyZaFEfC2_67yGLymgA")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    [IsoId("_DGqt0ZaFEfC2_67yGLymgA")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    [IsoId("_DGqt2ZaFEfC2_67yGLymgA")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    [IsoId("_DGqt4ZaFEfC2_67yGLymgA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    [IsoId("_DGqt6ZaFEfC2_67yGLymgA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_DGqt8ZaFEfC2_67yGLymgA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    [IsoId("_DGqt95aFEfC2_67yGLymgA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    [IsoId("_DGqt_5aFEfC2_67yGLymgA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; }

    [IsoId("_DGquB5aFEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    [IsoId("_DGquD5aFEfC2_67yGLymgA")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity51Choice SettlementQuantity { get; init; }

    [IsoId("_DGquF5aFEfC2_67yGLymgA")]
    [DisplayName("Opening Settlement Amount")]
    [IsoXmlTag("OpngSttlmAmt")]
    public AmountAndDirection51? OpeningSettlementAmount { get; init; }

    [IsoId("_DGquH5aFEfC2_67yGLymgA")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection21? TerminationTransactionAmount { get; init; }

    [IsoId("_dJqK4ZaEEfC2_67yGLymgA")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public DigitalPaymentSettlement2? DigitalPaymentSettlement { get; init; }

    [IsoId("_DGquJ5aFEfC2_67yGLymgA")]
    [DisplayName("Opening Settlement Date")]
    [IsoXmlTag("OpngSttlmDt")]
    public required SettlementDate19Choice OpeningSettlementDate { get; init; }

    [IsoId("_DGquL5aFEfC2_67yGLymgA")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate6Choice? TerminationDate { get; init; }

    [IsoId("_DGquN5aFEfC2_67yGLymgA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice? TradeDate { get; init; }

    [IsoId("_DGquP5aFEfC2_67yGLymgA")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    public DateAndDateTime2Choice? ExpectedSettlementDate { get; init; }

    [IsoId("_DGquR5aFEfC2_67yGLymgA")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public DateAndDateTime2Choice? ExpectedValueDate { get; init; }

    [IsoId("_DGquT5aFEfC2_67yGLymgA")]
    [DisplayName("Late Delivery Date")]
    [IsoXmlTag("LateDlvryDt")]
    public DateAndDateTime2Choice? LateDeliveryDate { get; init; }

    [IsoId("_DGquV5aFEfC2_67yGLymgA")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTime2Choice? RateChangeDate { get; init; }

    [IsoId("_DGquX5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    [IsoId("_DGquZ5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    [IsoId("_DGqub5aFEfC2_67yGLymgA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    [IsoId("_DGqud5aFEfC2_67yGLymgA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails227? SettlementParameters { get; init; }

    [IsoId("_DGquf5aFEfC2_67yGLymgA")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice? RateType { get; init; }

    [IsoId("_DGquh5aFEfC2_67yGLymgA")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; }

    [IsoId("_DGrUt5aFEfC2_67yGLymgA")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    [IsoId("_DGrUv5aFEfC2_67yGLymgA")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    [IsoId("_DGrUx5aFEfC2_67yGLymgA")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    [IsoId("_DGrUz5aFEfC2_67yGLymgA")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice? PricingRate { get; init; }

    [IsoId("_DGrU15aFEfC2_67yGLymgA")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; }

    [IsoId("_DGrU35aFEfC2_67yGLymgA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties127? DeliveringSettlementParties { get; init; }

    [IsoId("_DGrU55aFEfC2_67yGLymgA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties127? ReceivingSettlementParties { get; init; }

    [IsoId("_DGrU75aFEfC2_67yGLymgA")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; }

    [IsoId("_DGrU95aFEfC2_67yGLymgA")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; }
}
