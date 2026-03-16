// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for rejecting a RequestToCancelPayment.
/// </summary>
[IsoId("_T9gVYtp-Ed-ak6NoX_4Aeg_1111011316")]
[DisplayName("Rejected Cancellation Justification")]
public record RejectedCancellationJustification
{
    /// <summary>
    /// Justification for the rejection of the cancellation.
    /// </summary>
    [IsoId("_T9gVY9p-Ed-ak6NoX_4Aeg_173058696")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PaymentCancellationRejection1Code ReasonCode { get; init; }

    /// <summary>
    /// Free text justification for rejecting a cancellation.
    /// </summary>
    [IsoId("_T9gVZNp-Ed-ak6NoX_4Aeg_1563536447")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Reason { get; init; }
}
