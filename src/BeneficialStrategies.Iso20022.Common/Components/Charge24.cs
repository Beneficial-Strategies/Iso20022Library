// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the different types of freight charges associated with goods.
/// </summary>
[IsoId("_hrK_ERreEeOVR9VN6fAMUg")]
[DisplayName("Charge")]
public record Charge24
{
    /// <summary>
    /// Identifies whether the freight charges associated with the goods are &quot;prepaid&quot; or &quot;collect&quot;.
    /// </summary>
    [IsoId("_iDTyQRreEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FreightCharges1Code Type { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_iDTyQxreEeOVR9VN6fAMUg")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public ValueList<ChargesDetails3> Charges { get; init; } = [];
}
