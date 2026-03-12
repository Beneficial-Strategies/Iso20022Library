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
[IsoId("_QlcNadp-Ed-ak6NoX_4Aeg_1490476160")]
[DisplayName("Report Parameters")]
public partial record ReportParameters2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_QllXUNp-Ed-ak6NoX_4Aeg_804785280")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; } 
    
    /// <summary>
    /// Date (and time) at which the report was created.
    /// </summary>
    [IsoId("_QllXUdp-Ed-ak6NoX_4Aeg_-2008884820")]
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_QllXUtp-Ed-ak6NoX_4Aeg_-596061208")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; } 
    
    /// <summary>
    /// Indicates the currency used for the calculation of the guarantee fund.
    /// </summary>
    [IsoId("_QllXU9p-Ed-ak6NoX_4Aeg_1225256953")]
    [DisplayName("Report Currency")]
    [IsoXmlTag("RptCcy")]
    public required CurrencyCode ReportCurrency { get; init; } 
    
    /// <summary>
    /// Indicates the date of calculation of the deficit (if any).
    /// </summary>
    [IsoId("_QllXVNp-Ed-ak6NoX_4Aeg_-1284077407")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
