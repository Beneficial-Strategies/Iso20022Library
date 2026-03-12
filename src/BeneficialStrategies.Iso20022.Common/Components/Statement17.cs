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
[IsoId("_QqgTltp-Ed-ak6NoX_4Aeg_-1944789078")]
[DisplayName("Statement")]
public partial record Statement17
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_QqgTl9p-Ed-ak6NoX_4Aeg_-1886603972")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; } 
    
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_QqgTmNp-Ed-ak6NoX_4Aeg_710431033")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_QqgTmdp-Ed-ak6NoX_4Aeg_721605297")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; } 
    
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_QqgTmtp-Ed-ak6NoX_4Aeg_-500456867")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QqpdgNp-Ed-ak6NoX_4Aeg_768705907")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency4Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_Qqpdgdp-Ed-ak6NoX_4Aeg_778865648")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType2Choice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_Qqpdgtp-Ed-ak6NoX_4Aeg_790869281")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
