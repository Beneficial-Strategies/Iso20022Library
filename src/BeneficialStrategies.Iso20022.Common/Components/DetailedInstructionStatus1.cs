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
[IsoId("_RWdaqtp-Ed-ak6NoX_4Aeg_1765622954")]
[DisplayName("Detailed Instruction Status")]
public record DetailedInstructionStatus1
{
    /// <summary>
    /// Identifies the detailed instruction within an instruction message.
    /// </summary>
    [IsoId("_RWnLoNp-Ed-ak6NoX_4Aeg_-2110986462")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    [IsoId("_RWnLodp-Ed-ak6NoX_4Aeg_1822881804")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [IsoId("_RWnLotp-Ed-ak6NoX_4Aeg_-2130380809")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    [IsoId("_RWnLo9p-Ed-ak6NoX_4Aeg_1301124445")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus2Choice_ InstructionStatus { get; init; }
}
