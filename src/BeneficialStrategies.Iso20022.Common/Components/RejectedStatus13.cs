// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected status.
/// </summary>
[IsoId("ef41aae4-6c87-4899-8dbf-0d4329bbeb56")]
[DisplayName("Rejected Status13")]
public record RejectedStatus13
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("71f7606a-350b-4165-bee8-d59906bed7d3")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public RejectedReason66Choice_? Reason { get; init; }

    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    [IsoId("a3550f7b-413d-4e22-9cc8-60d0995a1e27")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
