// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification Verification5.
/// </summary>
[IsoId("_6u7S8TEyEe6g-ffJsqGiSA")]
[DisplayName("Identification Verification5")]
public record IdentificationVerification5
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party And Account Identification.
    /// </summary>
    [DisplayName("Party And Account Identification")]
    [IsoXmlTag("PtyAndAcctId")]
    public required IdentificationInformation5 PartyAndAccountIdentification { get; init; }
}
