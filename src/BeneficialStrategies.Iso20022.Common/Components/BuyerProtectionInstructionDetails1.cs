// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information received for a given buyer protection instruction.
/// </summary>
[IsoId("_wvC70N_GEe-Ned3-G07x_A")]
[DisplayName("Buyer Protection Instruction Details1")]
public record BuyerProtectionInstructionDetails1
{
    /// <summary>
    /// Identification of the related buyer protection instruction document for which the cancellation is requested.
    /// </summary>
    [IsoId("_C4emYd_HEe-Ned3-G07x_A")]
    [DisplayName("Buyer Protection Instruction Identification")]
    [IsoXmlTag("BuyrPrtcnInstrId")]
    public required DocumentIdentification57 BuyerProtectionInstructionIdentification { get; init; }

    /// <summary>
    /// Set of elements used to identify the buyer protected settlement instruction.
    /// </summary>
    [IsoId("_InAaAN_IEe-Ned3-G07x_A")]
    [DisplayName("Related Settlement Instruction Identification")]
    [IsoXmlTag("RltdSttlmInstrId")]
    public required RelatedSettlementInstruction4 RelatedSettlementInstructionIdentification { get; init; }

    /// <summary>
    /// First receiving party in the settlement chain.
    /// </summary>
    [IsoId("_gQwt1FdOEfCb5MzBL2XS4A")]
    [DisplayName("Counterparty Depository")]
    [IsoXmlTag("CtrPtyDpstry")]
    public PartyIdentification143? CounterpartyDepository { get; init; }

    /// <summary>
    /// Selected safekeeping accounts list to which the corporate action event applies.
    /// </summary>
    [IsoId("_83Zi0d_IEe-Ned3-G07x_A")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccountIdentification1Choice_ AccountIdentification { get; init; }

    /// <summary>
    /// Information about the processing status of the instruction.
    /// </summary>
    [IsoId("_U9Qvkd_JEe-Ned3-G07x_A")]
    [DisplayName("Instruction Processing Status")]
    [IsoXmlTag("InstrPrcgSts")]
    public required InstructionProcessingStatus59Choice_ InstructionProcessingStatus { get; init; }
}
