// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the parameters of the report.
/// </summary>
[IsoId("_QlScaNp-Ed-ak6NoX_4Aeg_1048103905")]
[DisplayName("Report Parameters")]
public partial record ReportParameters3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_QlcNYNp-Ed-ak6NoX_4Aeg_928215481")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; } 
    
    /// <summary>
    /// Date (and time) and time of the report.
    /// </summary>
    [IsoId("_QlcNYdp-Ed-ak6NoX_4Aeg_-419897874")]
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    
    /// <summary>
    /// Currency used for the calculation of the margin.
    /// </summary>
    [IsoId("_QlcNYtp-Ed-ak6NoX_4Aeg_-336611287")]
    [DisplayName("Report Currency")]
    [IsoXmlTag("RptCcy")]
    public required CurrencyCode ReportCurrency { get; init; } 
    
    /// <summary>
    /// Date of calculation of the margin.
    /// </summary>
    [IsoId("_QlcNY9p-Ed-ak6NoX_4Aeg_-1305521230")]
    [DisplayName("Calculation Date And Time")]
    [IsoXmlTag("ClctnDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CalculationDateAndTime { get; init; } 
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_QlcNZNp-Ed-ak6NoX_4Aeg_594389524")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; } 
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_QlcNZdp-Ed-ak6NoX_4Aeg_-1126454468")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    public IsoExact5NumericText? ReportNumber { get; init; } 
    
    
    #nullable disable
    
}
