// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation status.
/// </summary>
[IsoId("_U0fAuNp-Ed-ak6NoX_4Aeg_441136069")]
[DisplayName("Transfer Cancellation Status")]
public record TransferCancellationStatus
{
    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_U0oxsNp-Ed-ak6NoX_4Aeg_-604209866")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CancellationStatus1Code Status { get; init; }

    /// <summary>
    /// Additional information about the status in textual form.
    /// </summary>
    [IsoId("_U0oxsdp-Ed-ak6NoX_4Aeg_1202118767")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
