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
[IsoId("_xuSKMVAzEeedyPuM0kK2EQ")]
[DisplayName("Result Data")]
public record ResultData2
{
    /// <summary>
    /// Generic result of the processing.
    /// </summary>
    [IsoId("_x5IvUVAzEeedyPuM0kK2EQ")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Response6Code? Result { get; init; }

    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_NR5awFA1EeedyPuM0kK2EQ")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResult { get; init; }

    /// <summary>
    /// Detailed results of the processing.
    /// ISO 8583:1987 bit 39, response code list
    /// </summary>
    [IsoId("_x5IvU1AzEeedyPuM0kK2EQ")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText ResultDetails { get; init; }

    /// <summary>
    /// Other result details of the processing.
    /// </summary>
    [IsoId("_x5IvVVAzEeedyPuM0kK2EQ")]
    [DisplayName("Other Result Details")]
    [IsoXmlTag("OthrRsltDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResultDetails { get; init; }

    /// <summary>
    /// Additional result information to be conveyed.
    /// </summary>
    [IsoId("_x5IvV1AzEeedyPuM0kK2EQ")]
    [DisplayName("Additional Result Information")]
    [IsoXmlTag("AddtlRsltInf")]
    public AdditionalData1? AdditionalResultInformation { get; init; }
}
