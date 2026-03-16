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
[IsoId("_X58_Ia4cEemG7MmivSuE5g")]
[DisplayName("Instruction")]
public record Instruction4
{
    /// <summary>
    /// Identification of the individual instruction.
    /// </summary>
    [IsoId("_YTYy1a4cEemG7MmivSuE5g")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_YTYy164cEemG7MmivSuE5g")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    [IsoId("_YTYy2a4cEemG7MmivSuE5g")]
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_YTYy264cEemG7MmivSuE5g")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount9 AccountDetails { get; init; }

    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_YTYy3a4cEemG7MmivSuE5g")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy7? Proxy { get; init; }

    /// <summary>
    /// Detailed voting instructions.
    /// </summary>
    [IsoId("_YTYy364cEemG7MmivSuE5g")]
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails4? VoteDetails { get; init; }

    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_YTYy4a4cEemG7MmivSuE5g")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public IndividualPerson39? MeetingAttendee { get; init; }

    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_YTYy464cEemG7MmivSuE5g")]
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest2? SpecificInstructionRequest { get; init; }
}
