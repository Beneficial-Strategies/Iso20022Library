// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the corporate action reversal occurs.
/// </summary>
[IsoId("_bvXBQUGKEeWqy4niLuXETA")]
[DisplayName("Corporate Action Reversal Reason")]
public partial record CorporateActionReversalReason3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_cCQvI0GKEeWqy4niLuXETA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CorporateActionReversalReason3Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_cCQvJUGKEeWqy4niLuXETA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
