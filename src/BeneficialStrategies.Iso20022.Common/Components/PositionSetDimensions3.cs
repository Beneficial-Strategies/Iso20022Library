// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables related to derivatives that are used to group derivatives together into positions for position sets and currency position sets reports. 
/// </summary>
[IsoId("_0xmkFQ1MEeqV4s5SpzR1dQ")]
[DisplayName("Position Set Dimensions")]
public partial record PositionSetDimensions3
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_0yWyAQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public TradeCounterpartyReport9? CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Currency used for the valuation of the contract.
    /// </summary>
    [IsoId("_0yWyAw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Value Currency")]
    [IsoXmlTag("ValCcy")]
    public ActiveOrHistoricCurrencyCode? ValueCurrency { get; init; } 
    
    /// <summary>
    /// Type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_0yWyBQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Collateralisation")]
    [IsoXmlTag("Collstn")]
    public CollateralisationType1Code? Collateralisation { get; init; } 
    
    /// <summary>
    /// Identifies the portfolio if collateral is reported on a portfolio basis, as defined by the reporting counterparty.
    /// </summary>
    [IsoId("_0yWyBw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? Portfolio { get; init; } 
    
    /// <summary>
    /// Classification according to the contract type.
    /// </summary>
    [IsoId("_0yWyCQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    
    /// <summary>
    /// Classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_0yWyCw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; } 
    
    /// <summary>
    /// Unique identification of the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_0yWyDQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    [IsoId("_0yWyDw1MEeqV4s5SpzR1dQ")]
    [DisplayName("First Leg Notional Currency")]
    [IsoXmlTag("FrstLegNtnlCcy")]
    public ActiveCurrencyCode? FirstLegNotionalCurrency { get; init; } 
    
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    [IsoId("_0yWyEQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Second Leg Notional Currency")]
    [IsoXmlTag("ScndLegNtnlCcy")]
    public ActiveCurrencyCode? SecondLegNotionalCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the currency of delivery.
    /// </summary>
    [IsoId("_0yWyEw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Deliverable Currency")]
    [IsoXmlTag("DlvrblCcy")]
    public ActiveCurrencyCode? DeliverableCurrency { get; init; } 
    
    /// <summary>
    /// Indicates the cross currency, if different from the currency of delivery.
    /// </summary>
    [IsoId("_0yWyFQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Deliverable Cross Currency")]
    [IsoXmlTag("DlvrblCrossCcy")]
    public ActiveOrHistoricCurrencyCode? DeliverableCrossCurrency { get; init; } 
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_0yWyFw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Master Agreement")]
    [IsoXmlTag("MstrAgrmt")]
    public MasterAgreement2? MasterAgreement { get; init; } 
    
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_0yWyGQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ClearingStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the contract was entered into as an intragroup transaction.
    /// Usage: When absent, default value is false.
    /// </summary>
    [IsoId("_0yWyGw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Intra Group")]
    [IsoXmlTag("IntraGrp")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IntraGroup { get; init; } 
    
    /// <summary>
    /// Indicates the quote base for the exchange rate.
    /// </summary>
    [IsoId("_0yWyHQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Exchange Rate Basis")]
    [IsoXmlTag("XchgRateBsis")]
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    
    /// <summary>
    /// Specifies the type of the option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_0yWyHw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType2Code? OptionType { get; init; } 
    
    /// <summary>
    /// Difference between a maturity date of a derivative and the reference date, based on a Gregorian calendar.
    /// </summary>
    [IsoId("_0yWyIQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Time To Maturity")]
    [IsoXmlTag("TmToMtrty")]
    public TimeToMaturity1Choice_? TimeToMaturity { get; init; } 
    
    /// <summary>
    /// Groups of IRS (Internal Revenue Service) derivatives with reference to whether leg 1 and leg 2 are fixed or floating.
    /// </summary>
    [IsoId("_0yWyIw1MEeqV4s5SpzR1dQ")]
    [DisplayName("IRS Type")]
    [IsoXmlTag("IRSTp")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? IRSType { get; init; } 
    
    /// <summary>
    /// Classification of seniority in case of contract on index or on a single name entity.
    /// </summary>
    [IsoId("_0yWyJQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Seniority")]
    [IsoXmlTag("Snrty")]
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    
    /// <summary>
    /// Indicates whether the derivative contract is tranched or not.
    /// </summary>
    [IsoId("_0yWyJw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Tranche")]
    [IsoXmlTag("Trch")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Tranche { get; init; } 
    
    /// <summary>
    /// Details on the commodity asset class type.
    /// </summary>
    [IsoId("_0yWyKQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? Commodity { get; init; } 
    
    
    #nullable disable
    
}
