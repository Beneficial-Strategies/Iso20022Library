// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Target market criteria.
/// </summary>
[IsoId("_z1KXQDQpEeifw8iDiyZLmQ")]
[DisplayName("Target Market")]
public record TargetMarket1
{
    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_CQTyMDQqEeifw8iDiyZLmQ")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType1? InvestorType { get; init; }

    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_EkCIUDQqEeifw8iDiyZLmQ")]
    [DisplayName("Knowledge And Or Experience")]
    [IsoXmlTag("KnwldgAndOrExprnc")]
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; }

    /// <summary>
    /// Investor’s ability to bear losses.
    /// </summary>
    [IsoId("_GIdvgDQqEeifw8iDiyZLmQ")]
    [DisplayName("Ability To Bear Losses")]
    [IsoXmlTag("AbltyToBearLosses")]
    public LossBearing1? AbilityToBearLosses { get; init; }

    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_I7IrcDQqEeifw8iDiyZLmQ")]
    [DisplayName("Risk Tolerance")]
    [IsoXmlTag("RskTlrnce")]
    public RiskTolerance1? RiskTolerance { get; init; }

    /// <summary>
    /// Investor’s investment requirements.
    /// </summary>
    [IsoId("_Kap9cDQqEeifw8iDiyZLmQ")]
    [DisplayName("Client Objectives And Needs")]
    [IsoXmlTag("ClntObjctvsAndNeeds")]
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; init; }

    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_ykOcsD8SEeih8-WNbS6hbA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherTargetMarket1? Other { get; init; }
}
