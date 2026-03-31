// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the status (that is accept or reject) of the CollateralManagementCancellationRequest message.
/// </summary>
[IsoId("_mgp44StIEeyOa655cLd-DQ")]
[DisplayName("Collateral Cancellation Status")]
public record CollateralCancellationStatus2
{
    /// <summary>
    /// Allows to provide a cancellation status using a code or a proprietary status.
    /// </summary>
    [IsoId("_m7VCsytIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Status Code")]
    [IsoXmlTag("CollStsCd")]
    public required Status4Code CollateralStatusCode { get; init; }

    /// <summary>
    /// Provides additional information on the status of the CollateralManagementCancellationRequest message.
    /// </summary>
    [IsoId("_m7VCtStIEeyOa655cLd-DQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Provides rejection reason and optionaly additional information.
    /// </summary>
    [IsoId("_m7VCtytIEeyOa655cLd-DQ")]
    [DisplayName("Rejection Details")]
    [IsoXmlTag("RjctnDtls")]
    public RejectionStatus3? RejectionDetails { get; init; }
}
