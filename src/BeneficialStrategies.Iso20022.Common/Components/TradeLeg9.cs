// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the trade leg details.
/// </summary>
[IsoId("_bBw7kS6SEeSQQqw1BT_aMg")]
[DisplayName("Trade Leg")]
public partial record TradeLeg9
{
    #nullable enable
    
    /// <summary>
    /// Margin account where the negotiation and liquidation risks will be calculated.
    /// </summary>
    [IsoId("_bVGuUy6SEeSQQqw1BT_aMg")]
    [DisplayName("Margin Account")]
    [IsoXmlTag("MrgnAcct")]
    public SecuritiesAccount19? MarginAccount { get; init; } 
    
    /// <summary>
    /// Account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_bVGuVS6SEeSQQqw1BT_aMg")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transaction (that is the trade leg) as known by the instructing party.
    /// </summary>
    [IsoId("_bVGuVy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeLegIdentification { get; init; } 
    
    /// <summary>
    /// Reference allocated by the broker dealer.
    /// </summary>
    [IsoId("_bVGuWS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TradeIdentification { get; init; } 
    
    /// <summary>
    /// Unique reference assigned by the trading venue when the trade is executed.
    /// </summary>
    [IsoId("_bVGuWy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeExecutionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the order sent by the final investor to an intermediary in order to initiate a trade in the former&apos;s name. This identification is then matched with the equivalent trade by the clearing.
    /// </summary>
    [IsoId("_qeNwkC6UEeSQQqw1BT_aMg")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the portion of assets within a determined trade that shall be allocated to different clients.
    /// </summary>
    [IsoId("_YReIwC6TEeSQQqw1BT_aMg")]
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AllocationIdentification { get; init; } 
    
    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_bVGuXS6SEeSQQqw1BT_aMg")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    
    /// <summary>
    /// Provides the date and time of trade transaction.
    /// </summary>
    [IsoId("_bVGuXy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TradeDate { get; init; } 
    
    /// <summary>
    /// Date and time used to determine the price applicable to a trade. If the trade is registered &quot;after market&quot; hours, the trading price will the price of the day but the actual trade date will be the next working day.
    /// </summary>
    [IsoId("_QTIHQC6VEeSQQqw1BT_aMg")]
    [DisplayName("Transaction Date And Time")]
    [IsoXmlTag("TxDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateAndTime { get; init; } 
    
    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_bVGuYS6SEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat15Choice_? SettlementDate { get; init; } 
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_bVGuYy6SEeSQQqw1BT_aMg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_bVGuZS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; } 
    
    /// <summary>
    /// Identifies the trade leg indicator which gives the trade side (buy or sell).
    /// </summary>
    [IsoId("_bVGuZy6SEeSQQqw1BT_aMg")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_bVGuaS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the price of the traded financial instrument.
    /// </summary>
    [IsoId("_bVGuay6SEeSQQqw1BT_aMg")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price4 DealPrice { get; init; } 
    
    /// <summary>
    /// Interest that has accumulated on a bond since the last interest payment up to, but not including, the settlement date.
    /// </summary>
    [IsoId("_bVGubS6SEeSQQqw1BT_aMg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_bVGuby6SEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Place at which the security is listed.
    /// </summary>
    [IsoId("_bVGucS6SEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; } 
    
    /// <summary>
    /// Identifies the type of trade transaction.
    /// </summary>
    [IsoId("_bVGucy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; } 
    
    /// <summary>
    /// Indicates that the trade is for settlement of an exercised derivatives contract.
    /// </summary>
    [IsoId("_bVGudS6SEeSQQqw1BT_aMg")]
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; } 
    
    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker or prime broker).
    /// </summary>
    [IsoId("_12bGQC9VEeS94oXWDaBauA")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount100? Broker { get; init; } 
    
    /// <summary>
    /// Provides the identification of the trading party.
    /// </summary>
    [IsoId("_bVGudy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification35Choice_ TradingParty { get; init; } 
    
    /// <summary>
    /// Indicates in which session the transaction/operation was executed by the final investor or an intermediary.
    /// </summary>
    [IsoId("_qEZs8C6VEeSQQqw1BT_aMg")]
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; } 
    
    /// <summary>
    /// Identifier of the trading participant&apos;s account at the trading venue using the venue&apos;s coding system.
    /// </summary>
    [IsoId("_bVGueS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; } 
    
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_bVGuey6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity5Code TradingCapacity { get; init; } 
    
    /// <summary>
    /// Indicates how a trade is maintained in the clearing account.
    /// </summary>
    [IsoId("_bVGufS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_UbaAsC6UEeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_dmB9MC6UEeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Provides settlement details such as the settlement amount or the place of settlement.
    /// </summary>
    [IsoId("_bVGufy6SEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public Settlement1? SettlementDetails { get; init; } 
    
    /// <summary>
    /// Provides clearing details such as the non clearing member identification or the settlement netting (or not) eligibility code.
    /// </summary>
    [IsoId("_bVGugS6SEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing4? ClearingDetails { get; init; } 
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_Gq1eoC9WEeS94oXWDaBauA")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; } 
    
    
    #nullable disable
    
}
