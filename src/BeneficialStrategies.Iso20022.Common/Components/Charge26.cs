// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of formats for the type of charge.
/// </summary>
[IsoId("_JVSiqQatEeS3lpTattq7hg")]
[DisplayName("Charge")]
public record Charge26
{
    /// <summary>
    /// Type of charge.
    /// </summary>
    [IsoId("_eget8AatEeS3lpTattq7hg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType4Choice_ Type { get; init; }

    /// <summary>
    /// Charge amount or charge rate applied.
    /// </summary>
    [IsoId("_VRW2gQauEeS3lpTattq7hg")]
    [DisplayName("Charge Applied")]
    [IsoXmlTag("ChrgApld")]
    public required AmountOrRate3Choice_ ChargeApplied { get; init; }
}
