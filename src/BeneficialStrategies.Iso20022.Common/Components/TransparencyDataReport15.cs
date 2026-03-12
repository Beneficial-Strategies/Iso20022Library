// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting quantitative data of non-equity instruments for transparency calculations.
/// </summary>
[IsoId("_hLn-cX5kEeaGiOUFl5b1oQ")]
[DisplayName("Transparency Data Report")]
public partial record TransparencyDataReport15
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_hWyFlX5kEeaGiOUFl5b1oQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_hWyFl35kEeaGiOUFl5b1oQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; } 
    
    /// <summary>
    /// Date to which the quantitative data fields below relate.
    /// </summary>
    [IsoId("_hWyFmX5kEeaGiOUFl5b1oQ")]
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReportingDate { get; init; } 
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_hWyFm35kEeaGiOUFl5b1oQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    
    /// <summary>
    /// Indicates whether the instrument was suspended for trading on that trading venue on the reporting day.
    /// </summary>
    [IsoId("_hWyFnX5kEeaGiOUFl5b1oQ")]
    [DisplayName("Suspension")]
    [IsoXmlTag("Sspnsn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Suspension { get; init; } 
    
    /// <summary>
    /// Total number of transactions executed on the reporting day for the instrument.
    /// </summary>
    [IsoId("_hWyFn35kEeaGiOUFl5b1oQ")]
    [DisplayName("Number Transactions")]
    [IsoXmlTag("NbTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberTransactions { get; init; } 
    
    /// <summary>
    /// Aggregated quantitative data on the non-equity instrument being reported. Details aggregated against the specific range that is defined. Transactions that have been cancelled should be excluded from the reported figure.
    /// </summary>
    [IsoId("_hWyFoX5kEeaGiOUFl5b1oQ")]
    [DisplayName("Aggregated Quantitative Data")]
    [IsoXmlTag("AggtdQttvData")]
    public TransactionsBin2? AggregatedQuantitativeData { get; init; } 
    
    
    #nullable disable
    
}
