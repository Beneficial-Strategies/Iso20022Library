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
[IsoId("_RC8Bsdp-Ed-ak6NoX_4Aeg_927602263")]
[DisplayName("Instruction")]
public record Instruction2
{
    /// <summary>
    /// Identifies the detailed instruction.
    /// </summary>
    [IsoId("_RC8Bstp-Ed-ak6NoX_4Aeg_927602294")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_RC8Bs9p-Ed-ak6NoX_4Aeg_927602324")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Indicates that a Vote execution confirmation is requested.
    /// </summary>
    [IsoId("_RC8BtNp-Ed-ak6NoX_4Aeg_927602634")]
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_RC8Btdp-Ed-ak6NoX_4Aeg_-496669798")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount4 AccountDetails { get; init; }

    /// <summary>
    /// Identification of the person appointed by the security holder as proxy.
    /// </summary>
    [IsoId("_RC8Bttp-Ed-ak6NoX_4Aeg_927603271")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy4? Proxy { get; init; }

    /// <summary>
    /// Specifies detailed voting instructions.
    /// </summary>
    [IsoId("_RC8Bt9p-Ed-ak6NoX_4Aeg_-1103814182")]
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails2? VoteDetails { get; init; }

    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or a person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_RC8BuNp-Ed-ak6NoX_4Aeg_927603219")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public IndividualPerson17? MeetingAttendee { get; init; }

    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_RC8Budp-Ed-ak6NoX_4Aeg_927603189")]
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest1? SpecificInstructionRequest { get; init; }
}
