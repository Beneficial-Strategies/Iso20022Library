// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
[IsoId("_RVtzwtp-Ed-ak6NoX_4Aeg_417792358")]
[DisplayName("Detailed Instruction Status")]
public record DetailedInstructionStatus2
{
    /// <summary>
    /// Identifies the detailed instruction with an instruction message.
    /// </summary>
    [IsoId("_RVtzw9p-Ed-ak6NoX_4Aeg_417792400")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    [IsoId("_RVtzxNp-Ed-ak6NoX_4Aeg_417792360")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_RVtzxdp-Ed-ak6NoX_4Aeg_303009220")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification9Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [IsoId("_RWdaoNp-Ed-ak6NoX_4Aeg_417792383")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_RWdaodp-Ed-ak6NoX_4Aeg_318709462")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification9Choice_> RightsHolder { get; init; } = [];

    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_RWdaotp-Ed-ak6NoX_4Aeg_90600632")]
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StandingInstruction { get; init; }

    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_RWdao9p-Ed-ak6NoX_4Aeg_243906997")]
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<Vote4> VotePerResolution { get; init; } = [];
}
