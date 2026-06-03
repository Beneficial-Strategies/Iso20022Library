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
    [IsoId("_2r9uaao2EfCG2_q2WT-90w")]
    [DisplayName("Margin Account")]
    [IsoXmlTag("MrgnAcct")]
    public SecuritiesAccount19? MarginAccount { get; init; }

    [IsoId("_2r9ub6o2EfCG2_q2WT-90w")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    [IsoId("_2r9udao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    public required IsoMax35Text TradeLegIdentification { get; init; }

    [IsoId("_2r9ue6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public IsoMax35Text? TradeIdentification { get; init; }

    [IsoId("_2r9ugao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    public IsoMax35Text? TradeExecutionIdentification { get; init; }

    [IsoId("_2r9uh6o2EfCG2_q2WT-90w")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("_2r9uiao2EfCG2_q2WT-90w")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    public IsoMax35Text? OrderIdentification { get; init; }

    [IsoId("_2r9uj6o2EfCG2_q2WT-90w")]
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    public IsoMax35Text? AllocationIdentification { get; init; }

    [IsoId("_2r9ulao2EfCG2_q2WT-90w")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    [IsoId("_2r9um6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required DateAndDateTime2Choice_ TradeDate { get; init; }

    [IsoId("_2r9uoao2EfCG2_q2WT-90w")]
    [DisplayName("Transaction Date And Time")]
    [IsoXmlTag("TxDtAndTm")]
    public IsoISODateTime? TransactionDateAndTime { get; init; }

    [IsoId("_2r9up6o2EfCG2_q2WT-90w")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat66Choice_? SettlementDate { get; init; }

    [IsoId("_2r9urao2EfCG2_q2WT-90w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification48 FinancialInstrumentIdentification { get; init; }

    [IsoId("_2r9us6o2EfCG2_q2WT-90w")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }

    [IsoId("_2r9uuao2EfCG2_q2WT-90w")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; }

    [IsoId("_2r9uv6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; }

    [IsoId("_2r9uxao2EfCG2_q2WT-90w")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price14 DealPrice { get; init; }

    [IsoId("_2r9uy6o2EfCG2_q2WT-90w")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    [IsoId("_2r9u0ao2EfCG2_q2WT-90w")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; }

    [IsoId("_2r9u16o2EfCG2_q2WT-90w")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; }

    [IsoId("_2r9u3ao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; }

    [IsoId("_TswSIao5EfCG2_q2WT-90w")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } = [];

    [IsoId("_2r9u46o2EfCG2_q2WT-90w")]
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; }

    [IsoId("_2r9u6ao2EfCG2_q2WT-90w")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount230? Broker { get; init; }

    [IsoId("_2r9u76o2EfCG2_q2WT-90w")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification253Choice_ TradingParty { get; init; }

    [IsoId("_2r9u9ao2EfCG2_q2WT-90w")]
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; }

    [IsoId("_2r9u-6o2EfCG2_q2WT-90w")]
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; }

    [IsoId("_2r9vAao2EfCG2_q2WT-90w")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity10Code TradingCapacity { get; init; }

    [IsoId("_2r9vB6o2EfCG2_q2WT-90w")]
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; }

    [IsoId("_2r9vDao2EfCG2_q2WT-90w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat43Choice_? SafekeepingPlace { get; init; }

    [IsoId("_2r9vE6o2EfCG2_q2WT-90w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_2r9vGao2EfCG2_q2WT-90w")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public Settlement2? SettlementDetails { get; init; }

    [IsoId("_2r9vH6o2EfCG2_q2WT-90w")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing8? ClearingDetails { get; init; }

    [IsoId("_2r9vJao2EfCG2_q2WT-90w")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; }
}
