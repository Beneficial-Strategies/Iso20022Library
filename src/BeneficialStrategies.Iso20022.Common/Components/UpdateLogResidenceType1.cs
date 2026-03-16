// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for a residence type.
/// </summary>
[IsoId("_hgYlw2jWEeiRg5NzP0jkQg")]
[DisplayName("Update Log Residence Type")]
public record UpdateLogResidenceType1
{
    /// <summary>
    /// Old value before the update.
    /// </summary>
    [IsoId("_hgYlxWjWEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required ResidenceType1Code Old { get; init; }

    /// <summary>
    /// New value after the update.
    /// </summary>
    [IsoId("_hgYlxGjWEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required ResidenceType1Code New { get; init; }
}
