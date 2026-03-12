// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a suspended status.
/// </summary>
[IsoId("_d2qkoUHmEea8I67lh6qdSQ")]
[DisplayName("Suspended Status Reason")]
public partial record SuspendedStatusReason4
{
    #nullable enable
    
    /// <summary>
    /// Reason for the conditionally accepted status expressed as a code.
    /// </summary>
    [IsoId("_eO6skUHmEea8I67lh6qdSQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required SuspendedStatusReason5Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the suspended reason.
    /// </summary>
    [IsoId("_eO6sk0HmEea8I67lh6qdSQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
