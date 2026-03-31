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
[IsoId("_baIw1_NfEeqRfth943bvEA")]
[DisplayName("Detailed Instruction Status")]
public record DetailedInstructionStatus14
{
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message element InstructionIdentification, for which the status is provided.
    /// </summary>
    [IsoId("_btxehfNfEeqRfth943bvEA")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_btxeh_NfEeqRfth943bvEA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_btxeifNfEeqRfth943bvEA")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Status of the individual meeting instruction.
    /// </summary>
    [IsoId("_btxei_NfEeqRfth943bvEA")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus10Choice_ InstructionStatus { get; init; }
}
