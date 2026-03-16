// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Update Log Address2.
/// </summary>
[IsoId("_qaN4wzHSEe6Q5sI3912YOA")]
[DisplayName("Update Log Address2")]
public record UpdateLogAddress2
{
    /// <summary>
    /// New.
    /// </summary>
    [DisplayName("New")]
    [IsoXmlTag("New")]
    public required PostalAddress28 New { get; init; }

    /// <summary>
    /// Old.
    /// </summary>
    [DisplayName("Old")]
    [IsoXmlTag("Od")]
    public required PostalAddress28 Old { get; init; }
}
