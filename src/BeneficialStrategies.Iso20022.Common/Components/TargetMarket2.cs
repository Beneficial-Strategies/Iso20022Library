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
[IsoId("_nA4kgaDsEequlaOyi6MUhw")]
[DisplayName("Target Market")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TargetMarket2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date to which the target market data refers. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 01000.
    /// </summary>
    [IsoId("_uJoI0KDsEequlaOyi6MUhw")]
    [DisplayName("Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefDt")]
    #endif
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ReferenceDate { get; init; } 
    #else
    public System.DateOnly? ReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Investor for which the financial instrument is targeted.
    /// </summary>
    [IsoId("_nWm84aDsEequlaOyi6MUhw")]
    [DisplayName("Investor Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrTp")]
    #endif
    [IsoXmlTag("InvstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorType2? InvestorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorType2? InvestorType { get; init; } 
    #else
    public InvestorType2? InvestorType { get; set; } 
    #endif
    
    /// <summary>
    /// Knowledge and/or experience of the investor.
    /// </summary>
    [IsoId("_nWm846DsEequlaOyi6MUhw")]
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
    [IsoId("_nWm85aDsEequlaOyi6MUhw")]
    [DisplayName("Ability To Bear Losses")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AbltyToBearLosses")]
    #endif
    [IsoXmlTag("AbltyToBearLosses")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LossBearing2? AbilityToBearLosses { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LossBearing2? AbilityToBearLosses { get; init; } 
    #else
    public LossBearing2? AbilityToBearLosses { get; set; } 
    #endif
    
    /// <summary>
    /// Investor’s tolerance to risk.
    /// </summary>
    [IsoId("_nWm856DsEequlaOyi6MUhw")]
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
    [IsoId("_nWm86aDsEequlaOyi6MUhw")]
    [DisplayName("Client Objectives And Needs")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntObjctvsAndNeeds")]
    #endif
    [IsoXmlTag("ClntObjctvsAndNeeds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorRequirements2? ClientObjectivesAndNeeds { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorRequirements2? ClientObjectivesAndNeeds { get; init; } 
    #else
    public InvestorRequirements2? ClientObjectivesAndNeeds { get; set; } 
    #endif
    
    /// <summary>
    /// Other target market parameter.
    /// </summary>
    [IsoId("_nWm866DsEequlaOyi6MUhw")]
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
