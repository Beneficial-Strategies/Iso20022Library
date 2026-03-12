// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting vote instruction.
/// </summary>
[IsoId("_wcR2cRrfEeyhRdHRjakS2w")]
[DisplayName("Instruction")]
public partial record Instruction6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction.
    /// </summary>
    [IsoId("_ww1xNRrfEeyhRdHRjakS2w")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_ww1xNxrfEeyhRdHRjakS2w")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDate { get; init; } 
    
    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    [IsoId("_ww1xORrfEeyhRdHRjakS2w")]
    [DisplayName("Vote Execution Confirmation")]
    [IsoXmlTag("VoteExctnConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; } 
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_ww1xOxrfEeyhRdHRjakS2w")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount14 AccountDetails { get; init; } 
    
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_ww1xPRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public Proxy12? Proxy { get; init; } 
    
    /// <summary>
    /// Detailed voting instructions.
    /// </summary>
    [IsoId("_ww1xPxrfEeyhRdHRjakS2w")]
    [DisplayName("Vote Details")]
    [IsoXmlTag("VoteDtls")]
    public VoteDetails5? VoteDetails { get; init; } 
    
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_ww1xQRrfEeyhRdHRjakS2w")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public IndividualPerson41? MeetingAttendee { get; init; } 
    
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_ww1xQxrfEeyhRdHRjakS2w")]
    [DisplayName("Specific Instruction Request")]
    [IsoXmlTag("SpcfcInstrReq")]
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; init; } 
    
    
    #nullable disable
    
}
