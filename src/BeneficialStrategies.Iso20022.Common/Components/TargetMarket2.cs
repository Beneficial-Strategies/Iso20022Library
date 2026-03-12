// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Target market criteria.
/// </summary>
[IsoId("_nA4kgaDsEequlaOyi6MUhw")]
[DisplayName("Target Market")]
public partial record TargetMarket2
{
    #nullable enable
    
    /// <summary>
    /// Date to which the target market data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01000.
    /// </summary>
    [IsoId("_uJoI0KDsEequlaOyi6MUhw")]
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReferenceDate { get; init; } 
    
    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_nWm84aDsEequlaOyi6MUhw")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType2? InvestorType { get; init; } 
    
    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_nWm846DsEequlaOyi6MUhw")]
    [DisplayName("Knowledge And Or Experience")]
    [IsoXmlTag("KnwldgAndOrExprnc")]
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; } 
    
    /// <summary>
    /// Investor’s ability to bear losses.
    /// </summary>
    [IsoId("_nWm85aDsEequlaOyi6MUhw")]
    [DisplayName("Ability To Bear Losses")]
    [IsoXmlTag("AbltyToBearLosses")]
    public LossBearing2? AbilityToBearLosses { get; init; } 
    
    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_nWm856DsEequlaOyi6MUhw")]
    [DisplayName("Risk Tolerance")]
    [IsoXmlTag("RskTlrnce")]
    public RiskTolerance1? RiskTolerance { get; init; } 
    
    /// <summary>
    /// Investor’s investment requirements.
    /// </summary>
    [IsoId("_nWm86aDsEequlaOyi6MUhw")]
    [DisplayName("Client Objectives And Needs")]
    [IsoXmlTag("ClntObjctvsAndNeeds")]
    public InvestorRequirements2? ClientObjectivesAndNeeds { get; init; } 
    
    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_nWm866DsEequlaOyi6MUhw")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public OtherTargetMarket1? Other { get; init; } 
    
    
    #nullable disable
    
}
