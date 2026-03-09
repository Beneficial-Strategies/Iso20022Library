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
/// Provides for reporting qualitative details of equity instruments as part of Transparency calculations.
/// </summary>
[IsoId("_pVzQ4Wk3EeaLAKoEUNsD9g")]
[DisplayName("Transparency Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransparencyDataReport11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransparencyDataReport11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransparencyDataReport11( System.String reqIdentification,EquityInstrumentReportingClassification1Code reqFinancialInstrumentClassification )
    {
        Identification = reqIdentification;
        FinancialInstrumentClassification = reqFinancialInstrumentClassification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_pfKBNWk3EeaLAKoEUNsD9g")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_pfKoQGk3EeaLAKoEUNsD9g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_pfKoQmk3EeaLAKoEUNsD9g")]
    [DisplayName("Full Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullNm")]
    #endif
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FullName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FullName { get; init; } 
    #else
    public System.String? FullName { get; set; } 
    #endif
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_pfKoRGk3EeaLAKoEUNsD9g")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingVenue { get; init; } 
    #else
    public System.String? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Date for which the data is provided.
    /// </summary>
    [IsoId("_pfKoRmk3EeaLAKoEUNsD9g")]
    [DisplayName("Reporting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgDt")]
    #endif
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ReportingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ReportingDate { get; init; } 
    #else
    public System.DateOnly? ReportingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification of the equity instrument.
    /// </summary>
    [IsoId("_pfKoSGk3EeaLAKoEUNsD9g")]
    [DisplayName("Financial Instrument Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmClssfctn")]
    #endif
    [IsoXmlTag("FinInstrmClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    #else
    public EquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; set; } 
    #endif
    
    /// <summary>
    /// For shares and depositary receipts, the total number of outstanding instruments. 
    /// For ETFs, the number of units issued for trading.
    /// </summary>
    [IsoId("_pfKoUGk3EeaLAKoEUNsD9g")]
    [DisplayName("Number Outstanding Instruments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOutsdngInstrms")]
    #endif
    [IsoXmlTag("NbOutsdngInstrms")]
    [IsoSimpleType(IsoSimpleType.DecimalNumberFraction5)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumberFraction5? NumberOutstandingInstruments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOutstandingInstruments { get; init; } 
    #else
    public System.UInt64? NumberOutstandingInstruments { get; set; } 
    #endif
    
    /// <summary>
    /// The total number of shares corresponding to holdings exceeding 5% of total voting rights of the issuer unless such a holding is held by a collective investment undertaking or a pension fund. This field is to be populated only when actual information is known.
    /// </summary>
    [IsoId("_pfKoUmk3EeaLAKoEUNsD9g")]
    [DisplayName("Holdings Exceeding Total Voting Right Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsExcdgTtlVtngRghtThrshld")]
    #endif
    [IsoXmlTag("HldgsExcdgTtlVtngRghtThrshld")]
    [IsoSimpleType(IsoSimpleType.DecimalNumberFraction5)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumberFraction5? HoldingsExceedingTotalVotingRightThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? HoldingsExceedingTotalVotingRightThreshold { get; init; } 
    #else
    public System.UInt64? HoldingsExceedingTotalVotingRightThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// Issuance size of the certificate expressed in Euros.
    /// </summary>
    [IsoId("_pfKoVGk3EeaLAKoEUNsD9g")]
    [DisplayName("Issuance Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncSz")]
    #endif
    [IsoXmlTag("IssncSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? IssuanceSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? IssuanceSize { get; init; } 
    #else
    public ActiveCurrencyAndAmount? IssuanceSize { get; set; } 
    #endif
    
    /// <summary>
    /// Before the first admission to trading of the instrument, the price of the instrument as it will stand at the start of the first day of trading.
    /// After the first admission to trading of the instrument, the price of the instrument at the last trading day of the previous year, or at the end of the day on which a corporate action is effective. The price should be expressed in Euros. To be reported for shares and depositary receipts.
    /// </summary>
    [IsoId("_pfKoVmk3EeaLAKoEUNsD9g")]
    [DisplayName("Instrument Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmPric")]
    #endif
    [IsoXmlTag("InstrmPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? InstrumentPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? InstrumentPrice { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? InstrumentPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
