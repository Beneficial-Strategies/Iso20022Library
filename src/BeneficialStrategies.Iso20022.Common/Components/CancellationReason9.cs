// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request is cancelled.
/// </summary>
[IsoId("_iFN6QTnuEeWfSKvvZlhRKg")]
[DisplayName("Cancellation Reason")]
public record CancellationReason9
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_ilpt0TnuEeWfSKvvZlhRKg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CancellationReason19Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_ilpt2TnuEeWfSKvvZlhRKg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
