// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation10"/>
[IsoId("_WqtVQR77EeSxevWRRWxNAg")]
[DisplayName("Remittance Information")]
public partial record RemittanceInformation10
{
    /// <inheritdoc cref="IRemittanceInformation10.Unstructured"/>
    [IsoId("_W8isIx77EeSxevWRRWxNAg")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation10.Structured"/>
    [IsoId("_W8isJR77EeSxevWRRWxNAg")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation12> Structured { get; init; } = [];
}
