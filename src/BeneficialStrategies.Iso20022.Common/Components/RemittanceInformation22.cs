// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceInformation22"/>
[IsoId("_7ql4wTEsEe6GxLzpkVnWYg")]
[Description(
    @"Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system."
)]
[DisplayName("Remittance Information22")]
public partial record RemittanceInformation22
{
    /// <inheritdoc cref="IRemittanceInformation22.Structured"/>
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation18> Structured { get; init; } = [];

    /// <inheritdoc cref="IRemittanceInformation22.Unstructured"/>
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public ValueList<IsoMax140Text> Unstructured { get; init; } = [];
}
