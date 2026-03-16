// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the processing.
/// </summary>
[IsoId("_r_HnMcsVEeuNe7RtB4qFHw")]
[DisplayName("Result Data")]
public record ResultData8
{
    /// <summary>
    /// Generic result of the processing.
    /// </summary>
    [IsoId("_sDrXEcsVEeuNe7RtB4qFHw")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Response6Code? Result { get; init; }

    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_sDrXE8sVEeuNe7RtB4qFHw")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResult { get; init; }

    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.  This code list is maintained by the ISO 8583/MA (maintenance agency).
    /// </summary>
    [IsoId("_BCxnNMsWEeuNe7RtB4qFHw")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public required ISO8583ResponseCode ResultDetails { get; init; }

    /// <summary>
    /// Other result details of the processing.
    /// </summary>
    [IsoId("_sDrXF8sVEeuNe7RtB4qFHw")]
    [DisplayName("Other Result Details")]
    [IsoXmlTag("OthrRsltDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResultDetails { get; init; }

    /// <summary>
    /// Additional result information to be conveyed.
    /// </summary>
    [IsoId("_sDrXGcsVEeuNe7RtB4qFHw")]
    [DisplayName("Additional Result Information")]
    [IsoXmlTag("AddtlRsltInf")]
    public AdditionalData1? AdditionalResultInformation { get; init; }
}
