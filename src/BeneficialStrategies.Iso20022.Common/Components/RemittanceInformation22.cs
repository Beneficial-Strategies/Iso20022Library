// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Information22.
/// </summary>
[IsoId("_7ql4wTEsEe6GxLzpkVnWYg")]
[DisplayName("Remittance Information22")]
public partial record RemittanceInformation22
{
    #nullable enable

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

    
    #nullable disable
    
}
