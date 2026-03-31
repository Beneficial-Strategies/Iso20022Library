// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejected Status Reason58.
/// </summary>
[IsoId("_Uo2Nz3SdEe6VWZz2tTgENw")]
[DisplayName("Rejected Status Reason58")]
public record RejectedStatusReason58
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoRestrictedFINMax210Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Reason Code.
    /// </summary>
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason61Choice_ ReasonCode { get; init; }
}
