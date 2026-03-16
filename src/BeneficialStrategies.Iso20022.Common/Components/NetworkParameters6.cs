// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters to communicate with a host.
/// </summary>
[IsoId("_OsB4UY3-EeWRwov1g9WL_A")]
[DisplayName("Network Parameters")]
public record NetworkParameters6
{
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_csPDsI3-EeWRwov1g9WL_A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required NetworkType2Code Type { get; init; }

    /// <summary>
    /// Access information to the proxy.
    /// </summary>
    [IsoId("_O2dmtY3-EeWRwov1g9WL_A")]
    [DisplayName("Access")]
    [IsoXmlTag("Accs")]
    public required NetworkParameters5 Access { get; init; }
}
