// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification through a unique product identifier.
/// </summary>
[IsoId("_4iN1MJNkEeytjZlcgApf6A")]
[DisplayName("UPI Query Criteria")]
public record UPIQueryCriteria1
{
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_Ab3SAJNlEeytjZlcgApf6A")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? Identifier { get; init; }

    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_D53p8JNlEeytjZlcgApf6A")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}
