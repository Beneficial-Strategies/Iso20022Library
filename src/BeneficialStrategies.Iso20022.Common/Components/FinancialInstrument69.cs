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
[IsoId("_QN2MiUyGEeir2sRRVd9XhA")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument69
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument69 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument69( FinancialInstrument1Choice_ reqInstrument,TransferType1Choice_ reqTransferType )
    {
        Instrument = reqInstrument;
        TransferType = reqTransferType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the line of holding in the portfolio.
    /// </summary>
    [IsoId("__11KQEyHEeir2sRRVd9XhA")]
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
    [IsoId("_WcQ2gEyGEeir2sRRVd9XhA")]
    [DisplayName("Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instrm")]
    #endif
    [IsoXmlTag("Instrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument1Choice_ Instrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument1Choice_ Instrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument1Choice_ Instrument { get; init; } 
    #else
    public FinancialInstrument1Choice_ Instrument { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [IsoId("_QdUL3UyGEeir2sRRVd9XhA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity44Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity44Choice_? Quantity { get; init; } 
    #else
    public Quantity44Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the financial instrument is transferred.
    /// </summary>
    [IsoId("_QdUL20yGEeir2sRRVd9XhA")]
    [DisplayName("Transfer Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTp")]
    #endif
    [IsoXmlTag("TrfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferType1Choice_ TransferType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferType1Choice_ TransferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferType1Choice_ TransferType { get; init; } 
    #else
    public TransferType1Choice_ TransferType { get; set; } 
    #endif
    
    /// <summary>
    /// Security is to be converted into another security before transfer.
    /// </summary>
    [IsoId("_yu1xcE3dEeidB49bWZiS0g")]
    [DisplayName("Conversion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Convs")]
    #endif
    [IsoXmlTag("Convs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Conversion1? Conversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Conversion1? Conversion { get; init; } 
    #else
    public Conversion1? Conversion { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of units.
    /// </summary>
    [IsoId("_INYoIaFYEei_VZq-6SQkuQ")]
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
    [IsoId("_XbQFMlNTEeijdq8ilaxyOA")]
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
    [IsoId("_XbQFM1NTEeijdq8ilaxyOA")]
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
    [IsoId("_uiFPQawmEeiIdO-huO9Nhw")]
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
    [IsoId("_QdUL30yGEeir2sRRVd9XhA")]
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
    [IsoId("_QdUL4UyGEeir2sRRVd9XhA")]
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
    [IsoId("_QdUL40yGEeir2sRRVd9XhA")]
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
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// (Party and account into which the transferee receives the financial instrument from the transferor.)
    /// </summary>
    [IsoId("_QdUL5UyGEeir2sRRVd9XhA")]
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
    [IsoId("_YMfdwanrEeitU9ya4obnlw")]
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
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("_M8XzoejREeifCsigq7uLaQ")]
    [DisplayName("Requested Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTrfDt")]
    #endif
    [IsoXmlTag("ReqdTrfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedTransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedTransferDate { get; init; } 
    #else
    public System.DateOnly? RequestedTransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_kkKDIE3XEeidB49bWZiS0g")]
    [DisplayName("Requested Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTradDt")]
    #endif
    [IsoXmlTag("ReqdTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedTradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedTradeDate { get; init; } 
    #else
    public System.DateOnly? RequestedTradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_mpA20E3XEeidB49bWZiS0g")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_vkQfQE3yEeiQHa-q1Uephw")]
    [DisplayName("Payment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDtls")]
    #endif
    [IsoXmlTag("PmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument14? PaymentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument14? PaymentDetails { get; init; } 
    #else
    public PaymentInstrument14? PaymentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of units that have been received (crystallised) or not yet received (uncrystallised) from the fund. This is typically relevant to a pension fund.
    /// </summary>
    [IsoId("_xMgqwE3XEeidB49bWZiS0g")]
    [DisplayName("Crystallisation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrstllstnDtls")]
    #endif
    [IsoXmlTag("CrstllstnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Crystallisation1? CrystallisationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Crystallisation1? CrystallisationDetails { get; init; } 
    #else
    public Crystallisation1? CrystallisationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Date or tax quarter used for the calculation of tax on the asset.
    /// </summary>
    [IsoId("_NC_0kHVYEeiiHo4Gse0d2w")]
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
    [IsoId("_QdUL6UyGEeir2sRRVd9XhA")]
    [DisplayName("Settlement Parties Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundSettlementParameters14? SettlementPartiesDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundSettlementParameters14? SettlementPartiesDetails { get; init; } 
    #else
    public FundSettlementParameters14? SettlementPartiesDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the financial instrument.
    /// </summary>
    [IsoId("_Q-2UMHVaEeiiHo4Gse0d2w")]
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
