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
[IsoId("_-H8CoSW-EeygjNFjAlVoPA")]
[DisplayName("Failing Reason")]
public record FailingReason11
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing status.
    /// </summary>
    [IsoId("_-e4i8SW-EeygjNFjAlVoPA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required FailingReason16Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_-e4i-SW-EeygjNFjAlVoPA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
