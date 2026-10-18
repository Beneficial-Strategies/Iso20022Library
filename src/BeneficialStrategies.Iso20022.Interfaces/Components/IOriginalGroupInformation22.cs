// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original group, to which the message refers.
/// </summary>
[IsoId("_Pkwzl9p-Ed-ak6NoX_4Aeg_-554618475")]
public interface IOriginalGroupInformation22 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_Pk6kgNp-Ed-ak6NoX_4Aeg_-554618473")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    Max35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_Pk6kgdp-Ed-ak6NoX_4Aeg_-554618413")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    Max35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_Pk6kgtp-Ed-ak6NoX_4Aeg_-554618383")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    ISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Set of elements used to provide detailed information on the reversal reason.
    /// </summary>
    [IsoId("_Pk6kg9p-Ed-ak6NoX_4Aeg_-554618090")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IReversalReasonInformation6> ReversalReasonInformation { get; }
}
