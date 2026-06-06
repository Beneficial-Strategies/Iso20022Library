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
    /// <summary>
    /// Indicates whether the confirmation is an amendment of a previous confirmation.
    /// </summary>
    [IsoId("b567fa88-amnd-0001-0001-cbedd3f4632d")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    public IsoYesNoIndicator? AmendmentIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("b567fa88-mstr-0001-0002-cbedd3f4632d")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("b567fa88-plac-0001-0003-cbedd3f4632d")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public PlaceOfTradeIdentification4Choice_? PlaceOfTrade { get; init; }

    /// <summary>
    /// Date and time at which the order was placed by the investor or its agent.
    /// </summary>
    [IsoId("b567fa88-ordr-0001-0004-cbedd3f4632d")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Date and time the order was received by the executing party, for example, the transfer agent.
    /// </summary>
    [IsoId("b567fa88-rcvd-0001-0005-cbedd3f4632d")]
    [DisplayName("Received Date Time")]
    [IsoXmlTag("RcvdDtTm")]
    public IsoISODateTime? ReceivedDateTime { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("b567fa88-deal-0001-0006-cbedd3f4632d")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("b567fa88-ordr-0002-0007-cbedd3f4632d")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("b567fa88-clnt-0001-0008-cbedd3f4632d")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public IsoMax35Text? ClientReference { get; init; }

    /// <summary>
    /// Unambiguous identification of a random or semi-random number used once (NONCE) generated in the frame of a cryptographic communication.
    /// </summary>
    [IsoId("b567fa88-nonc-0001-0009-cbedd3f4632d")]
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; }

    /// <summary>
    /// Account impacted by the investment fund order execution.
    /// </summary>
    [IsoId("b567fa88-invs-0001-0010-cbedd3f4632d")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [IsoId("b567fa88-rltd-0001-0011-cbedd3f4632d")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    public ValueList<Intermediary49> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Cancellation right of the investor with respect to the investment fund order.
    /// </summary>
    [IsoId("b567fa88-cxlr-0001-0012-cbedd3f4632d")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Choice_? CancellationRight { get; init; }

    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("b567fa88-reqd-0001-0013-cbedd3f4632d")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    public IsoISODate? RequestedFutureTradeDate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("b567fa88-sttl-0001-0014-cbedd3f4632d")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("b567fa88-cash-0001-0015-cbedd3f4632d")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("b567fa88-sttm-0001-0016-cbedd3f4632d")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; }

    /// <summary>
    /// Choice between additional cash in or resulting cash out.
    /// </summary>
    [IsoId("b567fa88-addl-0001-0017-cbedd3f4632d")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmount1Choice_? AdditionalAmount { get; init; }

    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    [IsoId("b567fa88-best-0001-0018-cbedd3f4632d")]
    [DisplayName("Best Execution")]
    [IsoXmlTag("BestExctn")]
    public BestExecution1Code? BestExecution { get; init; }

    /// <summary>
    /// Redemption leg of a switch order execution.
    /// </summary>
    [IsoId("b567fa88-rdmp-0001-0019-cbedd3f4632d")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    [MinLength(1)]
    public ValueList<SwitchRedemptionLegExecution5> RedemptionLegDetails { get; init; } = [];

    /// <summary>
    /// Subscription leg of a switch order execution.
    /// </summary>
    [IsoId("b567fa88-sbsc-0001-0020-cbedd3f4632d")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    [MinLength(1)]
    public ValueList<SwitchSubscriptionLegExecution5> SubscriptionLegDetails { get; init; } = [];

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("b567fa88-cshs-0001-0021-cbedd3f4632d")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction181? CashSettlementDetails { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.|Information needed to process a currency exchange or conversion.|How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:|EXAMPLE 1 |UnitCurrency EUR|QuotedCurrency USD|ExchangeRate 1.300|EXAMPLE 2|UnitCurrency USD|QuotedCurrency EUR|ExchangeRate 0.769.
    /// </summary>
    [IsoId("b567fa88-fxdt-0001-0022-cbedd3f4632d")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("b567fa88-fnad-0001-0023-cbedd3f4632d")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; }

    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("b567fa88-ngtd-0001-0024-cbedd3f4632d")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; }

    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    [IsoId("b567fa88-late-0001-0025-cbedd3f4632d")]
    [DisplayName("Late Report")]
    [IsoXmlTag("LateRpt")]
    public LateReport1Code? LateReport { get; init; }

    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [IsoId("b567fa88-cstm-0001-0026-cbedd3f4632d")]
    [DisplayName("Customer Conduct Classification")]
    [IsoXmlTag("CstmrCndctClssfctn")]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; }

    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [IsoId("b567fa88-txch-0001-0027-cbedd3f4632d")]
    [DisplayName("Transaction Channel Type")]
    [IsoXmlTag("TxChanlTp")]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("b567fa88-sgnr-0001-0028-cbedd3f4632d")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public SignatureType1Choice_? SignatureType { get; init; }

    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [IsoId("b567fa88-orwd-0001-0029-cbedd3f4632d")]
    [DisplayName("Order Waiver Details")]
    [IsoXmlTag("OrdrWvrDtls")]
    public OrderWaiver1? OrderWaiverDetails { get; init; }
}
