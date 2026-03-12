// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an update to an account status.
/// </summary>
[IsoId("_qkYIgXi8EeaRm5xIK6nGuQ")]
[DisplayName("Account Status Update Instruction Reason")]
public partial record AccountStatusUpdateInstructionReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the instruction to change the account status.
    /// </summary>
    [IsoId("_rIrIYXi8EeaRm5xIK6nGuQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public AccountStatusUpdateInstructionReason2Choice_? Code { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the instruction to change the account status.
    /// </summary>
    [IsoId("_rIrIY3i8EeaRm5xIK6nGuQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
