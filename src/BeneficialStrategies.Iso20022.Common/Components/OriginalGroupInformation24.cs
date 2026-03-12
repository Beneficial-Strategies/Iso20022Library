// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original group, to which the message refers.
/// </summary>
[IsoId("_Pl9GVdp-Ed-ak6NoX_4Aeg_-203686213")]
[DisplayName("Original Group Information")]
public partial record OriginalGroupInformation24
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original group cancellation request.
    /// </summary>
    [IsoId("_Pl9GVtp-Ed-ak6NoX_4Aeg_-203685965")]
    [DisplayName("Original Group Cancellation Identification")]
    [IsoXmlTag("OrgnlGrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalGroupCancellationIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_Pl9GV9p-Ed-ak6NoX_4Aeg_-202765693")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case2? ResolvedCase { get; init; } 
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_Pl9GWNp-Ed-ak6NoX_4Aeg_-203685935")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_PmG3UNp-Ed-ak6NoX_4Aeg_-203685874")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_PmG3Udp-Ed-ak6NoX_4Aeg_-203685843")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_PmG3Utp-Ed-ak6NoX_4Aeg_-202765787")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_PmG3U9p-Ed-ak6NoX_4Aeg_-202765849")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    
    /// <summary>
    /// Specifies the status of a group cancellation request.
    /// </summary>
    [IsoId("_PmG3VNp-Ed-ak6NoX_4Aeg_1309963033")]
    [DisplayName("Group Cancellation Status")]
    [IsoXmlTag("GrpCxlSts")]
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_PmG3Vdp-Ed-ak6NoX_4Aeg_1237003680")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReasonInformation1? CancellationStatusReasonInformation { get; init; } 
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_PmG3Vtp-Ed-ak6NoX_4Aeg_1237003989")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    
    
    #nullable disable
    
}
