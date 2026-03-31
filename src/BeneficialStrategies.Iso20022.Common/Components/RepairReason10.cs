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
[IsoId("_i5XwYTw5EeW3QqUkIQtIUA")]
[DisplayName("Repair Reason")]
public record RepairReason10
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    [IsoId("_ja_PoTw5EeW3QqUkIQtIUA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RepairReason12Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_ja_PqTw5EeW3QqUkIQtIUA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
