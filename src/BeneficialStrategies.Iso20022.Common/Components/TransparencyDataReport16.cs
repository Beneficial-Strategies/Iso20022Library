// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting details of non-equity instruments as part of transparency calculations.
/// </summary>
[IsoId("_wtcMcSe0Eei12pGEsJIAeQ")]
[DisplayName("Transparency Data Report")]
public partial record TransparencyDataReport16
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_w9jsEye0Eei12pGEsJIAeQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_w9jsFSe0Eei12pGEsJIAeQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; } 
    
    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_w9jsFye0Eei12pGEsJIAeQ")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; } 
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_w9jsGSe0Eei12pGEsJIAeQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    
    /// <summary>
    /// Date this information is reported in relation to.
    /// </summary>
    [IsoId("_w9jsGye0Eei12pGEsJIAeQ")]
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReportingDate { get; init; } 
    
    /// <summary>
    /// Maturity date of the financial instrument. Field applicable for the asset classes of bonds, interest rate derivatives, equity derivatives, commodity derivatives, foreign exchange derivatives, credit derivatives, C10 derivatives and derivatives on emission allowances.
    /// </summary>
    [IsoId("_w9jsHSe0Eei12pGEsJIAeQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; } 
    
    /// <summary>
    /// Identification of non-equity financial instruments.
    /// </summary>
    [IsoId("_w9jsHye0Eei12pGEsJIAeQ")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public required NonEquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    
    /// <summary>
    /// Details on the type of asset class a non-equity financial instrument can be classified as.
    /// </summary>
    [IsoId("_w9jsJye0Eei12pGEsJIAeQ")]
    [DisplayName("Underlying Instrument Asset Class")]
    [IsoXmlTag("UndrlygInstrmAsstClss")]
    public ProductType5Code? UnderlyingInstrumentAssetClass { get; init; } 
    
    /// <summary>
    /// Details on the contract type a derivative non-equity financial instrument can be classified as.
    /// </summary>
    [IsoId("_w9jsKSe0Eei12pGEsJIAeQ")]
    [DisplayName("Derivative Contract Type")]
    [IsoXmlTag("DerivCtrctTp")]
    public FinancialInstrumentContractType1Code? DerivativeContractType { get; init; } 
    
    /// <summary>
    /// Details specific to a bond / debt instrument.
    /// </summary>
    [IsoId("_w9jsKye0Eei12pGEsJIAeQ")]
    [DisplayName("Bond")]
    [IsoXmlTag("Bd")]
    public DebtInstrument5? Bond { get; init; } 
    
    /// <summary>
    /// Details the reporting of the emission allowance sub type.
    /// </summary>
    [IsoId("_w9jsLSe0Eei12pGEsJIAeQ")]
    [DisplayName("Emission Allowance Type")]
    [IsoXmlTag("EmssnAllwncTp")]
    public EmissionAllowanceProductType2Code? EmissionAllowanceType { get; init; } 
    
    /// <summary>
    /// Derivative specific details.
    /// </summary>
    [IsoId("_w9jsLye0Eei12pGEsJIAeQ")]
    [DisplayName("Derivative")]
    [IsoXmlTag("Deriv")]
    public Derivative3Choice_? Derivative { get; init; } 
    
    
    #nullable disable
    
}
