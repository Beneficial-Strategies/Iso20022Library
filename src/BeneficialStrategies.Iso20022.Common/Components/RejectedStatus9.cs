// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected status.
/// </summary>
[IsoId("_IS4acUHjEea8I67lh6qdSQ")]
[DisplayName("Rejected Status")]
public partial record RejectedStatus9
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_TJYC4EHjEea8I67lh6qdSQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public RejectedReason20Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    [IsoId("_IsU1OUHjEea8I67lh6qdSQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
