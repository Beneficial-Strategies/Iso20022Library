// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original group, to which the message refers.
/// </summary>
[IsoId("_w2KpY0gtEeaGKYpLDboHPQ")]
[DisplayName("Original Group Header")]
public record OriginalGroupHeader6
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the group cancellation request.||Usage: The group cancellation request identification can be used for reconciliation or to link tasks related to the cancellation request.
    /// </summary>
    [IsoId("_w_UlU0gtEeaGKYpLDboHPQ")]
    [DisplayName("Group Cancellation Identification")]
    [IsoXmlTag("GrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GroupCancellationIdentification { get; init; }

    /// <summary>
    /// Uniquely and unambiguously identifies an exception or an investigation workflow.
    /// </summary>
    [IsoId("_w_UlVUgtEeaGKYpLDboHPQ")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case3? Case { get; init; }

    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_w_UlV0gtEeaGKYpLDboHPQ")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_w_UlWUgtEeaGKYpLDboHPQ")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_w_UlW0gtEeaGKYpLDboHPQ")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_w_UlXUgtEeaGKYpLDboHPQ")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_w_UlX0gtEeaGKYpLDboHPQ")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether the cancellation request applies to a whole group of transactions or to individual transactions within an original group.
    /// </summary>
    [IsoId("_w_UlYUgtEeaGKYpLDboHPQ")]
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    public IsoGroupCancellationIndicator? GroupCancellation { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_w_UlY0gtEeaGKYpLDboHPQ")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<PaymentCancellationReason3> CancellationReasonInformation { get; init; } = [];
}
