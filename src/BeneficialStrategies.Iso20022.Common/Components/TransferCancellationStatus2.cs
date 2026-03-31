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
[IsoId("_RQWyqNp-Ed-ak6NoX_4Aeg_610595446")]
[DisplayName("Transfer Cancellation Status")]
public record TransferCancellationStatus2
{
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    [IsoId("_RQWyqdp-Ed-ak6NoX_4Aeg_610595465")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CancellationStatus2Code Status { get; init; }

    /// <summary>
    /// Reason for the status.
    /// </summary>
    [IsoId("_RQWyqtp-Ed-ak6NoX_4Aeg_1601533057")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; }
}
