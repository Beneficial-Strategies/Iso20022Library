// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[IsoId("_er8zM83yEee5nJBZsW8MFQ")]
[DisplayName("Statement")]
public partial record Statement67
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_er8zN83yEee5nJBZsW8MFQ")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; } 
    
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_er8zP83yEee5nJBZsW8MFQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? QueryReference { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_er8zR83yEee5nJBZsW8MFQ")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? StatementIdentification { get; init; } 
    
    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_er8zSc3yEee5nJBZsW8MFQ")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required Period5Choice_ StatementPeriod { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_er8zUc3yEee5nJBZsW8MFQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency26Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_er8zWc3yEee5nJBZsW8MFQ")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType16Choice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_er8zYc3yEee5nJBZsW8MFQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
