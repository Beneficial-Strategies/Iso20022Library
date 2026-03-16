// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a duration type.
/// </summary>
[IsoId("_-eV4AE6dEeyEpI66tm807w")]
[DisplayName("Compare Duration Type")]
public record CompareDurationType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_H0jZcE6eEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public DurationType1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_J8D4gE6eEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public DurationType1Code? Value2 { get; init; }
}
