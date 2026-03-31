// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Leg12.
/// </summary>
[IsoId("_VjYuyYcREe-U27oWwgmhCQ")]
[DisplayName("Trade Leg12")]
public record TradeLeg12
{
    /// <summary>
    /// Accrued Interest Amount.
    /// </summary>
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Allocation Identification.
    /// </summary>
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    public IsoMax35Text? AllocationIdentification { get; init; }

    /// <summary>
    /// Broker.
    /// </summary>
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount230? Broker { get; init; }

    /// <summary>
    /// Buy Sell Indicator.
    /// </summary>
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; }

    /// <summary>
    /// Clearing Details.
    /// </summary>
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing7? ClearingDetails { get; init; }

    /// <summary>
    /// Deal Price.
    /// </summary>
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price14 DealPrice { get; init; }

    /// <summary>
    /// Delivery Account.
    /// </summary>
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Derivative Related Trade.
    /// </summary>
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification48 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Gross Amount.
    /// </summary>
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; }

    /// <summary>
    /// Margin Account.
    /// </summary>
    [DisplayName("Margin Account")]
    [IsoXmlTag("MrgnAcct")]
    public SecuritiesAccount19? MarginAccount { get; init; }

    /// <summary>
    /// Non Clearing Member.
    /// </summary>
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount227? NonClearingMember { get; init; }

    /// <summary>
    /// Order Identification.
    /// </summary>
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    public IsoMax35Text? OrderIdentification { get; init; }

    /// <summary>
    /// Place Of Listing.
    /// </summary>
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; }

    /// <summary>
    /// Place Of Trade.
    /// </summary>
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; }

    /// <summary>
    /// Safekeeping Account.
    /// </summary>
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat43Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat66Choice_? SettlementDate { get; init; }

    /// <summary>
    /// Settlement Details.
    /// </summary>
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public Settlement2? SettlementDetails { get; init; }

    /// <summary>
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required IsoISODateTime TradeDate { get; init; }

    /// <summary>
    /// Trade Execution Identification.
    /// </summary>
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    public IsoMax35Text? TradeExecutionIdentification { get; init; }

    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public IsoMax35Text? TradeIdentification { get; init; }

    /// <summary>
    /// Trade Leg Identification.
    /// </summary>
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    public required IsoMax35Text TradeLegIdentification { get; init; }

    /// <summary>
    /// Trade Posting Code.
    /// </summary>
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; }

    /// <summary>
    /// Trade Quantity.
    /// </summary>
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; }

    /// <summary>
    /// Trade Registration Origin.
    /// </summary>
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; }

    /// <summary>
    /// Trade Type.
    /// </summary>
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; }

    /// <summary>
    /// Trading Capacity.
    /// </summary>
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity5Code TradingCapacity { get; init; }

    /// <summary>
    /// Trading Currency.
    /// </summary>
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; }

    /// <summary>
    /// Trading Party.
    /// </summary>
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification253Choice_ TradingParty { get; init; }

    /// <summary>
    /// Trading Party Account.
    /// </summary>
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; }

    /// <summary>
    /// Transaction Date And Time.
    /// </summary>
    [DisplayName("Transaction Date And Time")]
    [IsoXmlTag("TxDtAndTm")]
    public IsoISODateTime? TransactionDateAndTime { get; init; }

    /// <summary>
    /// Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }
}
