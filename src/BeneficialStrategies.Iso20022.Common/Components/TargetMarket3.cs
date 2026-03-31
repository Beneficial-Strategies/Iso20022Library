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
[IsoId("_XXkGEc0SEeuAE-cYsQdwHQ")]
[DisplayName("Target Market")]
public record TargetMarket3
{
    /// <summary>
    /// Date to which the target market data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01000.
    /// </summary>
    [IsoId("_Xtt8Qc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReferenceDate { get; init; }

    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_XtujUc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType2? InvestorType { get; init; }

    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_XtujU80SEeuAE-cYsQdwHQ")]
    [DisplayName("Knowledge And Or Experience")]
    [IsoXmlTag("KnwldgAndOrExprnc")]
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; }

    /// <summary>
    /// Investor’s ability to bear losses.
    /// </summary>
    [IsoId("_XtujVc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Ability To Bear Losses")]
    [IsoXmlTag("AbltyToBearLosses")]
    public LossBearing2? AbilityToBearLosses { get; init; }

    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_XtujV80SEeuAE-cYsQdwHQ")]
    [DisplayName("Risk Tolerance")]
    [IsoXmlTag("RskTlrnce")]
    public RiskTolerance1? RiskTolerance { get; init; }

    /// <summary>
    /// Investor’s investment requirements.
    /// </summary>
    [IsoId("_XtujWc0SEeuAE-cYsQdwHQ")]
    [DisplayName("Client Objectives And Needs")]
    [IsoXmlTag("ClntObjctvsAndNeeds")]
    public InvestorRequirements3? ClientObjectivesAndNeeds { get; init; }

    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_XtujW80SEeuAE-cYsQdwHQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherTargetMarket1> Other { get; init; } = [];
}
