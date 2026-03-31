// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for the contact details
/// </summary>
[IsoId("_YBkCQ2jTEeiRg5NzP0jkQg")]
[DisplayName("Update Log Contact")]
public record UpdateLogContact1
{
    /// <summary>
    /// Old value before change
    /// </summary>
    [IsoId("_YBkCRGjTEeiRg5NzP0jkQg")]
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required Contact5 Old { get; init; }

    /// <summary>
    /// New value after change
    /// </summary>
    [IsoId("_YBkCRWjTEeiRg5NzP0jkQg")]
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required Contact5 New { get; init; }
}
