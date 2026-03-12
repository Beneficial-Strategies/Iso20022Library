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
[IsoId("_tNc99SqDEeyR9JrVGfaMKw")]
[DisplayName("Standing Settlement Instruction")]
public partial record StandingSettlementInstruction18
{
    #nullable enable
    
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_tllwxSqDEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Standing Instruction Database")]
    [IsoXmlTag("SttlmStgInstrDB")]
    public required SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; } 
    
    /// <summary>
    /// Identification of the buyer or seller in a standing settlement instruction enabling to derive the Standing Settlement Instruction.
    /// </summary>
    [IsoId("_tllwzSqDEeyR9JrVGfaMKw")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required Counterparty15Choice_ Counterparty { get; init; } 
    
    /// <summary>
    /// Vendor of the settlement standing instruction database that is to be consulted.
    /// </summary>
    [IsoId("_tllw1SqDEeyR9JrVGfaMKw")]
    [DisplayName("Vendor")]
    [IsoXmlTag("Vndr")]
    public PartyIdentification136? Vendor { get; init; } 
    
    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_tllw3SqDEeyR9JrVGfaMKw")]
    [DisplayName("Other Delivering Settlement Parties")]
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    public SettlementParties100? OtherDeliveringSettlementParties { get; init; } 
    
    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_tllw5SqDEeyR9JrVGfaMKw")]
    [DisplayName("Other Receiving Settlement Parties")]
    [IsoXmlTag("OthrRcvgSttlmPties")]
    public SettlementParties100? OtherReceivingSettlementParties { get; init; } 
    
    
    #nullable disable
    
}
