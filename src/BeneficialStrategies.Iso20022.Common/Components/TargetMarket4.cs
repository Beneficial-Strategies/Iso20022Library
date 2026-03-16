// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Target Market4.
/// </summary>
[IsoId("_q6sQAcQXEe2pvZQ_33Qz1Q")]
[DisplayName("Target Market4")]
public partial record TargetMarket4
{
    #nullable enable

    /// <summary>
    /// Ability To Bear Losses.
    /// </summary>
    [DisplayName("Ability To Bear Losses")]
    [IsoXmlTag("AbltyToBearLosses")]
    public LossBearing2? AbilityToBearLosses { get; init; } 

    /// <summary>
    /// Client Objectives And Needs.
    /// </summary>
    [DisplayName("Client Objectives And Needs")]
    [IsoXmlTag("ClntObjctvsAndNeeds")]
    public InvestorRequirements4? ClientObjectivesAndNeeds { get; init; } 

    /// <summary>
    /// Investor Type.
    /// </summary>
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType2? InvestorType { get; init; } 

    /// <summary>
    /// Knowledge And Or Experience.
    /// </summary>
    [DisplayName("Knowledge And Or Experience")]
    [IsoXmlTag("KnwldgAndOrExprnc")]
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; } 

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherTargetMarket1> Other { get; init; } = [];

    /// <summary>
    /// Reference Date.
    /// </summary>
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    public IsoISODate? ReferenceDate { get; init; } 

    /// <summary>
    /// Risk Tolerance.
    /// </summary>
    [DisplayName("Risk Tolerance")]
    [IsoXmlTag("RskTlrnce")]
    public RiskTolerance1? RiskTolerance { get; init; } 

    
    #nullable disable
    
}
