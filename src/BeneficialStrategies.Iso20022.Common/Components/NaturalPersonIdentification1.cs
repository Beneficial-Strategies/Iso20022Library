// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification number and identification type of a natural person.
/// </summary>
[IsoId("_BInyYId6EemJ1cSJJmVYRQ")]
[DisplayName("Natural Person Identification")]
public record NaturalPersonIdentification1
{
    /// <summary>
    /// Natural person local identification.
    /// </summary>
    [IsoId("_I3BBcId6EemJ1cSJJmVYRQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of local identification for a natural person.
    /// </summary>
    [IsoId("_WBjJEId6EemJ1cSJJmVYRQ")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public IdentificationType45Choice_? IdentificationType { get; init; }
}
