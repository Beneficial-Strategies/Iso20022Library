// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a threshold level and a threshold basis for passing resolutions at general meetings.
/// </summary>
[IsoId("_IyKJABuMEeyhRdHRjakS2w")]
[DisplayName("Voting Rights Threshold")]
public record VotingRightsThreshold1
{
    /// <summary>
    /// Voting rights threshold required for a resolution to pass in percentage or in quantity.
    /// </summary>
    [IsoId("_hM2WQBuMEeyhRdHRjakS2w")]
    [DisplayName("Threshold")]
    [IsoXmlTag("Thrshld")]
    public required NumberOrPercentage1Choice_ Threshold { get; init; }

    /// <summary>
    /// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
    /// </summary>
    [IsoId("_lbAYwBuMEeyhRdHRjakS2w")]
    [DisplayName("Threshold Basis")]
    [IsoXmlTag("ThrshldBsis")]
    public ThresholdBasis1Choice_? ThresholdBasis { get; init; }
}
