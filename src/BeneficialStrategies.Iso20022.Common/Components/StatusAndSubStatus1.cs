// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status and optionally the sub status.
/// </summary>
[IsoId("_X3w_o4xlEeKdxfnzD2sqyA")]
[DisplayName("Status And Sub Status")]
public record StatusAndSubStatus1
{
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_nBafUIxlEeKdxfnzD2sqyA")]
    [DisplayName("Status Code")]
    [IsoXmlTag("StsCd")]
    public required Status13Choice_ StatusCode { get; init; }

    /// <summary>
    /// Sub status expressed as a code.
    /// </summary>
    [IsoId("_0h_vcIxlEeKdxfnzD2sqyA")]
    [DisplayName("Sub Status Code")]
    [IsoXmlTag("SubStsCd")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SubStatusCode { get; init; }
}
