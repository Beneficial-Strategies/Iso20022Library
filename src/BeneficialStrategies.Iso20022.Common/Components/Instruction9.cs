// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting vote instruction.
/// </summary>
[IsoId("_wuMboajGEfCzuLlmLrhIvA")]
[DisplayName("Instruction9")]
public record Instruction9
{
    /// <summary>
    /// Identification of the individual instruction.
    /// </summary>
    [IsoId("_w3COk6jGEfCzuLlmLrhIvA")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_w3COlajGEfCzuLlmLrhIvA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public IsoISODateTime? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    [IsoId("_w3COl6jGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_w3COmajGEfCzuLlmLrhIvA")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount20 AccountDetails { get; init; }

    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_w3COm6jGEfCzuLlmLrhIvA")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy12? Proxy { get; init; }

    /// <summary>
    /// Detailed voting instructions.
    /// </summary>
    [IsoId("_w3COnajGEfCzuLlmLrhIvA")]
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails7? VoteDetails { get; init; }

    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_w3COn6jGEfCzuLlmLrhIvA")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public ValueList<IndividualPerson41> MeetingAttendee { get; init; } = [];

    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_w3COoajGEfCzuLlmLrhIvA")]
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; init; }

    /// <summary>
    /// Information required by the issuer to be disclosed as part of a submitted instruction.
    /// </summary>
    [IsoId("_s0YKYqnXEfC5VNwixU6YfQ")]
    [DisplayName("Additional Disclosure Information")]
    [IsoXmlTag("AddtlDsclsrInf")]
    public ValueList<PartyIdentification338> AdditionalDisclosureInformation { get; init; } = [];
}
