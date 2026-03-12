// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction for a change to an account status and reason for the change.
/// </summary>
[IsoId("_et6_QHi5EeaRm5xIK6nGuQ")]
[DisplayName("Account Status Update Instruction")]
public partial record AccountStatusUpdateInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Type of status change instructed for the account status.
    /// </summary>
    [IsoId("_mJ2lUHi5EeaRm5xIK6nGuQ")]
    [DisplayName("Update Instruction")]
    [IsoXmlTag("UpdInstr")]
    public required AccountStatusUpdateInstruction1Choice_ UpdateInstruction { get; init; } 
    
    /// <summary>
    /// Reason for the instruction to change the account status.
    /// </summary>
    [IsoId("_Z0gj0Hi6EeaRm5xIK6nGuQ")]
    [DisplayName("Update Instruction Reason")]
    [IsoXmlTag("UpdInstrRsn")]
    public AccountStatusUpdateInstructionReason1Choice_? UpdateInstructionReason { get; init; } 
    
    
    #nullable disable
    
}
