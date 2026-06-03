// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other accepted financial instrument's identification than ISIN.
/// </summary>
[IsoId("2ef2b67e-a80e-4651-b05b-f40c63edd028")]
[DisplayName("Other Identification8")]
public record OtherIdentification8
{
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("909f5b7a-c7e5-4f04-9a76-cc0a1e2116b1")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identifies the suffix of the security identification.
    /// </summary>
    [IsoId("09b76319-d034-470a-b36f-40fa4288e19a")]
    [DisplayName("Suffix")]
    [IsoXmlTag("Sfx")]
    public IsoMax16Text? Suffix { get; init; }

    /// <summary>
    /// Type of the identification.
    /// </summary>
    [IsoId("fbc93622-6c51-4911-946b-13eb8b6620f9")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IdentificationSource6Choice Type { get; init; }
}
