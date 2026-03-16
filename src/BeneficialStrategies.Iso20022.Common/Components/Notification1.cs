// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information to be communicated to other parties in the transaction.
/// </summary>
[IsoId("_RaowA9p-Ed-ak6NoX_4Aeg_1225299644")]
[DisplayName("Notification")]
public record Notification1
{
    /// <summary>
    /// Type of the notification.
    /// </summary>
    [IsoId("_RaowBNp-Ed-ak6NoX_4Aeg_1277939893")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required NotificationType1Code Type { get; init; }

    /// <summary>
    /// Additional and important information to qualify and describe the notification.
    /// </summary>
    [IsoId("_RaowBdp-Ed-ak6NoX_4Aeg_1306568538")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text AdditionalInformation { get; init; }
}
