// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Voting Rights Threshold2.
/// </summary>
[IsoId("_S_DsAZK5Ee-l-O3vIHRmRw")]
[DisplayName("Voting Rights Threshold2")]
public partial record VotingRightsThreshold2
{
    #nullable enable

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

    
    #nullable disable
    
}
