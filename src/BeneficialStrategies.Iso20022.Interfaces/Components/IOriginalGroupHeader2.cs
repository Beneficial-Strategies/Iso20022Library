// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the original group, to which the message refers.
/// </summary>
[IsoId("_sm76wFkyEeGeoaLUQk__nA_-556027435")]
public interface IOriginalGroupHeader2 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_sm76wVkyEeGeoaLUQk__nA_1822588893")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    Max35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_sm76wlkyEeGeoaLUQk__nA_680297331")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    Max35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_snYmsFkyEeGeoaLUQk__nA_-1783746796")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    ISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_snYmsVkyEeGeoaLUQk__nA_322967981")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    IEnumerable<IPaymentReturnReason1> ReturnReasonInformation { get; }
}
