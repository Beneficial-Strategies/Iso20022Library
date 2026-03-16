// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the batch.
/// </summary>
[IsoId("_jFmMUcsWEeuNe7RtB4qFHw")]
[DisplayName("Processing Result")]
public record ProcessingResult13
{
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    [IsoId("_aZXF0SFWEey8XKHwKquEQw")]
    [DisplayName("Response Source")]
    [IsoXmlTag("RspnSrc")]
    public ApprovalEntity2? ResponseSource { get; init; }

    /// <summary>
    /// Result information related to the processing of the transaction.
    /// </summary>
    [IsoId("_jKX-ocsWEeuNe7RtB4qFHw")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public required ResultData8 ResultData { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_dyaFQSFWEey8XKHwKquEQw")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Exact6AlphaNumericText)]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_e2jC0SFWEey8XKHwKquEQw")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails2> ErrorDetail { get; init; } = [];

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_jKX-o8sWEeuNe7RtB4qFHw")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_MiqNQTHUEeyTT91yHXSlSQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation29> AdditionalInformation { get; init; } = [];
}
