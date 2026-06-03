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
[IsoId("_ykf0oao0EfCG2_q2WT-90w")]
[DisplayName("Trade Leg14")]
public record TradeLeg14
{
    [IsoId("_yli9h6o0EfCG2_q2WT-90w")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    public required IsoMax35Text TradeLegIdentification { get; init; }

    [IsoId("_yli9jao0EfCG2_q2WT-90w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public IsoMax35Text? TradeIdentification { get; init; }

    [IsoId("_yli9k6o0EfCG2_q2WT-90w")]
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    public IsoMax35Text? TradeExecutionIdentification { get; init; }

    [IsoId("_yli9mao0EfCG2_q2WT-90w")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("_yli9m6o0EfCG2_q2WT-90w")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    public IsoMax35Text? OrderIdentification { get; init; }

    [IsoId("_yli9oao0EfCG2_q2WT-90w")]
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    public IsoMax35Text? AllocationIdentification { get; init; }

    [IsoId("_yli9p6o0EfCG2_q2WT-90w")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status5Code? Status { get; init; }

    [IsoId("_yli9rao0EfCG2_q2WT-90w")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required DateAndDateTime2Choice_ TradeDate { get; init; }

    [IsoId("_yli9s6o0EfCG2_q2WT-90w")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    public IsoISODateTime? TransactionDateTime { get; init; }

    [IsoId("_yli9uao0EfCG2_q2WT-90w")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat66Choice_? SettlementDate { get; init; }

    [IsoId("_yli9v6o0EfCG2_q2WT-90w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification48 FinancialInstrumentIdentification { get; init; }

    [IsoId("_yli9xao0EfCG2_q2WT-90w")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }

    [IsoId("_yli9y6o0EfCG2_q2WT-90w")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; }

    [IsoId("_yli90ao0EfCG2_q2WT-90w")]
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; }

    [IsoId("_yli916o0EfCG2_q2WT-90w")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price14 DealPrice { get; init; }

    [IsoId("_yli93ao0EfCG2_q2WT-90w")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; }

    [IsoId("_yli946o0EfCG2_q2WT-90w")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    [IsoId("_yli96ao0EfCG2_q2WT-90w")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; }

    [IsoId("_yli976o0EfCG2_q2WT-90w")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; }

    [IsoId("_yli99ao0EfCG2_q2WT-90w")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; }

    [IsoId("_L4fBYKo1EfCG2_q2WT-90w")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } = [];

    [IsoId("_yli9-6o0EfCG2_q2WT-90w")]
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; }

    [IsoId("_yli-Aao0EfCG2_q2WT-90w")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount230? Broker { get; init; }

    [IsoId("_yli-B6o0EfCG2_q2WT-90w")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification253Choice_ TradingParty { get; init; }

    [IsoId("_yli-Dao0EfCG2_q2WT-90w")]
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; }

    [IsoId("_yli-E6o0EfCG2_q2WT-90w")]
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; }

    [IsoId("_yli-Gao0EfCG2_q2WT-90w")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity10Code TradingCapacity { get; init; }

    [IsoId("_yli-H6o0EfCG2_q2WT-90w")]
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; }

    [IsoId("_yli-Jao0EfCG2_q2WT-90w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat43Choice_? SafekeepingPlace { get; init; }

    [IsoId("_yli-K6o0EfCG2_q2WT-90w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }
}
