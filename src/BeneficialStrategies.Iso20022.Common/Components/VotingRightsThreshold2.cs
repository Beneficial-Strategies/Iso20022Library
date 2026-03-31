// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Voting Rights Threshold2.
/// </summary>
[IsoId("_S_DsAZK5Ee-l-O3vIHRmRw")]
[DisplayName("Voting Rights Threshold2")]
public record VotingRightsThreshold2
{
    /// <summary>
    /// Threshold.
    /// </summary>
    [DisplayName("Threshold")]
    [IsoXmlTag("Thrshld")]
    public required NumberOrPercentage2Choice_ Threshold { get; init; }

    /// <summary>
    /// Threshold Basis.
    /// </summary>
    [DisplayName("Threshold Basis")]
    [IsoXmlTag("ThrshldBsis")]
    public ThresholdBasis1Choice_? ThresholdBasis { get; init; }
}
