// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Name and value of a parameter being returned.
/// </summary>
[IsoId("_SuwKEwEcEeCQm6a_G2yO_w_-358984797")]
[DisplayName("Report Parameter")]
public record ReportParameter1
{
    /// <summary>
    /// Name or type of the parameter being returned.
    /// </summary>
    [IsoId("_SuwKFAEcEeCQm6a_G2yO_w_1702915618")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; }

    /// <summary>
    /// Value of the parameter being returned.
    /// </summary>
    [IsoId("_SuwKFQEcEeCQm6a_G2yO_w_1720011327")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Value { get; init; }
}
