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
/// Characteristics used to describe a hypothetical scenario designed to test the value of a portfolio of financial instruments under such hypothetical scenario.
/// </summary>
[IsoId("_b-6ZMKsrEeayv9XxdmMwKQ")]
[DisplayName("Scenario Definition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ScenarioDefinition1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ScenarioDefinition1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ScenarioDefinition1( GenericIdentification165 reqIdentification,ScenarioType1Code reqScenarioType,StrategyStressType1Code reqStrategyStressType )
    {
        Identification = reqIdentification;
        ScenarioType = reqScenarioType;
        StrategyStressType = reqStrategyStressType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the stress scenario.
    /// </summary>
    [IsoId("_ou7vEKsrEeayv9XxdmMwKQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 Identification { get; init; } 
    #else
    public GenericIdentification165 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the scenario is based on a historical event or a hypothetical scenario.
    /// </summary>
    [IsoId("_xLvt4KssEeayv9XxdmMwKQ")]
    [DisplayName("Scenario Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScnroTp")]
    #endif
    [IsoXmlTag("ScnroTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ScenarioType1Code ScenarioType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ScenarioType1Code ScenarioType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ScenarioType1Code ScenarioType { get; init; } 
    #else
    public ScenarioType1Code ScenarioType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how the scenario stresses the curve.
    /// </summary>
    [IsoId("_rr6ysKstEeayv9XxdmMwKQ")]
    [DisplayName("Strategy Stress Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtgyStrssTp")]
    #endif
    [IsoXmlTag("StrtgyStrssTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StrategyStressType1Code StrategyStressType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StrategyStressType1Code StrategyStressType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StrategyStressType1Code StrategyStressType { get; init; } 
    #else
    public StrategyStressType1Code StrategyStressType { get; set; } 
    #endif
    
    /// <summary>
    /// Information relating to the one / two major representative product(s).
    /// </summary>
    [IsoId("_2AzGYKsuEeayv9XxdmMwKQ")]
    [DisplayName("Stress Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrssItm")]
    #endif
    [IsoXmlTag("StrssItm")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<StressItem1> StressItem { get; init; } = new ValueList<StressItem1>(){};
    
    /// <summary>
    /// Long description of the scenario.
    /// </summary>
    [IsoId("_QIx0kMBnEeak3I7j2hsibw")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
