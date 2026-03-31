// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a party identification. For example, party identification or account identification.
/// </summary>
[IsoId("_UqTR4EVJEeSGWeX3z5zSZQ")]
[DisplayName("Party Identification")]
public record PartyIdentification90
{
    /// <summary>
    /// Specifies a type of party identification.
    /// </summary>
    [IsoId("_lWrvoEVJEeSGWeX3z5zSZQ")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required PartyIdentificationType1Code IdentificationType { get; init; }

    /// <summary>
    /// Identification of a party related information.
    /// </summary>
    [IsoId("_NDw4cDW2EeWrsayQdXgukw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }
}
