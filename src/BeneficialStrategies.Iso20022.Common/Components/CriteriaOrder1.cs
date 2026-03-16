// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ordering criteria for the transaction report.
/// </summary>
[IsoId("_1C028N6QEeiwsev40qZGEQ")]
[DisplayName("Criteria Order")]
public record CriteriaOrder1
{
    /// <summary>
    /// Identifier of target element.
    /// </summary>
    [IsoId("_DdfwwN6REeiwsev40qZGEQ")]
    [DisplayName("Target")]
    [IsoXmlTag("Trgt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public required IsoMax500Text Target { get; init; }
}
