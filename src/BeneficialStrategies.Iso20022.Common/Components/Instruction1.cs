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
[IsoId("_RW6GmNp-Ed-ak6NoX_4Aeg_-1229563854")]
[DisplayName("Instruction")]
public record Instruction1
{
    /// <summary>
    /// Identifies the detailed instruction.
    /// </summary>
    [IsoId("_RW6Gmdp-Ed-ak6NoX_4Aeg_84667180")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_RXD3kNp-Ed-ak6NoX_4Aeg_84667181")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Indicates that a Vote execution confirmation is requested.
    /// </summary>
    [IsoId("_RXD3kdp-Ed-ak6NoX_4Aeg_84667198")]
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_RXD3ktp-Ed-ak6NoX_4Aeg_1099288385")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount3 AccountDetails { get; init; }

    /// <summary>
    /// Identification of the person appointed by the security holder as proxy.
    /// </summary>
    [IsoId("_RXD3k9p-Ed-ak6NoX_4Aeg_1488769519")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy2? Proxy { get; init; }

    /// <summary>
    /// Specifies detailed voting instructions.
    /// </summary>
    [IsoId("_RXD3lNp-Ed-ak6NoX_4Aeg_-1182245952")]
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails1? VoteDetails { get; init; }

    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or a person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_RXD3ldp-Ed-ak6NoX_4Aeg_1510934648")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public IndividualPerson13? MeetingAttendee { get; init; }

    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_RXD3ltp-Ed-ak6NoX_4Aeg_-362500258")]
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest1? SpecificInstructionRequest { get; init; }
}
