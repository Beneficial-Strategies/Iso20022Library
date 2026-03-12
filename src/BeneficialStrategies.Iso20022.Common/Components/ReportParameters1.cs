// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters related to the net position.
/// </summary>
[IsoId("_Qk_hd9p-Ed-ak6NoX_4Aeg_937619716")]
[DisplayName("Report Parameters")]
public partial record ReportParameters1
{
    #nullable enable
    
    /// <summary>
    /// After netting, reference that is common to a net transaction to settle and all its underlying trades.
    /// </summary>
    [IsoId("_Qk_heNp-Ed-ak6NoX_4Aeg_-1693107427")]
    [DisplayName("Net Position Identification")]
    [IsoXmlTag("NetPosId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NetPositionIdentification { get; init; } 
    
    /// <summary>
    /// Date and time of the net position report.
    /// </summary>
    [IsoId("_QlIrYNp-Ed-ak6NoX_4Aeg_1816598291")]
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTimeChoice_ ReportDateAndTime { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QlIrYdp-Ed-ak6NoX_4Aeg_-853608276")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateType1Code UpdateType { get; init; } 
    
    /// <summary>
    /// Frequency of the report.
    /// </summary>
    [IsoId("_QlIrYtp-Ed-ak6NoX_4Aeg_414984299")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; } 
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_QlIrY9p-Ed-ak6NoX_4Aeg_-378663272")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    public IsoExact5NumericText? ReportNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QlIrZNp-Ed-ak6NoX_4Aeg_-704566571")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
