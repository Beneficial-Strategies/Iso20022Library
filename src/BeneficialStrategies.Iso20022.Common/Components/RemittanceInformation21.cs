// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation21"/>
[IsoId("_n3SnQd4lEeqt1ZcLzWyWFw")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation21
{
    /// <inheritdoc cref="IRemittanceInformation21.Unstructured"/>
    [IsoId("_n5SyYd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation21.Structured"/>
    [IsoId("_n5SyY94lEeqt1ZcLzWyWFw")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation17> Structured { get; init; } = [];
}
