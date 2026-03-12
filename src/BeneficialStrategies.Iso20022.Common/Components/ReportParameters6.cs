// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of the report.
/// </summary>
[IsoId("_MSIRAAynEeukOZYTbzKKxw")]
[DisplayName("Report Parameters")]
public partial record ReportParameters6
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_MSIRBAynEeukOZYTbzKKxw")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; } 
    
    /// <summary>
    /// Date (and time) at which the report was created.
    /// </summary>
    [IsoId("_MSIRAwynEeukOZYTbzKKxw")]
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTime2Choice_ ReportDateAndTime { get; init; } 
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_MSIRBQynEeukOZYTbzKKxw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; } 
    
    /// <summary>
    /// Currency used for the calculation of the guarantee fund.
    /// </summary>
    [IsoId("_MSIRAQynEeukOZYTbzKKxw")]
    [DisplayName("Report Currency")]
    [IsoXmlTag("RptCcy")]
    public required ActiveCurrencyCode ReportCurrency { get; init; } 
    
    /// <summary>
    /// Date of calculation of the deficit (if any).
    /// </summary>
    [IsoId("_MSIRAgynEeukOZYTbzKKxw")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
