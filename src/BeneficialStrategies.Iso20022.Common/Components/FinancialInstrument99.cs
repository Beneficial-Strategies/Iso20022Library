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
/// Identification of a security or other asset.
/// </summary>
[IsoId("_ZpT6delaEeu9cf4XM82AQQ")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument99
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument99 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument99( FinancialInstrument62Choice_ reqInstrument )
    {
        Instrument = reqInstrument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("_Z-ncB-laEeu9cf4XM82AQQ")]
    [DisplayName("Line Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineId")]
    #endif
    [IsoXmlTag("LineId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LineIdentification { get; init; } 
    #else
    public System.String? LineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_Z-ncCelaEeu9cf4XM82AQQ")]
    [DisplayName("Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instrm")]
    #endif
    [IsoXmlTag("Instrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument62Choice_ Instrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument62Choice_ Instrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument62Choice_ Instrument { get; init; } 
    #else
    public FinancialInstrument62Choice_ Instrument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_Z-ncC-laEeu9cf4XM82AQQ")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity47? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity47? Quantity { get; init; } 
    #else
    public Quantity47? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("_Z-ncDelaEeu9cf4XM82AQQ")]
    [DisplayName("Units Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsDtls")]
    #endif
    [IsoXmlTag("UnitsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unit11? UnitsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unit11? UnitsDetails { get; init; } 
    #else
    public Unit11? UnitsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Z-ncD-laEeu9cf4XM82AQQ")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? ClientReference { get; init; } 
    #else
    public AdditionalReference10? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_Z-ncEelaEeu9cf4XM82AQQ")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference10? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Business process in which the actors are involved. This will facilitate the right business process to be triggered, according to the market business model, which may require matching instructions (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_Z-ncE-laEeu9cf4XM82AQQ")]
    [DisplayName("Business Flow Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizFlowTp")]
    #endif
    [IsoXmlTag("BizFlowTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    #else
    public BusinessFlowType1Code? BusinessFlowType { get; set; } 
    #endif
    
    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_Z-ncFelaEeu9cf4XM82AQQ")]
    [DisplayName("Average Acquisition Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgAcqstnPric")]
    #endif
    [IsoXmlTag("AvrgAcqstnPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_D7S0IOltEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfCcy")]
    #endif
    [IsoXmlTag("TrfCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TransferCurrency { get; init; } 
    #else
    public string? TransferCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_Z-ncF-laEeu9cf4XM82AQQ")]
    [DisplayName("Total Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBookVal")]
    #endif
    [IsoXmlTag("TtlBookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? TotalBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? TotalBookValue { get; init; } 
    #else
    public DateAndAmount2? TotalBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Date and market value of the asset. 
    /// </summary>
    [IsoId("_Z-ncGelaEeu9cf4XM82AQQ")]
    [DisplayName("Latest Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LatstValtn")]
    #endif
    [IsoXmlTag("LatstValtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? LatestValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? LatestValuation { get; init; } 
    #else
    public DateAndAmount2? LatestValuation { get; set; } 
    #endif
    
    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("_biWDIOlbEeu9cf4XM82AQQ")]
    [DisplayName("Original Cost")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCost")]
    #endif
    [IsoXmlTag("OrgnlCost")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_Z-ncG-laEeu9cf4XM82AQQ")]
    [DisplayName("Transferee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfeeAcct")]
    #endif
    [IsoXmlTag("TrfeeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account28? TransfereeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account28? TransfereeAccount { get; init; } 
    #else
    public Account28? TransfereeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party and account from which the transferor delivers the financial instrument to the transferee.
    /// </summary>
    [IsoId("_Z-ncHelaEeu9cf4XM82AQQ")]
    [DisplayName("Transferor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trfr")]
    #endif
    [IsoXmlTag("Trfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account28? Transferor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account28? Transferor { get; init; } 
    #else
    public Account28? Transferor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_Z-ncH-laEeu9cf4XM82AQQ")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary43? IntermediaryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary43? IntermediaryInformation { get; init; } 
    #else
    public Intermediary43? IntermediaryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [IsoId("_Z-ncIelaEeu9cf4XM82AQQ")]
    [DisplayName("Crystallisation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrstllstnDtls")]
    #endif
    [IsoXmlTag("CrstllstnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Crystallisation2? CrystallisationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Crystallisation2? CrystallisationDetails { get; init; } 
    #else
    public Crystallisation2? CrystallisationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("_Z-ncI-laEeu9cf4XM82AQQ")]
    [DisplayName("Tax Valuation Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxValtnPt")]
    #endif
    [IsoXmlTag("TaxValtnPt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax36? TaxValuationPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax36? TaxValuationPoint { get; init; } 
    #else
    public Tax36? TaxValuationPoint { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_Z-ncJelaEeu9cf4XM82AQQ")]
    [DisplayName("Settlement Parties Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters17? SettlementPartiesDetails { get; init; } 
    #else
    public FundSettlementParameters17? SettlementPartiesDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the assets are held in an individual’s own name.
    /// </summary>
    [IsoId("_yEvXYOluEeuvhrZwLF0fDg")]
    [DisplayName("Assets Held In Own Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstsHeldInOwnNm")]
    #endif
    [IsoXmlTag("AsstsHeldInOwnNm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AssetsHeldInOwnName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssetsHeldInOwnName { get; init; } 
    #else
    public System.String? AssetsHeldInOwnName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_3AffsOluEeuvhrZwLF0fDg")]
    [DisplayName("Transfer Results In Change Of Beneficial Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRsltsInChngOfBnfclOwnr")]
    #endif
    [IsoXmlTag("TrfRsltsInChngOfBnfclOwnr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransferResultsInChangeOfBeneficialOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferResultsInChangeOfBeneficialOwner { get; init; } 
    #else
    public System.String? TransferResultsInChangeOfBeneficialOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_Z-ncJ-laEeu9cf4XM82AQQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
