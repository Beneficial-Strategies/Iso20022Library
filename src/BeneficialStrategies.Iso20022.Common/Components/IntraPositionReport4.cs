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
[IsoId("_MMY5keFiEeWIA4E9cYSxxQ")]
[DisplayName("Intra Position Report")]
public partial record IntraPositionReport4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_MVUMFeFiEeWIA4E9cYSxxQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of a report.
    /// </summary>
    [IsoId("_MVUMHeFiEeWIA4E9cYSxxQ")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReportIdentification { get; init; } 
    
    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_MVUMH-FiEeWIA4E9cYSxxQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_MVUMJ-FiEeWIA4E9cYSxxQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
