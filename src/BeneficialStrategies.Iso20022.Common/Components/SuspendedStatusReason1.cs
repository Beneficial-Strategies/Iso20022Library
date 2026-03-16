// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a suspended status.
/// </summary>
[IsoId("_Uzce5dp-Ed-ak6NoX_4Aeg_-1152969325")]
[DisplayName("Suspended Status Reason")]
public record SuspendedStatusReason1
{
    /// <summary>
    /// Reason for a suspended status in structured form.
    /// </summary>
    [IsoId("_Uzce5tp-Ed-ak6NoX_4Aeg_-1152969306")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    [MinLength(1)]
    [MaxLength(3)]
    public SimpleValueList<SuspendedStatusReason2Code> Structured { get; init; } = [];

    /// <summary>
    /// Reason for a suspended status in free format text.
    /// </summary>
    [IsoId("_Uzce59p-Ed-ak6NoX_4Aeg_-1152969265")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
