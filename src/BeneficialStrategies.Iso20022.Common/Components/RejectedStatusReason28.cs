// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected cancellation status.
/// </summary>
[IsoId("_2ZcXKrKgEemux5trsZcCpw")]
[DisplayName("Rejected Status Reason")]
public partial record RejectedStatusReason28
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_2ZcXLbKgEemux5trsZcCpw")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason29Choice_ ReasonCode { get; init; } 
    
    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    [IsoId("_2ZcXLLKgEemux5trsZcCpw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
