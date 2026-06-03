// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Recommended actions as result of risk assessment.
/// </summary>
[IsoId("_RLBigRNaEfC1ZfCQz0xB3g")]
[DisplayName("Recommendation Action2")]
public record RecommendationAction2
{
    /// <summary>
    /// Recommended action based on risk assessment.
    /// </summary>
    [IsoId("_RSYHsRNaEfC1ZfCQz0xB3g")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public RecommendedActionCode1? Action { get; init; }

    /// <summary>
    /// Additional details of recommended action or other recommended action.
    /// </summary>
    [IsoId("_RSYHtRNaEfC1ZfCQz0xB3g")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public IsoMax256Text? Details { get; init; }
}
