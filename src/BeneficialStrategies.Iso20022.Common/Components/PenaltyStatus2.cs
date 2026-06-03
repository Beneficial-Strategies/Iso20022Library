// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the penalty status.
/// </summary>
[IsoId("_uogXgx-DEeuwwezkzufkMw")]
[DisplayName("Penalty Status2")]
public record PenaltyStatus2
{
    /// <summary>
    /// Status of a penalty.
    /// </summary>
    [IsoId("_u3iR8R-DEeuwwezkzufkMw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required PenaltyStatus2Choice Status { get; init; }

    /// <summary>
    /// Reason for the penalty status.
    /// </summary>
    [IsoId("_u3iR8x-DEeuwwezkzufkMw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<PenaltyStatusReason2> Reason { get; init; } = [];
}
