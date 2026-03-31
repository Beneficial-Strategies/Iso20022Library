// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin Portfolio4.
/// </summary>
[IsoId("_Unl0AbEtEe63r8FIfzOHCQ")]
[DisplayName("Margin Portfolio4")]
public record MarginPortfolio4
{
    /// <summary>
    /// Initial Margin Portfolio Code.
    /// </summary>
    [DisplayName("Initial Margin Portfolio Code")]
    [IsoXmlTag("InitlMrgnPrtflCd")]
    public PortfolioCode5Choice_? InitialMarginPortfolioCode { get; init; }

    /// <summary>
    /// Variation Margin Portfolio Code.
    /// </summary>
    [DisplayName("Variation Margin Portfolio Code")]
    [IsoXmlTag("VartnMrgnPrtflCd")]
    public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; }
}
