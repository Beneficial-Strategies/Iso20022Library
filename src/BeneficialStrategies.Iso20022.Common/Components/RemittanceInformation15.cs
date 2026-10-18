// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation15"/>
[IsoId("_keWygbTLEeeYQd8Z9bqFog")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation15
{
    /// <inheritdoc cref="IRemittanceInformation15.Unstructured"/>
    [IsoId("_km0K87TLEeeYQd8Z9bqFog")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation15.Structured"/>
    [IsoId("_km0K9bTLEeeYQd8Z9bqFog")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation15> Structured { get; init; } = [];
}
