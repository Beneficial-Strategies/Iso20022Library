// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the transaction.
/// </summary>
[IsoId("_U-brUahOEeuOaMA1YOy5YQ")]
[DisplayName("Processing Result")]
public record ProcessingResult9
{
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    [IsoId("_DNFwUCFSEey8XKHwKquEQw")]
    [DisplayName("Response Source")]
    [IsoXmlTag("RspnSrc")]
    public ApprovalEntity2? ResponseSource { get; init; }

    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_VDfxg6hOEeuOaMA1YOy5YQ")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public required ResultData7 ResultData { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_s-YdACFSEey8XKHwKquEQw")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Exact6AlphaNumericText)]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_LsLcgCFSEey8XKHwKquEQw")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ErrorDetails2? ErrorDetail { get; init; }

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_VDfxhahOEeuOaMA1YOy5YQ")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; }

    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_VDfxh6hOEeuOaMA1YOy5YQ")]
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActionRequired { get; init; }

    /// <summary>
    /// Set of actions to be performed.
    /// ISO 8583 bit 39
    /// </summary>
    [IsoId("_VDfxiahOEeuOaMA1YOy5YQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action13? Action { get; init; }

    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_VDfxi6hOEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Action")]
    [IsoXmlTag("AddtlActn")]
    public AdditionalAction1? AdditionalAction { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_VDfxjahOEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation29? AdditionalInformation { get; init; }
}
