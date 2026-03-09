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
/// Obligations of a legal entity or other financial construct that must be met in cash and the resources such legal entity of financial construct has available to meet those obligations.
/// </summary>
[IsoId("_IW-vwLbxEeaqL_M7XFD7PQ")]
[DisplayName("Liquidity Required And Available")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidityRequiredAndAvailable1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidityRequiredAndAvailable1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidityRequiredAndAvailable1( LiquidResources1 reqLiquidResources,SettlementDate6Code reqLiquidityHorizon,StressLiquidResourceRequirement1 reqStressLiquidResourceRequirement )
    {
        LiquidResources = reqLiquidResources;
        LiquidityHorizon = reqLiquidityHorizon;
        StressLiquidResourceRequirement = reqStressLiquidResourceRequirement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Flows of resources that are estimated to be available to the CCP on each day of the reporting horizon. That is, balances as of close‐of‐business on day ‘T‐1’, then flows from day ‘T’ of the default to ‘T+5 onwards’.
    /// </summary>
    [IsoId("_UdHbI7bxEeaqL_M7XFD7PQ")]
    [DisplayName("Liquid Resources")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdRsrcs")]
    #endif
    [IsoXmlTag("LqdRsrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LiquidResources1 LiquidResources { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LiquidResources1 LiquidResources { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidResources1 LiquidResources { get; init; } 
    #else
    public LiquidResources1 LiquidResources { get; set; } 
    #endif
    
    /// <summary>
    /// Period of reporting of liquidity requirements and resources relative to a set date.
    /// </summary>
    [IsoId("_UdHbJLbxEeaqL_M7XFD7PQ")]
    [DisplayName("Liquidity Horizon")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdtyHrzn")]
    #endif
    [IsoXmlTag("LqdtyHrzn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate6Code LiquidityHorizon { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDate6Code LiquidityHorizon { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate6Code LiquidityHorizon { get; init; } 
    #else
    public SettlementDate6Code LiquidityHorizon { get; set; } 
    #endif
    
    /// <summary>
    /// Total expected liquidity need under Scenario ID for the relevant currency over each day of the horizon from day T onwards.
    /// </summary>
    [IsoId("_UmNQQbbyEeaqL_M7XFD7PQ")]
    [DisplayName("Stress Liquid Resource Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrssLqdRsrcRqrmnt")]
    #endif
    [IsoXmlTag("StrssLqdRsrcRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StressLiquidResourceRequirement1 StressLiquidResourceRequirement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StressLiquidResourceRequirement1 StressLiquidResourceRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StressLiquidResourceRequirement1 StressLiquidResourceRequirement { get; init; } 
    #else
    public StressLiquidResourceRequirement1 StressLiquidResourceRequirement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
