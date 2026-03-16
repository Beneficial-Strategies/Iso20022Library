// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Group Header21.
/// </summary>
[IsoId("_zPOAITEyEe6g-ffJsqGiSA")]
[DisplayName("Original Group Header21")]
public record OriginalGroupHeader21
{
    /// <summary>
    /// Cancellation Reason Information.
    /// </summary>
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<PaymentCancellationReason6> CancellationReasonInformation { get; init; } = [];

    /// <summary>
    /// Case.
    /// </summary>
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case6? Case { get; init; }

    /// <summary>
    /// Control Sum.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Group Cancellation.
    /// </summary>
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    public IsoGroupCancellationIndicator? GroupCancellation { get; init; }

    /// <summary>
    /// Group Cancellation Identification.
    /// </summary>
    [DisplayName("Group Cancellation Identification")]
    [IsoXmlTag("GrpCxlId")]
    public IsoMax35Text? GroupCancellationIdentification { get; init; }

    /// <summary>
    /// Number Of Transactions.
    /// </summary>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Original Creation Date Time.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Original Message Name Identification.
    /// </summary>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }
}
