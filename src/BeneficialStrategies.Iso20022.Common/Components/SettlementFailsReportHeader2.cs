// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies parameters of the report.
/// </summary>
[IsoId("_h8xRgR2yEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Report Header")]
public partial record SettlementFailsReportHeader2
{
    #nullable enable
    
    /// <summary>
    /// Provides the reporting timestamp, when the report was submitted from the CSD to the Competent Authority.
    /// </summary>
    [IsoId("_h-xcoR2yEeqF2P5v-Rtejg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Period covered by the report.
    /// </summary>
    [IsoId("_h-xcox2yEeqF2P5v-Rtejg")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required DatePeriod2 ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Specifies the currency used to report the aggregated values of the transactions.
    /// Usage: this is the currency in which the values have to be reported, when no explicit currency is provided.
    /// </summary>
    [IsoId("_h-xcpR2yEeqF2P5v-Rtejg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Provides the status of the report.
    /// </summary>
    [IsoId("_h-xcpx2yEeqF2P5v-Rtejg")]
    [DisplayName("Report Status")]
    [IsoXmlTag("RptSts")]
    public required TransactionOperationType4Code ReportStatus { get; init; } 
    
    /// <summary>
    /// Specifies the securities settlement system used in a settlement process.
    /// </summary>
    [IsoId("_h-xcqR2yEeqF2P5v-Rtejg")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    public required SecuritiesSettlementSystemIdentification2 SecuritiesSettlementSystem { get; init; } 
    
    
    #nullable disable
    
}
