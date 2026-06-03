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
[IsoId("_hakyYa8uEfCx2aBifPEdRg")]
[DisplayName("Detailed Instruction Cancellation Status16")]
public record DetailedInstructionCancellationStatus16
{
    /// <summary>
    /// Identification of the specific individual instruction cancellation request from the original meeting instruction cancellation request message, for which the status is provided.
    /// </summary>
    [IsoId("_hjmLg68uEfCx2aBifPEdRg")]
    [DisplayName("Single Instruction Cancellation Identification")]
    [IsoXmlTag("SnglInstrCxlId")]
    public required IsoMax35Text SingleInstructionCancellationIdentification { get; init; }

    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_hjmLha8uEfCx2aBifPEdRg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_hjmLh68uEfCx2aBifPEdRg")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Status of an individual meeting instruction cancellation request.
    /// </summary>
    [IsoId("_hjmLia8uEfCx2aBifPEdRg")]
    [DisplayName("Instruction Cancellation Status")]
    [IsoXmlTag("InstrCxlSts")]
    public required CancellationStatus35Choice_ InstructionCancellationStatus { get; init; }
}
