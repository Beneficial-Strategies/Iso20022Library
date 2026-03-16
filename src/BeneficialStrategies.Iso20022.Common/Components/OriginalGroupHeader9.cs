// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the original group, to which the message refers.
/// </summary>
[IsoId("_tA5uAYlrEeePr-EGJjGYzQ")]
[DisplayName("Original Group Header")]
public record OriginalGroupHeader9
{
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original group cancellation request.
    /// </summary>
    [IsoId("_tPs_B4lrEeePr-EGJjGYzQ")]
    [DisplayName("Original Group Cancellation Identification")]
    [IsoXmlTag("OrgnlGrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalGroupCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_tPs_CYlrEeePr-EGJjGYzQ")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case4? ResolvedCase { get; init; }

    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_tPs_C4lrEeePr-EGJjGYzQ")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_tPs_DYlrEeePr-EGJjGYzQ")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_tPs_D4lrEeePr-EGJjGYzQ")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_tPs_EYlrEeePr-EGJjGYzQ")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_tPs_E4lrEeePr-EGJjGYzQ")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }

    /// <summary>
    /// Specifies the status of a group cancellation request.
    /// </summary>
    [IsoId("_tPs_FYlrEeePr-EGJjGYzQ")]
    [DisplayName("Group Cancellation Status")]
    [IsoXmlTag("GrpCxlSts")]
    public GroupCancellationStatus1Code? GroupCancellationStatus { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_tPs_F4lrEeePr-EGJjGYzQ")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public CancellationStatusReason3? CancellationStatusReasonInformation { get; init; }

    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_tPs_GYlrEeePr-EGJjGYzQ")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    public NumberOfTransactionsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; }
}
