// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates derivative contract was tranched.
/// </summary>
[IsoId("_d9OP8Q06EeuJ1fOEB4bQXA")]
[DisplayName("Tranche")]
public record Tranche3
{
    /// <summary>
    /// Indicates the lower point at which the level of losses in the underlying portfolio reduces the notional of the tranche.
    /// </summary>
    [IsoId("_eS8oUw06EeuJ1fOEB4bQXA")]
    [DisplayName("Attachment Point")]
    [IsoXmlTag("AttchmntPt")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? AttachmentPoint { get; init; }

    /// <summary>
    /// Indicates the point beyond which the losses in the underlying portfolio no longer reduce the notional of the tranche.
    /// </summary>
    [IsoId("_eS8oVQ06EeuJ1fOEB4bQXA")]
    [DisplayName("Detachment Point")]
    [IsoXmlTag("DtchmntPt")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? DetachmentPoint { get; init; }
}
