// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scenario Definition2.
/// </summary>
[IsoId("_lf5NMTqlEe6GiucvqhDlFQ")]
[DisplayName("Scenario Definition2")]
public partial record ScenarioDefinition2
{
    #nullable enable

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax2000Text? Description { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification165 Identification { get; init; } 

    /// <summary>
    /// Scenario Type.
    /// </summary>
    [DisplayName("Scenario Type")]
    [IsoXmlTag("ScnroTp")]
    public required ScenarioType1Code ScenarioType { get; init; } 

    /// <summary>
    /// Strategy Stress Type.
    /// </summary>
    [DisplayName("Strategy Stress Type")]
    [IsoXmlTag("StrtgyStrssTp")]
    public required StrategyStressType1Code StrategyStressType { get; init; } 

    /// <summary>
    /// Stress Item.
    /// </summary>
    [DisplayName("Stress Item")]
    [IsoXmlTag("StrssItm")]
    public ValueList<StressItem1> StressItem { get; init; } = [];

    
    #nullable disable
    
}
