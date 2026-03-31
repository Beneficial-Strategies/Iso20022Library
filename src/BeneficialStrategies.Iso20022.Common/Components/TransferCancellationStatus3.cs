// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer cancellation status is accepted or sent to next party.
/// </summary>
[IsoId("_5_gzYZM6EemKz5EOjv82iQ")]
[DisplayName("Transfer Cancellation Status")]
public record TransferCancellationStatus3
{
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    [IsoId("_6UCR45M6EemKz5EOjv82iQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CancellationStatus5Code Status { get; init; }

    /// <summary>
    /// Reason for the status.
    /// </summary>
    [IsoId("_6UCR5ZM6EemKz5EOjv82iQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; }
}
