// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Target market criteria.
/// </summary>
[IsoId("_z1KXQDQpEeifw8iDiyZLmQ")]
[DisplayName("Target Market")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TargetMarket1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_CQTyMDQqEeifw8iDiyZLmQ")]
    [DisplayName("Investor Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTp")]
    #endif
    [IsoXmlTag("InvstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorType1? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorType1? InvestorType { get; init; } 
    #else
    public InvestorType1? InvestorType { get; set; } 
    #endif
    
    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_EkCIUDQqEeifw8iDiyZLmQ")]
    [DisplayName("Knowledge And Or Experience")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KnwldgAndOrExprnc")]
    #endif
    [IsoXmlTag("KnwldgAndOrExprnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; init; } 
    #else
    public InvestorKnowledge1? KnowledgeAndOrExperience { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s ability to bear losses.
    /// </summary>
    [IsoId("_GIdvgDQqEeifw8iDiyZLmQ")]
    [DisplayName("Ability To Bear Losses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AbltyToBearLosses")]
    #endif
    [IsoXmlTag("AbltyToBearLosses")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LossBearing1? AbilityToBearLosses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LossBearing1? AbilityToBearLosses { get; init; } 
    #else
    public LossBearing1? AbilityToBearLosses { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_I7IrcDQqEeifw8iDiyZLmQ")]
    [DisplayName("Risk Tolerance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskTlrnce")]
    #endif
    [IsoXmlTag("RskTlrnce")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskTolerance1? RiskTolerance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskTolerance1? RiskTolerance { get; init; } 
    #else
    public RiskTolerance1? RiskTolerance { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s investment requirements.
    /// </summary>
    [IsoId("_Kap9cDQqEeifw8iDiyZLmQ")]
    [DisplayName("Client Objectives And Needs")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntObjctvsAndNeeds")]
    #endif
    [IsoXmlTag("ClntObjctvsAndNeeds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; init; } 
    #else
    public InvestorRequirements1? ClientObjectivesAndNeeds { get; set; } 
    #endif
    
    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_ykOcsD8SEeih8-WNbS6hbA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTargetMarket1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTargetMarket1? Other { get; init; } 
    #else
    public OtherTargetMarket1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
