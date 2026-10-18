// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation11"/>
[IsoId("_0HuOoTq4EeWZFYSPlduMhw")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation11
{
    /// <inheritdoc cref="IRemittanceInformation11.Unstructured"/>
    [IsoId("_0Pit4zq4EeWZFYSPlduMhw")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation11.Structured"/>
    [IsoId("_0Pit5Tq4EeWZFYSPlduMhw")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation13> Structured { get; init; } = [];
}
