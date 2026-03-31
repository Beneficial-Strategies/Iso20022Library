// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics used to describe a hypothetical scenario designed to test the value of a portfolio of financial instruments under such hypothetical scenario.
/// </summary>
[IsoId("_b-6ZMKsrEeayv9XxdmMwKQ")]
[DisplayName("Scenario Definition")]
public record ScenarioDefinition1
{
    /// <summary>
    /// Identification of the stress scenario.
    /// </summary>
    [IsoId("_ou7vEKsrEeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification165 Identification { get; init; }

    /// <summary>
    /// Indicates whether the scenario is based on a historical event or a hypothetical scenario.
    /// </summary>
    [IsoId("_xLvt4KssEeayv9XxdmMwKQ")]
    [DisplayName("Scenario Type")]
    [IsoXmlTag("ScnroTp")]
    public required ScenarioType1Code ScenarioType { get; init; }

    /// <summary>
    /// Indicates how the scenario stresses the curve.
    /// </summary>
    [IsoId("_rr6ysKstEeayv9XxdmMwKQ")]
    [DisplayName("Strategy Stress Type")]
    [IsoXmlTag("StrtgyStrssTp")]
    public required StrategyStressType1Code StrategyStressType { get; init; }

    /// <summary>
    /// Information relating to the one / two major representative product(s).
    /// </summary>
    [IsoId("_2AzGYKsuEeayv9XxdmMwKQ")]
    [DisplayName("Stress Item")]
    [IsoXmlTag("StrssItm")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<StressItem1> StressItem { get; init; } = [];

    /// <summary>
    /// Long description of the scenario.
    /// </summary>
    [IsoId("_QIx0kMBnEeak3I7j2hsibw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000, MinimumLength = 1)]
    public IsoMax2000Text? Description { get; init; }
}
