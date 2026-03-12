// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for reporting qualitative details of equity instruments as part of Transparency calculations.
/// </summary>
[IsoId("_pVzQ4Wk3EeaLAKoEUNsD9g")]
[DisplayName("Transparency Data Report")]
public partial record TransparencyDataReport11
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_pfKBNWk3EeaLAKoEUNsD9g")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_pfKoQGk3EeaLAKoEUNsD9g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; } 
    
    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_pfKoQmk3EeaLAKoEUNsD9g")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; } 
    
    /// <summary>
    /// Segment MIC for the trading venue where applicable, otherwise the operational MIC.
    /// </summary>
    [IsoId("_pfKoRGk3EeaLAKoEUNsD9g")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    
    /// <summary>
    /// Date for which the data is provided.
    /// </summary>
    [IsoId("_pfKoRmk3EeaLAKoEUNsD9g")]
    [DisplayName("Reporting Date")]
    [IsoXmlTag("RptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReportingDate { get; init; } 
    
    /// <summary>
    /// Specifies the classification of the equity instrument.
    /// </summary>
    [IsoId("_pfKoSGk3EeaLAKoEUNsD9g")]
    [DisplayName("Financial Instrument Classification")]
    [IsoXmlTag("FinInstrmClssfctn")]
    public required EquityInstrumentReportingClassification1Code FinancialInstrumentClassification { get; init; } 
    
    /// <summary>
    /// For shares and depositary receipts, the total number of outstanding instruments. 
    /// For ETFs, the number of units issued for trading.
    /// </summary>
    [IsoId("_pfKoUGk3EeaLAKoEUNsD9g")]
    [DisplayName("Number Outstanding Instruments")]
    [IsoXmlTag("NbOutsdngInstrms")]
    [IsoSimpleType(IsoSimpleType.DecimalNumberFraction5)]
    public IsoDecimalNumberFraction5? NumberOutstandingInstruments { get; init; } 
    
    /// <summary>
    /// The total number of shares corresponding to holdings exceeding 5% of total voting rights of the issuer unless such a holding is held by a collective investment undertaking or a pension fund. This field is to be populated only when actual information is known.
    /// </summary>
    [IsoId("_pfKoUmk3EeaLAKoEUNsD9g")]
    [DisplayName("Holdings Exceeding Total Voting Right Threshold")]
    [IsoXmlTag("HldgsExcdgTtlVtngRghtThrshld")]
    [IsoSimpleType(IsoSimpleType.DecimalNumberFraction5)]
    public IsoDecimalNumberFraction5? HoldingsExceedingTotalVotingRightThreshold { get; init; } 
    
    /// <summary>
    /// Issuance size of the certificate expressed in Euros.
    /// </summary>
    [IsoId("_pfKoVGk3EeaLAKoEUNsD9g")]
    [DisplayName("Issuance Size")]
    [IsoXmlTag("IssncSz")]
    public ActiveCurrencyAndAmount? IssuanceSize { get; init; } 
    
    /// <summary>
    /// Before the first admission to trading of the instrument, the price of the instrument as it will stand at the start of the first day of trading.
    /// After the first admission to trading of the instrument, the price of the instrument at the last trading day of the previous year, or at the end of the day on which a corporate action is effective. The price should be expressed in Euros. To be reported for shares and depositary receipts.
    /// </summary>
    [IsoId("_pfKoVmk3EeaLAKoEUNsD9g")]
    [DisplayName("Instrument Price")]
    [IsoXmlTag("InstrmPric")]
    public ActiveCurrencyAnd13DecimalAmount? InstrumentPrice { get; init; } 
    
    
    #nullable disable
    
}
