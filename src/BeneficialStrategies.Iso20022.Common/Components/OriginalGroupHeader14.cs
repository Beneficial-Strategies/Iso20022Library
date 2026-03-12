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
[IsoId("_BCqU1249EeiU9cctagi5ow")]
[DisplayName("Original Group Header")]
public partial record OriginalGroupHeader14
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original group cancellation request.
    /// </summary>
    [IsoId("_BMC6R249EeiU9cctagi5ow")]
    [DisplayName("Original Group Cancellation Identification")]
    [IsoXmlTag("OrgnlGrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalGroupCancellationIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_BMC6SW49EeiU9cctagi5ow")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case5? ResolvedCase { get; init; } 
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_BMC6S249EeiU9cctagi5ow")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_BMC6TW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_BMC6T249EeiU9cctagi5ow")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_BMC6UW49EeiU9cctagi5ow")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_BMC6U249EeiU9cctagi5ow")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    
    /// <summary>
    /// Specifies the status of a group cancellation request.
    /// </summary>
    [IsoId("_BMC6VW49EeiU9cctagi5ow")]
    [DisplayName("Group Cancellation Status")]
    [IsoXmlTag("GrpCxlSts")]
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_BMC6V249EeiU9cctagi5ow")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReason4? CancellationStatusReasonInformation { get; init; } 
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_BMC6WW49EeiU9cctagi5ow")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    
    
    #nullable disable
    
}
