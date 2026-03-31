// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual cancellation instructions of a meeting instruction cancellation request message.
/// </summary>
[IsoId("_WrUtJ8T3Eem9aZlimxVUIw")]
[DisplayName("Detailed Instruction Cancellation Status")]
public record DetailedInstructionCancellationStatus14
{
    /// <summary>
    /// Identification of the specific individual instruction cancellation request from the original meeting instruction cancellation request message identified in InstructionType/ InstructionCancellationIdentification, for which the status is provided.
    /// </summary>
    [IsoId("_Wrd3E8T3Eem9aZlimxVUIw")]
    [DisplayName("Single Instruction Cancellation Identification")]
    [IsoXmlTag("SnglInstrCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionCancellationIdentification { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_Wrd3FMT3Eem9aZlimxVUIw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_Wrd3EMT3Eem9aZlimxVUIw")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Status of an individual meeting instruction cancellation request.
    /// </summary>
    [IsoId("_Wrd3EcT3Eem9aZlimxVUIw")]
    [DisplayName("Instruction Cancellation Status")]
    [IsoXmlTag("InstrCxlSts")]
    public required CancellationStatus26Choice_ InstructionCancellationStatus { get; init; }
}
