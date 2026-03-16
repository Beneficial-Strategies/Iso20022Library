// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction8.
/// </summary>
[IsoId("_6bbY0Y-9Ee-COKgew96POA")]
[DisplayName("Instruction8")]
public partial record Instruction8
{
    #nullable enable

    /// <summary>
    /// Account Details.
    /// </summary>
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount19 AccountDetails { get; init; } 

    /// <summary>
    /// Meeting Attendee.
    /// </summary>
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public ValueList<IndividualPerson41> MeetingAttendee { get; init; } = [];

    /// <summary>
    /// Proxy.
    /// </summary>
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy12? Proxy { get; init; } 

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public IsoISODateTime? RequestedExecutionDate { get; init; } 

    /// <summary>
    /// Single Instruction Identification.
    /// </summary>
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 

    /// <summary>
    /// Specific Instruction Request.
    /// </summary>
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; init; } 

    /// <summary>
    /// Vote Details.
    /// </summary>
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails6? VoteDetails { get; init; } 

    /// <summary>
    /// Vote Execution Confirmation.
    /// </summary>
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; } 

    
    #nullable disable
    
}
