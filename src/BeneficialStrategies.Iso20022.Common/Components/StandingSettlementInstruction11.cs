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
[IsoId("_FhR3eR5dEeWE3PufGMdJ3w")]
[DisplayName("Standing Settlement Instruction")]
public record StandingSettlementInstruction11
{
    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_GBj59R5dEeWE3PufGMdJ3w")]
    [DisplayName("Settlement Standing Instruction Database")]
    [IsoXmlTag("SttlmStgInstrDB")]
    public required SettlementStandingInstructionDatabase4Choice_ SettlementStandingInstructionDatabase { get; init; }

    /// <summary>
    /// Identification of the buyer or seller in a standing settlement instruction enabling to derive the Standing Settlement Instruction.
    /// </summary>
    [IsoId("_GBj5_R5dEeWE3PufGMdJ3w")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required Counterparty9Choice_ Counterparty { get; init; }

    /// <summary>
    /// Vendor of the Settlement Standing Instruction database requested to be consulted.
    /// </summary>
    [IsoId("_GBj6BR5dEeWE3PufGMdJ3w")]
    [DisplayName("Vendor")]
    [IsoXmlTag("Vndr")]
    public PartyIdentification100? Vendor { get; init; }

    /// <summary>
    /// Delivering parties, other than the seller, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_GBj6DR5dEeWE3PufGMdJ3w")]
    [DisplayName("Other Delivering Settlement Parties")]
    [IsoXmlTag("OthrDlvrgSttlmPties")]
    public SettlementParties36? OtherDeliveringSettlementParties { get; init; }

    /// <summary>
    /// Receiving parties, other than the buyer, needed for deriving the standing settlement instruction (for example, depository) or provided for information purposes (for example, instructing party settlement chain).
    /// </summary>
    [IsoId("_GBj6FR5dEeWE3PufGMdJ3w")]
    [DisplayName("Other Receiving Settlement Parties")]
    [IsoXmlTag("OthrRcvgSttlmPties")]
    public SettlementParties36? OtherReceivingSettlementParties { get; init; }
}
