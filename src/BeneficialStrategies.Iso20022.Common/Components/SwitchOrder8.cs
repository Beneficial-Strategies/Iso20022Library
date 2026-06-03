// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to switch an investment from one fund to another.
/// </summary>
[IsoId("906f2c3f-6693-415a-ae48-44d8780df86b")]
[DisplayName("Switch Order8")]
public record SwitchOrder8
{
    [IsoId("906f2c3f-mstr-0001-0001-44d8780df86b")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    [IsoId("906f2c3f-ordr-0001-0002-44d8780df86b")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    [IsoId("906f2c3f-plac-0001-0003-44d8780df86b")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    [IsoId("906f2c3f-orrf-0001-0004-44d8780df86b")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    [IsoId("906f2c3f-clnt-0001-0005-44d8780df86b")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    [IsoId("906f2c3f-nonc-0001-0006-44d8780df86b")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    [IsoId("906f2c3f-invs-0001-0007-44d8780df86b")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    [IsoId("906f2c3f-rltd-0001-0008-44d8780df86b")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary50> RelatedPartyDetails { get; init; } = [];

    [IsoId("906f2c3f-reqd-0001-0009-44d8780df86b")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    [IsoId("906f2c3f-sttl-0001-0010-44d8780df86b")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    [IsoId("906f2c3f-cash-0001-0011-44d8780df86b")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    [IsoId("906f2c3f-sttm-0001-0012-44d8780df86b")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    [IsoId("906f2c3f-addl-0001-0013-44d8780df86b")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; }

    [IsoId("906f2c3f-xpry-0001-0014-44d8780df86b")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTime2Choice_? ExpiryDateTime { get; init; }

    [IsoId("906f2c3f-cxlr-0001-0015-44d8780df86b")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    [IsoId("906f2c3f-rdmp-0001-0016-44d8780df86b")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    [MinLength(1)]
    public ValueList<SwitchRedemptionLegOrder7> RedemptionLegDetails { get; init; } = [];

    [IsoId("906f2c3f-sbsc-0001-0017-44d8780df86b")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    [MinLength(1)]
    public ValueList<SwitchSubscriptionLegOrder7> SubscriptionLegDetails { get; init; } = [];

    [IsoId("906f2c3f-cshs-0001-0018-44d8780df86b")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction181? CashSettlementDetails { get; init; }

    [IsoId("906f2c3f-fxdt-0001-0019-44d8780df86b")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms44? ForeignExchangeDetails { get; init; }

    [IsoId("906f2c3f-fnad-0001-0020-44d8780df86b")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    [IsoId("906f2c3f-ngtd-0001-0021-44d8780df86b")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    [IsoId("906f2c3f-cstm-0001-0022-44d8780df86b")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    [IsoId("906f2c3f-txch-0001-0023-44d8780df86b")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    [IsoId("906f2c3f-sgnr-0001-0024-44d8780df86b")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    [IsoId("906f2c3f-orwd-0001-0025-44d8780df86b")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
