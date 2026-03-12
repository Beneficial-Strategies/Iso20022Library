// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending cancellation status.
/// </summary>
[IsoId("_bw_xgbKjEemux5trsZcCpw")]
[DisplayName("Pending Cancellation Status Reason")]
public partial record PendingCancellationStatusReason10
{
    #nullable enable
    
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_cHKOxbKjEemux5trsZcCpw")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingCancellationReason7Choice_ ReasonCode { get; init; } 
    
    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    [IsoId("_cHKOzbKjEemux5trsZcCpw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
