// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of an individual instructions of a meeting instruction.
/// </summary>
[IsoId("_hD-EJRrpEeyhRdHRjakS2w")]
[DisplayName("Detailed Instruction Status")]
public record DetailedInstructionStatus16
{
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message element InstructionIdentification, for which the status is provided.
    /// </summary>
    [IsoId("_hY-q1RrpEeyhRdHRjakS2w")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_hY-q1xrpEeyhRdHRjakS2w")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_hY-q2RrpEeyhRdHRjakS2w")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Status of the individual meeting instruction.
    /// </summary>
    [IsoId("_hY-q2xrpEeyhRdHRjakS2w")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus11Choice_ InstructionStatus { get; init; }
}
