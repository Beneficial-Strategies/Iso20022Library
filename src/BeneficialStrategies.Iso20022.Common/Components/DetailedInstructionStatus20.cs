// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Instruction Status20.
/// </summary>
[IsoId("_YwSdxVx1Ee6fgZt44_IqFA")]
[DisplayName("Detailed Instruction Status20")]
public record DetailedInstructionStatus20
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Instruction Status.
    /// </summary>
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus12Choice_ InstructionStatus { get; init; }

    /// <summary>
    /// Single Instruction Identification.
    /// </summary>
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Sub Account Identification.
    /// </summary>
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }
}
