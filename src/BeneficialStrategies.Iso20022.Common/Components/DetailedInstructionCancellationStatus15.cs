// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Instruction Cancellation Status15.
/// </summary>
[IsoId("_ppAtBYYQEe-9jM3-w7OB3g")]
[DisplayName("Detailed Instruction Cancellation Status15")]
public record DetailedInstructionCancellationStatus15
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Instruction Cancellation Status.
    /// </summary>
    [DisplayName("Instruction Cancellation Status")]
    [IsoXmlTag("InstrCxlSts")]
    public required CancellationStatus32Choice_ InstructionCancellationStatus { get; init; }

    /// <summary>
    /// Single Instruction Cancellation Identification.
    /// </summary>
    [DisplayName("Single Instruction Cancellation Identification")]
    [IsoXmlTag("SnglInstrCxlId")]
    public required IsoMax35Text SingleInstructionCancellationIdentification { get; init; }

    /// <summary>
    /// Sub Account Identification.
    /// </summary>
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }
}
