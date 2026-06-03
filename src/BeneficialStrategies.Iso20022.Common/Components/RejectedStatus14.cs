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
[IsoId("c019b0b2-25e9-4075-976c-01d5b681e46d")]
[DisplayName("Rejected Status14")]
public record RejectedStatus14
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("380b3d15-d8b2-4a22-bb7a-3adf9f41c9fa")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public RejectedReason67Choice? Reason { get; init; }

    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    [IsoId("5a80fed5-f67f-4273-8470-a8b5030f8b51")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
