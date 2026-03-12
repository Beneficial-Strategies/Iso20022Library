// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information.
/// </summary>
[IsoId("_D3ShFffQEeiNZp_PtLohLw")]
[DisplayName("Statement")]
public partial record Statement75
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement is a balance only notification or if it includes missing instructions only or all instructions.
    /// </summary>
    [IsoId("_D3ShF_fQEeiNZp_PtLohLw")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public required CorporateActionStatementType2Code StatementType { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_D3ShGffQEeiNZp_PtLohLw")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_D3ShG_fQEeiNZp_PtLohLw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the period of instruction details within the statement.
    /// </summary>
    [IsoId("_D3ShHffQEeiNZp_PtLohLw")]
    [DisplayName("Instruction Aggregation Period")]
    [IsoXmlTag("InstrAggtnPrd")]
    public DatePeriod2? InstructionAggregationPeriod { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_D3ShH_fQEeiNZp_PtLohLw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; } 
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_D3ShJ_fQEeiNZp_PtLohLw")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_D3ShL_fQEeiNZp_PtLohLw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency26Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_D3ShN_fQEeiNZp_PtLohLw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType16Choice_ UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_D3ShP_fQEeiNZp_PtLohLw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_D3TIEffQEeiNZp_PtLohLw")]
    [DisplayName("Notification Deadline Period")]
    [IsoXmlTag("NtfctnDdlnPrd")]
    public DateOrDateTimePeriod1Choice_? NotificationDeadlinePeriod { get; init; } 
    
    
    #nullable disable
    
}
