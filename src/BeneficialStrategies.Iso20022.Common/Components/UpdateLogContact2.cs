// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Update Log Contact2.
/// </summary>
[IsoId("_Yy18KTE_Ee62xuUQ2zyZww")]
[DisplayName("Update Log Contact2")]
public record UpdateLogContact2
{
    /// <summary>
    /// New.
    /// </summary>
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required Contact14 New { get; init; }

    /// <summary>
    /// Old.
    /// </summary>
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required Contact14 Old { get; init; }
}
