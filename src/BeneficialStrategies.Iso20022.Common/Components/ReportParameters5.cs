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
[IsoId("_XiWZ8YbFEeWguotXa4lFgg")]
[DisplayName("Report Parameters")]
public partial record ReportParameters5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the report.
    /// </summary>
    [IsoId("_X4g3MYbFEeWguotXa4lFgg")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReportIdentification { get; init; } 
    
    /// <summary>
    /// Date (and time) at which the report was created.
    /// </summary>
    [IsoId("_X4g3M4bFEeWguotXa4lFgg")]
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_X4g3NYbFEeWguotXa4lFgg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; } 
    
    /// <summary>
    /// Indicates the currency used for the calculation of the guarantee fund.
    /// </summary>
    [IsoId("_X4g3N4bFEeWguotXa4lFgg")]
    [DisplayName("Report Currency")]
    [IsoXmlTag("RptCcy")]
    public required ActiveCurrencyCode ReportCurrency { get; init; } 
    
    /// <summary>
    /// Indicates the date of calculation of the deficit (if any).
    /// </summary>
    [IsoId("_X4g3OYbFEeWguotXa4lFgg")]
    [DisplayName("Calculation Date")]
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CalculationDate { get; init; } 
    
    
    #nullable disable
    
}
