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
[IsoId("_iKq4IbtEEeilsanBGAzy4A")]
[DisplayName("Statement")]
public partial record Statement72
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement is a balance only notification or if it includes missing instructions only or all instructions.
    /// </summary>
    [IsoId("_ie6CwbtEEeilsanBGAzy4A")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public required CorporateActionStatementType2Code StatementType { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_ie6Cw7tEEeilsanBGAzy4A")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_ie6CxbtEEeilsanBGAzy4A")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the period of instruction details within the statement.
    /// </summary>
    [IsoId("_nnDL0LtFEeilsanBGAzy4A")]
    [DisplayName("Instruction Aggregation Period")]
    [IsoXmlTag("InstrAggtnPrd")]
    public DatePeriod2? InstructionAggregationPeriod { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_ie6Cx7tEEeilsanBGAzy4A")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; } 
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_ie6Cz7tEEeilsanBGAzy4A")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_ifDzwbtEEeilsanBGAzy4A")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency25Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_ifDzybtEEeilsanBGAzy4A")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_ifDz0btEEeilsanBGAzy4A")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_ifDz2btEEeilsanBGAzy4A")]
    [DisplayName("Notification Deadline Period")]
    [IsoXmlTag("NtfctnDdlnPrd")]
    public DateOrDateTimePeriod1Choice_? NotificationDeadlinePeriod { get; init; } 
    
    
    #nullable disable
    
}
