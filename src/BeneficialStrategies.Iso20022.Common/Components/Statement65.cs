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
[IsoId("_lZD-8bQVEeemgtANb5gbCw")]
[DisplayName("Statement")]
public partial record Statement65
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    [IsoId("_lq6j8bQVEeemgtANb5gbCw")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_lq6j87QVEeemgtANb5gbCw")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_lq6j9bQVEeemgtANb5gbCw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_lq6j97QVEeemgtANb5gbCw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; } 
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_lq6j_7QVEeemgtANb5gbCw")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_lq6kB7QVEeemgtANb5gbCw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency25Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_lq6kD7QVEeemgtANb5gbCw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_lq6kF7QVEeemgtANb5gbCw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_lq6kH7QVEeemgtANb5gbCw")]
    [DisplayName("Notification Deadline Period")]
    [IsoXmlTag("NtfctnDdlnPrd")]
    public DateOrDateTimePeriod2Choice_? NotificationDeadlinePeriod { get; init; } 
    
    
    #nullable disable
    
}
