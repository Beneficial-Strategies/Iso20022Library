// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance1.
/// </summary>
[IsoId("_k720LJMsEey8cNcx3imo5Q")]
[DisplayName("Remittance1")]
public partial record Remittance1
{
    #nullable enable

    /// <summary>
    /// Related.
    /// </summary>
    [DisplayName("Related")]
    [IsoXmlTag("Rltd")]
    public RemittanceLocation7? Related { get; init; } 

    /// <summary>
    /// Structured.
    /// </summary>
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation16> Structured { get; init; } = [];

    /// <summary>
    /// Unstructured.
    /// </summary>
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public ValueList<IsoMax140Text> Unstructured { get; init; } = [];

    
    #nullable disable
    
}
