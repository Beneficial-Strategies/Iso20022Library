// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the report.
/// </summary>
[IsoId("_MFstETngEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Report")]
public partial record IntraBalanceReport5
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_MQuRUzngEem7JZMuWtwtsg")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; } 
    
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_MQuRWzngEem7JZMuWtwtsg")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_MQuRYzngEem7JZMuWtwtsg")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReportIdentification { get; init; } 
    
    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    [IsoId("_MQuRZTngEem7JZMuWtwtsg")]
    [DisplayName("Report Date Time")]
    [IsoXmlTag("RptDtTm")]
    public DateAndDateTime2Choice_? ReportDateTime { get; init; } 
    
    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_MQuRbTngEem7JZMuWtwtsg")]
    [DisplayName("Report Period")]
    [IsoXmlTag("RptPrd")]
    public Period7Choice_? ReportPeriod { get; init; } 
    
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_MQuRdTngEem7JZMuWtwtsg")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public MovementResponseType1Code? QueryType { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_MQuRfTngEem7JZMuWtwtsg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency22Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_MQuRhTngEem7JZMuWtwtsg")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_MQuRjTngEem7JZMuWtwtsg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
