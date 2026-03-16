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
[IsoId("_UG6o4W49EeiU9cctagi5ow")]
[DisplayName("Original Group Header")]
public record OriginalGroupHeader15
{
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the group cancellation request.||Usage: The group cancellation request identification can be used for reconciliation or to link tasks related to the cancellation request.
    /// </summary>
    [IsoId("_UUB3w249EeiU9cctagi5ow")]
    [DisplayName("Group Cancellation Identification")]
    [IsoXmlTag("GrpCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GroupCancellationIdentification { get; init; }

    /// <summary>
    /// Uniquely and unambiguously identifies an exception or an investigation workflow.
    /// </summary>
    [IsoId("_UUB3xW49EeiU9cctagi5ow")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case5? Case { get; init; }

    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_UUB3x249EeiU9cctagi5ow")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_UUB3yW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_UUB3y249EeiU9cctagi5ow")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_UUB3zW49EeiU9cctagi5ow")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_UUB3z249EeiU9cctagi5ow")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether the cancellation request applies to a whole group of transactions or to individual transactions within an original group.
    /// </summary>
    [IsoId("_UUB30W49EeiU9cctagi5ow")]
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    public IsoGroupCancellationIndicator? GroupCancellation { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_UUB30249EeiU9cctagi5ow")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public PaymentCancellationReason5? CancellationReasonInformation { get; init; }
}
