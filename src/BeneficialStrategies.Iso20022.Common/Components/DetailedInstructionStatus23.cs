// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of an individual instruction of a meeting instruction.
/// </summary>
[IsoId("_D2yUxajVEfCzuLlmLrhIvA")]
[DisplayName("Detailed Instruction Status23")]
public record DetailedInstructionStatus23
{
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message element InstructionIdentification, for which the status is provided.
    /// </summary>
    [IsoId("_D98Fo6jVEfCzuLlmLrhIvA")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_D98FpajVEfCzuLlmLrhIvA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_D98Fp6jVEfCzuLlmLrhIvA")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Status of the individual meeting instruction.
    /// </summary>
    [IsoId("_D98FqajVEfCzuLlmLrhIvA")]
    [DisplayName("Instruction Status")]
    [IsoXmlTag("InstrSts")]
    public required InstructionStatus14Choice_ InstructionStatus { get; init; }
}
