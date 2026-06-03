// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle.
/// </summary>
[IsoId("36b7291f-b8fd-4d08-957c-47b12fd4de39")]
[DisplayName("Remittance Information26")]
public record RemittanceInformation26
{
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry, in an unstructured form.
    /// </summary>
    [IsoId("0e6013b5-9c54-427c-9d10-916f8c067660")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry, in a structured form.
    /// </summary>
    [IsoId("b54fa6b6-78a6-4d2c-8352-07d43e611622")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation22> Structured { get; init; } = [];
}
