// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
[IsoId("67c8adc4-75ea-435e-b3f4-cd16a4d19636")]
[DisplayName("Status And Reason49")]
public record StatusAndReason49
{
    [IsoId("4c897021-42d8-4b60-b3c2-3571bfa982ca")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status43Choice_ StatusAndReason { get; init; }

    [IsoId("dfdee925-0cea-4af4-989c-659ef3babd27")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction166> Transaction { get; init; } = [];
}
