// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables related to derivatives that are used to group derivatives together into positions for position sets and currency position sets reports. 
/// </summary>
[IsoId("_0xmkFQ1MEeqV4s5SpzR1dQ")]
[DisplayName("Position Set Dimensions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetDimensions3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_0yWyAQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeCounterpartyReport9? CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyReport9? CounterpartyIdentification { get; init; } 
    #else
    public TradeCounterpartyReport9? CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used for the valuation of the contract.
    /// </summary>
    [IsoId("_0yWyAw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Value Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValCcy")]
    #endif
    [IsoXmlTag("ValCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? ValueCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ValueCurrency { get; init; } 
    #else
    public string? ValueCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_0yWyBQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Collateralisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Collstn")]
    #endif
    [IsoXmlTag("Collstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralisationType1Code? Collateralisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationType1Code? Collateralisation { get; init; } 
    #else
    public CollateralisationType1Code? Collateralisation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the portfolio if collateral is reported on a portfolio basis, as defined by the reporting counterparty.
    /// </summary>
    [IsoId("_0yWyBw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Portfolio { get; init; } 
    #else
    public System.String? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Classification according to the contract type.
    /// </summary>
    [IsoId("_0yWyCQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #else
    public FinancialInstrumentContractType2Code? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_0yWyCw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductType4Code? AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType4Code? AssetClass { get; init; } 
    #else
    public ProductType4Code? AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_0yWyDQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Underlying Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrm")]
    #endif
    [IsoXmlTag("UndrlygInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    #else
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    [IsoId("_0yWyDw1MEeqV4s5SpzR1dQ")]
    [DisplayName("First Leg Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstLegNtnlCcy")]
    #endif
    [IsoXmlTag("FrstLegNtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? FirstLegNotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? FirstLegNotionalCurrency { get; init; } 
    #else
    public string? FirstLegNotionalCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    [IsoId("_0yWyEQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Second Leg Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLegNtnlCcy")]
    #endif
    [IsoXmlTag("ScndLegNtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SecondLegNotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SecondLegNotionalCurrency { get; init; } 
    #else
    public string? SecondLegNotionalCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency of delivery.
    /// </summary>
    [IsoId("_0yWyEw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Deliverable Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrblCcy")]
    #endif
    [IsoXmlTag("DlvrblCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? DeliverableCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DeliverableCurrency { get; init; } 
    #else
    public string? DeliverableCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the cross currency, if different from the currency of delivery.
    /// </summary>
    [IsoId("_0yWyFQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Deliverable Cross Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrblCrossCcy")]
    #endif
    [IsoXmlTag("DlvrblCrossCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? DeliverableCrossCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DeliverableCrossCurrency { get; init; } 
    #else
    public string? DeliverableCrossCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_0yWyFw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmt")]
    #endif
    [IsoXmlTag("MstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement2? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement2? MasterAgreement { get; init; } 
    #else
    public MasterAgreement2? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    [IsoId("_0yWyGQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSts")]
    #endif
    [IsoXmlTag("ClrSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingStatus { get; init; } 
    #else
    public System.String? ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contract was entered into as an intragroup transaction.
    /// Usage: When absent, default value is false.
    /// </summary>
    [IsoId("_0yWyGw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Intra Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraGrp")]
    #endif
    [IsoXmlTag("IntraGrp")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? IntraGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntraGroup { get; init; } 
    #else
    public System.String? IntraGroup { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the quote base for the exchange rate.
    /// </summary>
    [IsoId("_0yWyHQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Exchange Rate Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateBsis")]
    #endif
    [IsoXmlTag("XchgRateBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    #else
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_0yWyHw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType2Code? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType2Code? OptionType { get; init; } 
    #else
    public OptionType2Code? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between a maturity date of a derivative and the reference date, based on a Gregorian calendar.
    /// </summary>
    [IsoId("_0yWyIQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Time To Maturity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmToMtrty")]
    #endif
    [IsoXmlTag("TmToMtrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeToMaturity1Choice_? TimeToMaturity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeToMaturity1Choice_? TimeToMaturity { get; init; } 
    #else
    public TimeToMaturity1Choice_? TimeToMaturity { get; set; } 
    #endif
    
    /// <summary>
    /// Groups of IRS (Internal Revenue Service) derivatives with reference to whether leg 1 and leg 2 are fixed or floating.
    /// </summary>
    [IsoId("_0yWyIw1MEeqV4s5SpzR1dQ")]
    [DisplayName("IRS Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IRSTp")]
    #endif
    [IsoXmlTag("IRSTp")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? IRSType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IRSType { get; init; } 
    #else
    public System.String? IRSType { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of seniority in case of contract on index or on a single name entity.
    /// </summary>
    [IsoId("_0yWyJQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Seniority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Snrty")]
    #endif
    [IsoXmlTag("Snrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrumentSeniorityType2Code? Seniority { get; init; } 
    #else
    public DebtInstrumentSeniorityType2Code? Seniority { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative contract is tranched or not.
    /// </summary>
    [IsoId("_0yWyJw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Tranche")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trch")]
    #endif
    [IsoXmlTag("Trch")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Tranche { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Tranche { get; init; } 
    #else
    public System.String? Tranche { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the commodity asset class type.
    /// </summary>
    [IsoId("_0yWyKQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Commodity { get; init; } 
    #else
    public System.String? Commodity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
