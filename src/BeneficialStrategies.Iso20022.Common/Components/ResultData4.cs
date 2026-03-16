// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the processing of a file action.
/// </summary>
[IsoId("_sP44sVEAEee94_dUz-hvgw")]
[DisplayName("Result Data")]
public record ResultData4
{
    /// <summary>
    /// Generic result of the processing.
    /// </summary>
    [IsoId("_sbGDIVEAEee94_dUz-hvgw")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public FileActionResult1Code? Result { get; init; }

    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_sbGDI1EAEee94_dUz-hvgw")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherResult { get; init; }

    /// <summary>
    /// Detailed results of the processing.
    /// ISO 8583:1987 bit 39, response code list
    /// </summary>
    [IsoId("_sbGDJVEAEee94_dUz-hvgw")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText ResultDetails { get; init; }
}
