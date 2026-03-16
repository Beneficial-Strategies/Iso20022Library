// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the standing settlement instruction to be applied.
/// </summary>
[IsoId("_6sllzffVEeiNZp_PtLohLw")]
[DisplayName("Standing Settlement Instruction")]
public record StandingSettlementInstruction17
{
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_6sll0_fVEeiNZp_PtLohLw")]
    [DisplayName("Settlement Standing Instruction Database")]
    [IsoXmlTag("SttlmStgInstrDB")]
    public required SettlementStandingInstructionDatabase5Choice_ SettlementStandingInstructionDatabase { get; init; }

    /// <summary>
    /// Identification of the buyer or seller in a standing settlement instruction enabling to derive the Standing Settlement Instruction.
    /// </summary>
    [IsoId("_6sll2_fVEeiNZp_PtLohLw")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required Counterparty14Choice_ Counterparty { get; init; }

    /// <summary>
    /// Vendor of the settlement standing instruction database that is to be consulted.
    /// </summary>
    [IsoId("_6sll4_fVEeiNZp_PtLohLw")]
    [DisplayName("Vendor")]
    [IsoXmlTag("Vndr")]
    public PartyIdentification157? Vendor { get; init; }

    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_6sll6_fVEeiNZp_PtLohLw")]
    [DisplayName("Other Delivering Settlement Parties")]
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    public SettlementParties81? OtherDeliveringSettlementParties { get; init; }

    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_6sll8_fVEeiNZp_PtLohLw")]
    [DisplayName("Other Receiving Settlement Parties")]
    [IsoXmlTag("OthrRcvgSttlmPties")]
    public SettlementParties81? OtherReceivingSettlementParties { get; init; }
}
