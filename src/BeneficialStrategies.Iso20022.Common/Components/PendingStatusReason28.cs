// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pending Status Reason28.
/// </summary>
[IsoId("_Uqcwj3SdEe6VWZz2tTgENw")]
[DisplayName("Pending Status Reason28")]
public record PendingStatusReason28
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Reason Code.
    /// </summary>
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingReason68Choice_ ReasonCode { get; init; }
}
