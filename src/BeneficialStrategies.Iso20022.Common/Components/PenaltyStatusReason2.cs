// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the penalty status reason.
/// </summary>
[IsoId("_u3iR9R-DEeuwwezkzufkMw")]
[DisplayName("Penalty Status Reason2")]
public record PenaltyStatusReason2
{
    /// <summary>
    /// Provides the reason for the penalty status.
    /// </summary>
    [IsoId("_vEVX0R-DEeuwwezkzufkMw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required PenaltyStatusReason2Choice Reason { get; init; }

    /// <summary>
    /// Further details on the penalty status reason.
    /// </summary>
    [IsoId("_vEVX0x-DEeuwwezkzufkMw")]
    [DisplayName("Additional Status Reason")]
    [IsoXmlTag("AddtlStsRsn")]
    public IsoMax210Text? AdditionalStatusReason { get; init; }
}
