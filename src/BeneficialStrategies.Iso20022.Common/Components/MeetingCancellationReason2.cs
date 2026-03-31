// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for cancelling a meeting.
/// </summary>
[IsoId("_RCMa19p-Ed-ak6NoX_4Aeg_1000768570")]
[DisplayName("Meeting Cancellation Reason")]
public record MeetingCancellationReason2
{
    /// <summary>
    /// Reason for cancelling a meeting.
    /// </summary>
    [IsoId("_RCMa2Np-Ed-ak6NoX_4Aeg_1092600790")]
    [DisplayName("Cancellation Reason Code")]
    [IsoXmlTag("CxlRsnCd")]
    public MeetingCancellationReason1Choice_? CancellationReasonCode { get; init; }

    /// <summary>
    /// Provides more information on the reason for cancelling a meeting in free format form.
    /// </summary>
    [IsoId("_RCWL0Np-Ed-ak6NoX_4Aeg_1000768631")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? CancellationReason { get; init; }
}
