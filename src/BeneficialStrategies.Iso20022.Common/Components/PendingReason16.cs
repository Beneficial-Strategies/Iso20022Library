// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request has a pending status.
/// </summary>
[IsoId("_GHwrgTqfEeWyoP0PbocV1Q")]
[DisplayName("Pending Reason")]
public record PendingReason16
{
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [IsoId("_GnAMMTqfEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PendingReason28Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_GnAMOTqfEeWyoP0PbocV1Q")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
