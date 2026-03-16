// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the instruction.
/// </summary>
[IsoId("_HGObUVtiEeSwKe7KuKvXhg")]
[DisplayName("Instruction")]
public record Instruction3
{
    /// <summary>
    /// Identifies the detailed instruction.
    /// </summary>
    [IsoId("_HjiCZVtiEeSwKe7KuKvXhg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_HjiCZ1tiEeSwKe7KuKvXhg")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    [IsoId("_HjiCaVtiEeSwKe7KuKvXhg")]
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_HjiCa1tiEeSwKe7KuKvXhg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount6 AccountDetails { get; init; }

    /// <summary>
    /// Identification of the person appointed by the security holder as proxy.
    /// </summary>
    [IsoId("_HjiCbVtiEeSwKe7KuKvXhg")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy6? Proxy { get; init; }

    /// <summary>
    /// Specifies detailed voting instructions.
    /// </summary>
    [IsoId("_HjiCb1tiEeSwKe7KuKvXhg")]
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails3? VoteDetails { get; init; }

    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_HjiCcVtiEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public IndividualPerson26? MeetingAttendee { get; init; }

    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_HjiCc1tiEeSwKe7KuKvXhg")]
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest1? SpecificInstructionRequest { get; init; }
}
