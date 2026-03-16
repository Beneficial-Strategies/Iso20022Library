// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of a party.
/// </summary>
[IsoId("_TukJISFVEeWgV9SQSyaAog")]
[DisplayName("Generic Identification")]
public record GenericIdentification81
{
    /// <summary>
    /// Identification of a party, such as a tax or social security identifier.
    /// </summary>
    [IsoId("_ULIwYyFVEeWgV9SQSyaAog")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identification.
    /// </summary>
    [IsoId("_hjcOQCFVEeWgV9SQSyaAog")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required OtherIdentification3Choice_ IdentificationType { get; init; }
}
