// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Generic Identification186.
/// </summary>
[IsoId("_xre0cI8UEe6r6f2NSkdeiA")]
[DisplayName("Generic Identification186")]
public record GenericIdentification186
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax256Text Identification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PartyType7Code Type { get; init; }
}
