// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the business status of a cancellation request message.
/// </summary>
[IsoId("_RXzed9p-Ed-ak6NoX_4Aeg_-377525821")]
[DisplayName("Cancellation Status Information")]
public record CancellationStatusInformation1
{
    /// <summary>
    /// Information on the business status of the cancellation.
    /// </summary>
    [IsoId("_RXzeeNp-Ed-ak6NoX_4Aeg_-377525819")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required CancellationStatus4Code Status { get; init; }

    /// <summary>
    /// The reason for the cancellation status.
    /// </summary>
    [IsoId("_RX8oYNp-Ed-ak6NoX_4Aeg_-377525790")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReason4Choice_? StatusReason { get; init; }

    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_RX8oYdp-Ed-ak6NoX_4Aeg_-377525729")]
    [DisplayName("Additional Status Reason Information")]
    [IsoXmlTag("AddtlStsRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalStatusReasonInformation { get; init; }
}
