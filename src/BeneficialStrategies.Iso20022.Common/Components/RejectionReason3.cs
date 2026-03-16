// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason to reject the message.
/// </summary>
[IsoId("_RPdazNp-Ed-ak6NoX_4Aeg_680923273")]
[DisplayName("Rejection Reason")]
public record RejectionReason3
{
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_RPmksNp-Ed-ak6NoX_4Aeg_680923315")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MessageRejectedReason1Code Reason { get; init; }

    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    [IsoId("_RPmksdp-Ed-ak6NoX_4Aeg_680923358")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Linked previous reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_RPmkstp-Ed-ak6NoX_4Aeg_680923436")]
    [DisplayName("Linked Message Previous Reference")]
    [IsoXmlTag("LkdMsgPrvsRef")]
    public AdditionalReference3? LinkedMessagePreviousReference { get; init; }

    /// <summary>
    /// Linked other reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_RPmks9p-Ed-ak6NoX_4Aeg_680923471")]
    [DisplayName("Linked Message Other Reference")]
    [IsoXmlTag("LkdMsgOthrRef")]
    public AdditionalReference3? LinkedMessageOtherReference { get; init; }

    /// <summary>
    /// Linked related reference that is invalid or unrecognised, of the message being rejected.
    /// </summary>
    [IsoId("_RPmktNp-Ed-ak6NoX_4Aeg_680923376")]
    [DisplayName("Linked Message Related Reference")]
    [IsoXmlTag("LkdMsgRltdRef")]
    public AdditionalReference3? LinkedMessageRelatedReference { get; init; }
}
