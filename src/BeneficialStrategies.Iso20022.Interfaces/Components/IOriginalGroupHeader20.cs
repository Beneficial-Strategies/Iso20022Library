// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original group, to which the message refers.
/// </summary>
[IsoId("_yCJJATEyEe6g-ffJsqGiSA")]
public interface IOriginalGroupHeader20 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    Max35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    Max35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    ISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IPaymentReversalReason10> ReversalReasonInformation { get; }
}
