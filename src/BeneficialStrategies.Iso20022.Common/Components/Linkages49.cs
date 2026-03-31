// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_61vy15NLEeWGlc8L7oPDIg")]
[DisplayName("Linkages")]
public record Linkages49
{
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_61vy2ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References58Choice_ Reference { get; init; }
}
