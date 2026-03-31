// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_UzmP6dp-Ed-ak6NoX_4Aeg_-2005620583")]
[DisplayName("Transfer Status And Reason")]
public record TransferStatusAndReason
{
    /// <summary>
    /// Business reference of the transfer instruction.
    /// </summary>
    [IsoId("_UzmP6tp-Ed-ak6NoX_4Aeg_-1918809978")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Instruction status and the reason for the status.
    /// </summary>
    [IsoId("_UzvZ0Np-Ed-ak6NoX_4Aeg_-1559464937")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferInstructionStatus Status { get; init; }

    /// <summary>
    /// Status of the transfer instruction is pending settlement.
    /// </summary>
    [IsoId("_UzvZ0dp-Ed-ak6NoX_4Aeg_-1496751882")]
    [DisplayName("Pending Settlement")]
    [IsoXmlTag("PdgSttlm")]
    public required PendingSettlementStatusChoice_ PendingSettlement { get; init; }

    /// <summary>
    /// Status of the transfer instruction is unmatched.
    /// </summary>
    [IsoId("_UzvZ0tp-Ed-ak6NoX_4Aeg_-1839191")]
    [DisplayName("Unmatched")]
    [IsoXmlTag("Umtchd")]
    public required TransferUnmatchedStatus Unmatched { get; init; }

    /// <summary>
    /// Status is in repair.
    /// </summary>
    [IsoId("_UzvZ09p-Ed-ak6NoX_4Aeg_-1844925356")]
    [DisplayName("In Repair")]
    [IsoXmlTag("InRpr")]
    public required InRepairStatus2Choice_ InRepair { get; init; }

    /// <summary>
    /// Status of the transfer instructed is rejected.
    /// </summary>
    [IsoId("_UzvZ1Np-Ed-ak6NoX_4Aeg_-1634364494")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus3Choice_ Rejected { get; init; }

    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_UzvZ1dp-Ed-ak6NoX_4Aeg_933459085")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification1Choice_? StatusInitiator { get; init; }
}
