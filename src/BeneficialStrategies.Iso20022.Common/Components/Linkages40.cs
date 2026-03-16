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
[IsoId("_KLKpuzzbEeWeNtT0s2RbkQ")]
[DisplayName("Linkages")]
public record Linkages40
{
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Kr5YETzbEeWeNtT0s2RbkQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References47Choice_ Reference { get; init; }
}
