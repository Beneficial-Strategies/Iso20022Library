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
[IsoId("_0eGloS0qEeSRe9rElPHBfg")]
[DisplayName("Trade Leg")]
public partial record TradeLeg8
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction (that is the trade leg) as known by the instructing party.
    /// </summary>
    [IsoId("_0w_scS0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeLegIdentification { get; init; } 
    
    /// <summary>
    /// Reference allocated by the broker dealer.
    /// </summary>
    [IsoId("_0w_scy0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TradeIdentification { get; init; } 
    
    /// <summary>
    /// Unique reference assigned by the trading venue when the trade is executed.
    /// </summary>
    [IsoId("_0w_sdS0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Execution Identification")]
    [IsoXmlTag("TradExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeExecutionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the order sent by the final investor to an intermediary in order to initiate a trade in the former&apos;s name. This identification is then matched with the equivalent trade by the clearing.
    /// </summary>
    [IsoId("_NgTCUC0sEeSRe9rElPHBfg")]
    [DisplayName("Order Identification")]
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OrderIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the portion of assets within a determined trade that shall be allocated to different clients.
    /// </summary>
    [IsoId("_C0D-kC0rEeSRe9rElPHBfg")]
    [DisplayName("Allocation Identification")]
    [IsoXmlTag("AllcnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AllocationIdentification { get; init; } 
    
    /// <summary>
    /// Provides the status of the trade leg.
    /// </summary>
    [IsoId("_0w_sdy0qEeSRe9rElPHBfg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status5Code? Status { get; init; } 
    
    /// <summary>
    /// Provides the date and time of trade transaction.
    /// </summary>
    [IsoId("_0w_seS0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TradeDate { get; init; } 
    
    /// <summary>
    /// Date and time used to determine the price applicable to a trade. If the trade is registered &quot;after market&quot; hours, the trading price will the price of the day but the actual trade date will be the next working day.
    /// </summary>
    [IsoId("_7wEFcC0sEeSRe9rElPHBfg")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateTime { get; init; } 
    
    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_0w_sey0qEeSRe9rElPHBfg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateFormat15Choice_? SettlementDate { get; init; } 
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_0w_sfS0qEeSRe9rElPHBfg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_0w_sfy0qEeSRe9rElPHBfg")]
    [DisplayName("Trading Currency")]
    [IsoXmlTag("TradgCcy")]
    public CurrencyCode? TradingCurrency { get; init; } 
    
    /// <summary>
    /// Identifies the trade leg indicator which gives the trade side (buy or sell).
    /// </summary>
    [IsoId("_0w_sgS0qEeSRe9rElPHBfg")]
    [DisplayName("Buy Sell Indicator")]
    [IsoXmlTag("BuySellInd")]
    public required Side1Code BuySellIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_0w_sgy0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Quantity")]
    [IsoXmlTag("TradQty")]
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the price of the traded financial instrument.
    /// </summary>
    [IsoId("_0w_shS0qEeSRe9rElPHBfg")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price4 DealPrice { get; init; } 
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_Iz95QC0wEeSRe9rElPHBfg")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public AmountAndDirection21? GrossAmount { get; init; } 
    
    /// <summary>
    /// Interest that has accumulated on a bond since the last interest payment up to, but not including, the settlement date.
    /// </summary>
    [IsoId("_0w_shy0qEeSRe9rElPHBfg")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_0w_siS0qEeSRe9rElPHBfg")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Place at which the security is listed.
    /// </summary>
    [IsoId("_0w_siy0qEeSRe9rElPHBfg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification85? PlaceOfListing { get; init; } 
    
    /// <summary>
    /// Identifies the type of trade transaction.
    /// </summary>
    [IsoId("_0w_sjS0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType1Code TradeType { get; init; } 
    
    /// <summary>
    /// Indicates that the trade is for settlement of an exercised derivatives contract.
    /// </summary>
    [IsoId("_0w_sjy0qEeSRe9rElPHBfg")]
    [DisplayName("Derivative Related Trade")]
    [IsoXmlTag("DerivRltdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; } 
    
    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker or prime broker).
    /// </summary>
    [IsoId("_4kq88C0rEeSRe9rElPHBfg")]
    [DisplayName("Broker")]
    [IsoXmlTag("Brkr")]
    public PartyIdentificationAndAccount100? Broker { get; init; } 
    
    /// <summary>
    /// Provides the identification of the trading party.
    /// </summary>
    [IsoId("_0w_skS0qEeSRe9rElPHBfg")]
    [DisplayName("Trading Party")]
    [IsoXmlTag("TradgPty")]
    public required PartyIdentification35Choice_ TradingParty { get; init; } 
    
    /// <summary>
    /// Indicates in which session the transaction/operation was executed by the final investor or an intermediary.
    /// </summary>
    [IsoId("_A09bUC0wEeSRe9rElPHBfg")]
    [DisplayName("Trade Registration Origin")]
    [IsoXmlTag("TradRegnOrgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TradeRegistrationOrigin { get; init; } 
    
    /// <summary>
    /// Identifier of the trading participant&apos;s account at the trading venue using the venue&apos;s coding system.
    /// </summary>
    [IsoId("_0w_sky0qEeSRe9rElPHBfg")]
    [DisplayName("Trading Party Account")]
    [IsoXmlTag("TradgPtyAcct")]
    public SecuritiesAccount19? TradingPartyAccount { get; init; } 
    
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_0w_slS0qEeSRe9rElPHBfg")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public required TradingCapacity5Code TradingCapacity { get; init; } 
    
    /// <summary>
    /// Indicates how a trade is maintained in the clearing account.
    /// </summary>
    [IsoId("_0w_sly0qEeSRe9rElPHBfg")]
    [DisplayName("Trade Posting Code")]
    [IsoXmlTag("TradPstngCd")]
    public TradePosting1Code? TradePostingCode { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_TiEM8C0rEeSRe9rElPHBfg")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_c8xM0C0rEeSRe9rElPHBfg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    
    #nullable disable
    
}
