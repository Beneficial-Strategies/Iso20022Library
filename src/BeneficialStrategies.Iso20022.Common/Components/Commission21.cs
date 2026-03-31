// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_GK8bkQavEeS3lpTattq7hg")]
[DisplayName("Commission")]
public record Commission21
{
    /// <summary>
    /// Type of commission.
    /// </summary>
    [IsoId("_ZCl3AAavEeS3lpTattq7hg")]
    [DisplayName("Commission Type")]
    [IsoXmlTag("ComssnTp")]
    public required CommissionType5Choice_ CommissionType { get; init; }

    /// <summary>
    /// Commission amount or commission rate applied.
    /// </summary>
    [IsoId("_1HtHkAavEeS3lpTattq7hg")]
    [DisplayName("Commission Applied")]
    [IsoXmlTag("ComssnApld")]
    public required AmountOrRate3Choice_ CommissionApplied { get; init; }
}
