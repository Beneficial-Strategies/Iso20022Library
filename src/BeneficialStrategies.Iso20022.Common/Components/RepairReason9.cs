// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction is in repair.
/// </summary>
[IsoId("_07ksUTqeEeWyoP0PbocV1Q")]
[DisplayName("Repair Reason")]
public record RepairReason9
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair status.
    /// </summary>
    [IsoId("_1bjz4TqeEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RepairReason10Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_1btk4TqeEeWyoP0PbocV1Q")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
