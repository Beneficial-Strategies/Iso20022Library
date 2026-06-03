// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a switch order.
/// </summary>
[IsoId("b567fa88-7149-489e-9058-cbedd3f4632d")]
[DisplayName("Switch Execution8")]
public record SwitchExecution8
{
    [IsoId("b567fa88-amnd-0001-0001-cbedd3f4632d")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    [IsoId("b567fa88-mstr-0001-0002-cbedd3f4632d")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    [IsoId("b567fa88-plac-0001-0003-cbedd3f4632d")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    [IsoId("b567fa88-ordr-0001-0004-cbedd3f4632d")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    [IsoId("b567fa88-rcvd-0001-0005-cbedd3f4632d")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    [IsoId("b567fa88-deal-0001-0006-cbedd3f4632d")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; }

    [IsoId("b567fa88-ordr-0002-0007-cbedd3f4632d")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    [IsoId("b567fa88-clnt-0001-0008-cbedd3f4632d")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    [IsoId("b567fa88-nonc-0001-0009-cbedd3f4632d")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    [IsoId("b567fa88-invs-0001-0010-cbedd3f4632d")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    [IsoId("b567fa88-rltd-0001-0011-cbedd3f4632d")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    [IsoId("b567fa88-cxlr-0001-0012-cbedd3f4632d")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    [IsoId("b567fa88-reqd-0001-0013-cbedd3f4632d")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    [IsoId("b567fa88-sttl-0001-0014-cbedd3f4632d")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    [IsoId("b567fa88-cash-0001-0015-cbedd3f4632d")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    [IsoId("b567fa88-sttm-0001-0016-cbedd3f4632d")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    [IsoId("b567fa88-addl-0001-0017-cbedd3f4632d")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; }

    [IsoId("b567fa88-best-0001-0018-cbedd3f4632d")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    [IsoId("b567fa88-rdmp-0001-0019-cbedd3f4632d")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    [MinLength(1)]
    public ValueList<SwitchRedemptionLegExecution5> RedemptionLegDetails { get; init; } = [];

    [IsoId("b567fa88-sbsc-0001-0020-cbedd3f4632d")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    [MinLength(1)]
    public ValueList<SwitchSubscriptionLegExecution5> SubscriptionLegDetails { get; init; } = [];

    [IsoId("b567fa88-cshs-0001-0021-cbedd3f4632d")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction181? CashSettlementDetails { get; init; }

    [IsoId("b567fa88-fxdt-0001-0022-cbedd3f4632d")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    [IsoId("b567fa88-fnad-0001-0023-cbedd3f4632d")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    [IsoId("b567fa88-ngtd-0001-0024-cbedd3f4632d")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    [IsoId("b567fa88-late-0001-0025-cbedd3f4632d")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    [IsoId("b567fa88-cstm-0001-0026-cbedd3f4632d")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    [IsoId("b567fa88-txch-0001-0027-cbedd3f4632d")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    [IsoId("b567fa88-sgnr-0001-0028-cbedd3f4632d")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    [IsoId("b567fa88-orwd-0001-0029-cbedd3f4632d")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
