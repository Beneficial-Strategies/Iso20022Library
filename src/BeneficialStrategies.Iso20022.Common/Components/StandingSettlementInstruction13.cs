// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the standing settlement instruction to be applied.
/// </summary>
[IsoId("_sJHCEY-vEeaEa8S_GI1QNA")]
[DisplayName("Standing Settlement Instruction")]
public partial record StandingSettlementInstruction13
{
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_sYI8lY-vEeaEa8S_GI1QNA")]
    [DisplayName("Settlement Standing Instruction Database")]
    [IsoXmlTag("SttlmStgInstrDB")]
    public required SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; } 
    
    /// <summary>
    /// Vendor of the Settlement Standing Instruction database requested to be consulted.
    /// </summary>
    [IsoId("_sYI8nY-vEeaEa8S_GI1QNA")]
    [DisplayName("Vendor")]
    [IsoXmlTag("Vndr")]
    public PartyIdentification117Choice_? Vendor { get; init; } 
    
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_sYI8pY-vEeaEa8S_GI1QNA")]
    [DisplayName("Other Delivering Settlement Parties")]
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    public SettlementParties59? OtherDeliveringSettlementParties { get; init; } 
    
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_sYI8rY-vEeaEa8S_GI1QNA")]
    [DisplayName("Other Receiving Settlement Parties")]
    [IsoXmlTag("OthrRcvgSttlmPties")]
    public SettlementParties59? OtherReceivingSettlementParties { get; init; } 
    
    
    #nullable disable
    
}
