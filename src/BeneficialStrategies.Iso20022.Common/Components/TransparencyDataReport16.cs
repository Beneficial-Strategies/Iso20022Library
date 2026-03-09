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
/// Provides for reporting details of non-equity instruments as part of transparency calculations.
/// </summary>
[IsoId("_wtcMcSe0Eei12pGEsJIAeQ")]
[DisplayName("Transparency Data Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransparencyDataReport16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransparencyDataReport16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransparencyDataReport16( System.String reqIdentification,NonEquityInstrumentReportingClassification1Code reqFinancialInstrumentClassification )
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
    [IsoId("_w9jsEye0Eei12pGEsJIAeQ")]
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
    [IsoId("_w9jsFSe0Eei12pGEsJIAeQ")]
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
    [IsoId("_w9jsFye0Eei12pGEsJIAeQ")]
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
    [IsoId("_w9jsGSe0Eei12pGEsJIAeQ")]
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
    /// Date this information is reported in relation to.
    /// </summary>
    [IsoId("_w9jsGye0Eei12pGEsJIAeQ")]
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
    /// Maturity date of the financial instrument. Field applicable for the asset classes of bonds, interest rate derivatives, equity derivatives, commodity derivatives, foreign exchange derivatives, credit derivatives, C10 derivatives and derivatives on emission allowances.
    /// </summary>
    [IsoId("_w9jsHSe0Eei12pGEsJIAeQ")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [IsoId("_w9jsHye0Eei12pGEsJIAeQ")]
    [DisplayName("Financial Instrument Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmClssfctn")]
    #endif
    [IsoXmlTag("FinInstrmClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonEquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonEquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    #else
    public NonEquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the type of asset class a non-equity financial instrument can be classified as.
    /// </summary>
    [IsoId("_w9jsJye0Eei12pGEsJIAeQ")]
    [DisplayName("Underlying Instrument Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrmAsstClss")]
    #endif
    [IsoXmlTag("UndrlygInstrmAsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductType5Code? UnderlyingInstrumentAssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType5Code? UnderlyingInstrumentAssetClass { get; init; } 
    #else
    public ProductType5Code? UnderlyingInstrumentAssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the contract type a derivative non-equity financial instrument can be classified as.
    /// </summary>
    [IsoId("_w9jsKSe0Eei12pGEsJIAeQ")]
    [DisplayName("Derivative Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivCtrctTp")]
    #endif
    [IsoXmlTag("DerivCtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentContractType1Code? DerivativeContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentContractType1Code? DerivativeContractType { get; init; } 
    #else
    public FinancialInstrumentContractType1Code? DerivativeContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Details specific to a bond / debt instrument.
    /// </summary>
    [IsoId("_w9jsKye0Eei12pGEsJIAeQ")]
    [DisplayName("Bond")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bd")]
    #endif
    [IsoXmlTag("Bd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DebtInstrument5? Bond { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtInstrument5? Bond { get; init; } 
    #else
    public DebtInstrument5? Bond { get; set; } 
    #endif
    
    /// <summary>
    /// Details the reporting of the emission allowance sub type.
    /// </summary>
    [IsoId("_w9jsLSe0Eei12pGEsJIAeQ")]
    [DisplayName("Emission Allowance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmssnAllwncTp")]
    #endif
    [IsoXmlTag("EmssnAllwncTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EmissionAllowanceProductType2Code? EmissionAllowanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EmissionAllowanceProductType2Code? EmissionAllowanceType { get; init; } 
    #else
    public EmissionAllowanceProductType2Code? EmissionAllowanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Derivative specific details.
    /// </summary>
    [IsoId("_w9jsLye0Eei12pGEsJIAeQ")]
    [DisplayName("Derivative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Deriv")]
    #endif
    [IsoXmlTag("Deriv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Derivative3Choice_? Derivative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Derivative3Choice_? Derivative { get; init; } 
    #else
    public Derivative3Choice_? Derivative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
