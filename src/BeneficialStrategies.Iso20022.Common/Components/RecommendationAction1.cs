// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Recommendation Action1.
/// </summary>
[IsoId("_OzOSkHG8Ee60F8I8TAMKmg")]
[DisplayName("Recommendation Action1")]
public record RecommendationAction1
{
    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ActionType8Code? Action { get; init; }

    /// <summary>
    /// Details.
    /// </summary>
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<IsoMax256Text> Details { get; init; } = [];

    /// <summary>
    /// Other Action.
    /// </summary>
    [DisplayName("Other Action")]
    [IsoXmlTag("OthrActn")]
    public IsoMax35Text? OtherAction { get; init; }
}
