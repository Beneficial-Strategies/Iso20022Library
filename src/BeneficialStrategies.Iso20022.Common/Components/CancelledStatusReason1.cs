// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a cancelled status.
/// </summary>
[IsoId("_Ux9RNdp-Ed-ak6NoX_4Aeg_-1476021532")]
[DisplayName("Cancelled Status Reason")]
public record CancelledStatusReason1
{
    /// <summary>
    /// Reason for a cancelled status in free format text.
    /// </summary>
    [IsoId("_UyGbENp-Ed-ak6NoX_4Aeg_-1476021506")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text AdditionalInformation { get; init; }
}
