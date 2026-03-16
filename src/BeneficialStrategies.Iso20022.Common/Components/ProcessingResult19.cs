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
[IsoId("_lsmvER1NEey8XKHwKquEQw")]
[DisplayName("Processing Result")]
public record ProcessingResult19
{
    /// <summary>
    /// Information about the entity that provides the response.
    /// </summary>
    [IsoId("_MXGhcCFVEey8XKHwKquEQw")]
    [DisplayName("Response Source")]
    [IsoXmlTag("RspnSrc")]
    public ApprovalEntity2? ResponseSource { get; init; }

    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_lyq60R1NEey8XKHwKquEQw")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public required ResultData10 ResultData { get; init; }

    /// <summary>
    /// Error detail information
    /// </summary>
    [IsoId("_R-g14CFVEey8XKHwKquEQw")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ErrorDetails2? ErrorDetail { get; init; }

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_lyq60x1NEey8XKHwKquEQw")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_lyq61R1NEey8XKHwKquEQw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation30? AdditionalInformation { get; init; }
}
