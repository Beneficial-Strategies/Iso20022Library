// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_Y98Lt64cEemG7MmivSuE5g")]
[DisplayName("Vote")]
public partial record Vote10
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_ZRuqYa4cEemG7MmivSuE5g")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; } 
    
    /// <summary>
    /// Vote instructed.
    /// </summary>
    [IsoId("_ZRuqY64cEemG7MmivSuE5g")]
    [DisplayName("Vote Option")]
    [IsoXmlTag("VoteOptn")]
    public required VoteInstructionType1Choice_ VoteOption { get; init; } 
    
    
    #nullable disable
    
}
