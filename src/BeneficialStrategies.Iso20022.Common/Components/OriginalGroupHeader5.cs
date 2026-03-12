// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the original group, to which the message refers.
/// </summary>
[IsoId("_sevoEFkyEeGeoaLUQk__nA_1903063845")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original group cancellation request.
    /// </summary>
    [IsoId("_sevoEVkyEeGeoaLUQk__nA_1828154802")]
    [DisplayName("Original Group Cancellation Identification")]
    [IsoXmlTag("OrgnlGrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalGroupCancellationIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_sevoElkyEeGeoaLUQk__nA_781447190")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case3? ResolvedCase { get; init; } 
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_se5ZEFkyEeGeoaLUQk__nA_-2073459261")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_sfCjAFkyEeGeoaLUQk__nA_-1546463318")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_sfCjAVkyEeGeoaLUQk__nA_-769709024")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_sfCjAlkyEeGeoaLUQk__nA_-1365213817")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_sfCjA1kyEeGeoaLUQk__nA_1049447839")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    
    /// <summary>
    /// Specifies the status of a group cancellation request.
    /// </summary>
    [IsoId("_sfMUAFkyEeGeoaLUQk__nA_-1376312594")]
    [DisplayName("Group Cancellation Status")]
    [IsoXmlTag("GrpCxlSts")]
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_sfMUAVkyEeGeoaLUQk__nA_746391324")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; } 
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_sfMUAlkyEeGeoaLUQk__nA_-1790738466")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    
    
    #nullable disable
    
}
