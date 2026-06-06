// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the trade leg details.
/// </summary>
[IsoId("_2q6lnao2EfCG2_q2WT-90w")]
[DisplayName("Trade Leg15")]
public record TradeLeg15
{
    /// <summary>
    /// Margin account where the negotiation and liquidation risks will be calculated.
    /// </summary>
    [IsoId("_2r9uaao2EfCG2_q2WT-90w")]
    [DisplayName("Margin Account")]
    [IsoXmlTag("MrgnAcct")]
    public SecuritiesAccount19? MarginAccount { get; init; }

    /// <summary>
    /// Account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_2r9ub6o2EfCG2_q2WT-90w")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction (that is the trade leg) as known by the instructing party.
    /// </summary>
    [IsoId("_2r9udao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    public required IsoMax35Text TradeLegIdentification { get; init; }

    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_2r9ue6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public IsoMax35Text? TradeIdentification { get; init; }

    /// <summary>
    /// Unique reference assigned by the trading venue when the trade is executed.
    /// </summary>
    [IsoId("_2r9ugao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    public IsoMax35Text? TradeExecutionIdentification { get; init; }

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_2r9uh6o2EfCG2_q2WT-90w")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Identifies the order sent by the final investor to an intermediary in order to initiate a trade in the former's name. This identification is then matched with the equivalent trade by the clearing.
    /// </summary>
    [IsoId("_2r9uiao2EfCG2_q2WT-90w")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    public IsoMax35Text? OrderIdentification { get; init; }

    /// <summary>
    /// Identifies the portion of assets within a determined trade that shall be allocated to different clients.
    /// </summary>
    [IsoId("_2r9uj6o2EfCG2_q2WT-90w")]
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    public IsoMax35Text? AllocationIdentification { get; init; }

    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_2r9ulao2EfCG2_q2WT-90w")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    /// <summary>
    /// Provides the date or date and time of trade transaction.
    /// </summary>
    [IsoId("_2r9um6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required DateAndDateTime2Choice_ TradeDate { get; init; }

    /// <summary>
    /// Date and time used to determine the price applicable to a trade. If the trade is registered "after market" hours, the trading price will the price of the day but the actual trade date will be the next working day.
    /// </summary>
    [IsoId("_2r9uoao2EfCG2_q2WT-90w")]
    [DisplayName("Transaction Date And Time")]
    [IsoXmlTag("TxDtAndTm")]
    public IsoISODateTime? TransactionDateAndTime { get; init; }

    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_2r9up6o2EfCG2_q2WT-90w")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat66Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_2r9urao2EfCG2_q2WT-90w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification48 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_2r9us6o2EfCG2_q2WT-90w")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }

    /// <summary>
    /// Identifies the trade leg indicator which gives the trade side (buy or sell).
    /// </summary>
    [IsoId("_2r9uuao2EfCG2_q2WT-90w")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; }

    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_2r9uv6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; }

    /// <summary>
    /// Specifies the price of the traded financial instrument.
    /// </summary>
    [IsoId("_2r9uxao2EfCG2_q2WT-90w")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price14 DealPrice { get; init; }

    /// <summary>
    /// Interest that has accumulated on a bond since the last interest payment up to, but not including, the settlement date.
    /// </summary>
    [IsoId("_2r9uy6o2EfCG2_q2WT-90w")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_2r9u0ao2EfCG2_q2WT-90w")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; }

    /// <summary>
    /// Place at which the security is listed.
    /// </summary>
    [IsoId("_2r9u16o2EfCG2_q2WT-90w")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; }

    /// <summary>
    /// Identifies the type of trade transaction.
    /// </summary>
    [IsoId("_2r9u3ao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; }

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was excuted.
    /// </summary>
    [IsoId("_TswSIao5EfCG2_q2WT-90w")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Indicates that the trade is for settlement of an exercised derivatives contract.
    /// </summary>
    [IsoId("_2r9u46o2EfCG2_q2WT-90w")]
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; }

    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker or prime broker).
    /// </summary>
    [IsoId("_2r9u6ao2EfCG2_q2WT-90w")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount230? Broker { get; init; }

    /// <summary>
    /// Provides the identification of the trading party.
    /// </summary>
    [IsoId("_2r9u76o2EfCG2_q2WT-90w")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification253Choice_ TradingParty { get; init; }

    /// <summary>
    /// Indicates in which session the transaction/operation was executed by the final investor or an intermediary.
    /// </summary>
    [IsoId("_2r9u9ao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; }

    /// <summary>
    /// Identifier of the trading participant's account at the trading venue using the venue's coding system.
    /// </summary>
    [IsoId("_2r9u-6o2EfCG2_q2WT-90w")]
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; }

    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_2r9vAao2EfCG2_q2WT-90w")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity10Code TradingCapacity { get; init; }

    /// <summary>
    /// Indicates how a trade is maintained in the clearing account.
    /// </summary>
    [IsoId("_2r9vB6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_2r9vDao2EfCG2_q2WT-90w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat43Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_2r9vE6o2EfCG2_q2WT-90w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Provides settlement details such as the settlement amount or the place of settlement.
    /// </summary>
    [IsoId("_2r9vGao2EfCG2_q2WT-90w")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public Settlement2? SettlementDetails { get; init; }

    /// <summary>
    /// Provides clearing details such as the non clearing member identification or the settlement netting (or not) eligibility code.
    /// </summary>
    [IsoId("_2r9vH6o2EfCG2_q2WT-90w")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing8? ClearingDetails { get; init; }

    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_2r9vJao2EfCG2_q2WT-90w")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; }
}
