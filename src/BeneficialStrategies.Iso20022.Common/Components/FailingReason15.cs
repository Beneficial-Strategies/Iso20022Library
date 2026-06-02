// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request has a failing settlement status.
/// </summary>
[IsoId("_0o3p8eSkEe-qVZLXW4RRBw")]
[DisplayName("Failing Reason15")]
public record FailingReason15
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing status.
    /// </summary>
    [IsoId("_0w8AweSkEe-qVZLXW4RRBw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required FailingReason20Choice Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_0w8AyeSkEe-qVZLXW4RRBw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
