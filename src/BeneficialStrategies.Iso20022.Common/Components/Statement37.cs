// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_JbLJ45rhEeOu4p9bQU8tNA")]
[DisplayName("Statement")]
public partial record Statement37
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_JbLw0JrhEeOu4p9bQU8tNA")]
    [DisplayName("Statement Number")]
    [IsoXmlTag("StmtNb")]
    public Number3Choice_? StatementNumber { get; init; } 
    
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_JbMX4JrhEeOu4p9bQU8tNA")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of the statement.
    /// </summary>
    [IsoId("_JbLJ5JrhEeOu4p9bQU8tNA")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Date and time when the statement was created.
    /// </summary>
    [IsoId("_JbLJ6prhEeOu4p9bQU8tNA")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Date period for which the statement was created.
    /// </summary>
    [IsoId("_NKm64J79EeOieb-y7x0pFg")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required DatePeriod1Choice_ StatementPeriod { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_JbLw2JrhEeOu4p9bQU8tNA")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency22Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Granularity of the frequency used for the reporting.
    /// </summary>
    [IsoId("_LwypIDy6EeS4E7Ac8_OV3g")]
    [DisplayName("Frequency Granularity")]
    [IsoXmlTag("FrqcyGrnlrty")]
    public FrequencyGranularityType1Code? FrequencyGranularity { get; init; } 
    
    /// <summary>
    /// Specifies whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_JbLw3JrhEeOu4p9bQU8tNA")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType4Choice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or updated information reported in the statement.
    /// </summary>
    [IsoId("_JbLJ5prhEeOu4p9bQU8tNA")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
