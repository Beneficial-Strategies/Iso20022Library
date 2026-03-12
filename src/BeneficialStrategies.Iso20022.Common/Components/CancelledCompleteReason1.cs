// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a cancelled completed status.
/// </summary>
[IsoId("_UQ43QCYwEeW_ZNn8gbfY7Q")]
[DisplayName("Cancelled Complete Reason")]
public partial record CancelledCompleteReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the cancelled complete status.
    /// </summary>
    [IsoId("_YeeSACYwEeW_ZNn8gbfY7Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancellationCompleteReason1Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the cancelled complete status reason.
    /// </summary>
    [IsoId("_aJTcJCYwEeW_ZNn8gbfY7Q")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
