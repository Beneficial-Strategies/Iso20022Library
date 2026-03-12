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
[IsoId("_oN8KIV10Eea7JNQ75Q3JCw")]
[DisplayName("Statement")]
public partial record Statement59
{
    #nullable enable
    
    /// <summary>
    /// Specifies the business role of the message sender and, therefore, the business relationship between the sender and the receiver (or the interests represented by them, in those cases where another entity is acting on behalf of the sender or receiver). The message is exchanged between two entities, one being the account servicer and the other the account owner, and the message can be used with either one as the sender.
    /// </summary>
    [IsoId("_uRgPEF10Eea7JNQ75Q3JCw")]
    [DisplayName("Sender Business Role")]
    [IsoXmlTag("SndrBizRole")]
    public required SenderBusinessRole1Code SenderBusinessRole { get; init; } 
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_ooILw110Eea7JNQ75Q3JCw")]
    [DisplayName("Statement Number")]
    [IsoXmlTag("StmtNb")]
    public Number3Choice_? StatementNumber { get; init; } 
    
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_ooILx110Eea7JNQ75Q3JCw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; } 
    
    /// <summary>
    /// Reference common to all pages of the statement.
    /// </summary>
    [IsoId("_ooILy110Eea7JNQ75Q3JCw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; } 
    
    /// <summary>
    /// Date and time when the statement was created.
    /// </summary>
    [IsoId("_ooILzV10Eea7JNQ75Q3JCw")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    
    /// <summary>
    /// Date period for which the statement was created.
    /// </summary>
    [IsoId("_ooIL0V10Eea7JNQ75Q3JCw")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required DatePeriod1Choice_ StatementPeriod { get; init; } 
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_ooIL0110Eea7JNQ75Q3JCw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency22Choice_? Frequency { get; init; } 
    
    /// <summary>
    /// Granularity of the frequency used for the reporting.
    /// </summary>
    [IsoId("_ooIL1110Eea7JNQ75Q3JCw")]
    [DisplayName("Frequency Granularity")]
    [IsoXmlTag("FrqcyGrnlrty")]
    public FrequencyGranularityType1Code? FrequencyGranularity { get; init; } 
    
    /// <summary>
    /// Specifies whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_ooIL2V10Eea7JNQ75Q3JCw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType4Choice_? UpdateType { get; init; } 
    
    /// <summary>
    /// Indicates whether there is activity or updated information reported in the statement.
    /// </summary>
    [IsoId("_ooIL3V10Eea7JNQ75Q3JCw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    
    #nullable disable
    
}
