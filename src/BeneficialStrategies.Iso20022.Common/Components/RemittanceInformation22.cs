// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Information22.
/// </summary>
[IsoId("_7ql4wTEsEe6GxLzpkVnWYg")]
[DisplayName("Remittance Information22")]
public record RemittanceInformation22
{
    /// <summary>
    /// Structured.
    /// </summary>
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation18> Structured { get; init; } = [];

    /// <summary>
    /// Unstructured.
    /// </summary>
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public ValueList<IsoMax140Text> Unstructured { get; init; } = [];
}
