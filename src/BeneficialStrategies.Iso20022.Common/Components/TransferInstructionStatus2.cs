// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction status.
/// </summary>
[IsoId("_RQWypdp-Ed-ak6NoX_4Aeg_-1720727029")]
[DisplayName("Transfer Instruction Status")]
public record TransferInstructionStatus2
{
    /// <summary>
    /// Status of the transfer is accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_RQWyptp-Ed-ak6NoX_4Aeg_-1720727003")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferStatus2Code Status { get; init; }

    /// <summary>
    /// Reason for the status.
    /// </summary>
    [IsoId("_RQWyp9p-Ed-ak6NoX_4Aeg_919583835")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; }
}
