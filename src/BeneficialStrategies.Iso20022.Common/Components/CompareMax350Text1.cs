// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a text field of 350 characters.
/// </summary>
[IsoId("_pmaggU6VEeyEpI66tm807w")]
[DisplayName("Compare Max 350 Text")]
public record CompareMax350Text1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_poOeYU6VEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_poOeY06VEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Value2 { get; init; }
}
