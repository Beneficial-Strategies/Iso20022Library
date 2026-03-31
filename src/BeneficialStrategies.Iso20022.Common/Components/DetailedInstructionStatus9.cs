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
[IsoId("_RDFystp-Ed-ak6NoX_4Aeg_1040851722")]
[DisplayName("Detailed Instruction Status")]
public record DetailedInstructionStatus9
{
    /// <summary>
    /// Identifies the detailed instruction with an instruction message.
    /// </summary>
    [IsoId("_RDFys9p-Ed-ak6NoX_4Aeg_1200623428")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    [IsoId("_RDFytNp-Ed-ak6NoX_4Aeg_1200623367")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_RDFytdp-Ed-ak6NoX_4Aeg_1917273126")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification9Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [IsoId("_RDFyttp-Ed-ak6NoX_4Aeg_1200623397")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_RDFyt9p-Ed-ak6NoX_4Aeg_2005933537")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification9Choice_> RightsHolder { get; init; } = [];

    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_RDFyuNp-Ed-ak6NoX_4Aeg_1200623459")]
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StandingInstruction { get; init; }

    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_RDFyudp-Ed-ak6NoX_4Aeg_2089050088")]
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(1)]
    [MaxLength(1000)]
    public ValueList<Vote4> VotePerResolution { get; init; } = [];
}
