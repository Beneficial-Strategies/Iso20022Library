// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a standing instruction cancellation request.
/// </summary>
[IsoId("_Rk6tZNp-Ed-ak6NoX_4Aeg_1198444441")]
[DisplayName("Corporate Action Standing Instruction Cancellation Rejection Status")]
public record CorporateActionStandingInstructionCancellationRejectionStatus1
{
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason10FormatChoice_> Reason { get; init; } = [];

    // ID for the above is _Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rk6tZtp-Ed-ak6NoX_4Aeg_1289872650")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
