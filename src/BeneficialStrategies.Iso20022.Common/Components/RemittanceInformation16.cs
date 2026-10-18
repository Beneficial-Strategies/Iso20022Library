// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation16"/>
[IsoId("_-v4Z3W48EeiU9cctagi5ow")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation16
{
    /// <inheritdoc cref="IRemittanceInformation16.Unstructured"/>
    [IsoId("_-5awU248EeiU9cctagi5ow")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation16.Structured"/>
    [IsoId("_-5awVW48EeiU9cctagi5ow")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation16> Structured { get; init; } = [];
}
