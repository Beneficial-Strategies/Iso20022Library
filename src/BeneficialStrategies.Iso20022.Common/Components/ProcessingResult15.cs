// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the authorisation.
/// </summary>
[IsoId("_nrR_ER1JEey8XKHwKquEQw")]
[DisplayName("Processing Result")]
public record ProcessingResult15
{
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    [IsoId("_OiQNkSFZEey8XKHwKquEQw")]
    [DisplayName("Response Source")]
    [IsoXmlTag("RspnSrc")]
    public ApprovalEntity2? ResponseSource { get; init; }

    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_nxhJ8R1JEey8XKHwKquEQw")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public required ResultData7 ResultData { get; init; }

    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_PfBX0SFZEey8XKHwKquEQw")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails2> ErrorDetail { get; init; } = [];

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request
    /// </summary>
    [IsoId("_nxhJ8x1JEey8XKHwKquEQw")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_nxhJ9R1JEey8XKHwKquEQw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation29> AdditionalInformation { get; init; } = [];
}
