// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a rejected status.
/// </summary>
[IsoId("_mHfQYQVGEeq4ZaI1b_-GPA")]
[DisplayName("Rejection Reason")]
public partial record RejectionReason50
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_mb3k8QVGEeq4ZaI1b_-GPA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedReason33Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    [IsoId("_mb3k-QVGEeq4ZaI1b_-GPA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
