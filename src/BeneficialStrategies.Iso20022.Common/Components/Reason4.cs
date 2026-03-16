// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[IsoId("_qKKNYeLtEeWOD7aAy2fAcA")]
[DisplayName("Reason")]
public record Reason4
{
    /// <summary>
    /// Specifies the reason of the Status.
    /// </summary>
    [IsoId("_qTYa0eLtEeWOD7aAy2fAcA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ProprietaryReason4? Reason { get; init; }
}
