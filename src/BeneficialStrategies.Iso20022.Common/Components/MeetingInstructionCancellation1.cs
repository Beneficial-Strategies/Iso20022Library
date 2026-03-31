// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the cancellation request message requesting cancellation of individual instruction(s).
/// </summary>
[IsoId("_mbPBQDUAEe2tRf29bleifQ")]
[DisplayName("Meeting Instruction Cancellation")]
public record MeetingInstructionCancellation1
{
    /// <summary>
    /// Identification of the meeting instruction cancellation request message containing the individual instruction(s) for which the cancellation was requested.
    /// </summary>
    [IsoId("_5s5fMDUAEe2tRf29bleifQ")]
    [DisplayName("Meeting Instruction Cancellation Request Identification")]
    [IsoXmlTag("MtgInstrCxlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MeetingInstructionCancellationRequestIdentification { get; init; }

    /// <summary>
    /// Identification of the individual instruction for which the cancellation was requested.
    /// </summary>
    [IsoId("__j9ZMDUAEe2tRf29bleifQ")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }
}
