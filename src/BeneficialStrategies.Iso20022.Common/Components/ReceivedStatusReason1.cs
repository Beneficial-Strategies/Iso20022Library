// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a received status.
/// </summary>
[IsoId("_Kak_Clj7EeOgwYxfAV02bg")]
[DisplayName("Received Status Reason")]
public partial record ReceivedStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the received status.
    /// </summary>
    [IsoId("_Kak_EFj7EeOgwYxfAV02bg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ReceivedReason1Choice_ Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the processed instruction.
    /// </summary>
    [IsoId("_Kak_C1j7EeOgwYxfAV02bg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
