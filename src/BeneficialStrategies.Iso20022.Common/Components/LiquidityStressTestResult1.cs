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
/// Results of a scenario used to test whether a legal entity or other financial construct has sufficient liquid resources to meet its obligations as they arise.
/// </summary>
[IsoId("_PwgG8LJPEeaYqc4G3TTwhA")]
[DisplayName("Liquidity Stress Test Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidityStressTestResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidityStressTestResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidityStressTestResult1( System.String reqIdentification,CoverTwoDefaulters1 reqScenarioDefaulters )
    {
        Identification = reqIdentification;
        ScenarioDefaulters = reqScenarioDefaulters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// CCP’s internal unique identifier of the stress scenario that generates the reported liquidity need.
    /// </summary>
    [IsoId("_W2YkgLJPEeaYqc4G3TTwhA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of assumed defaulters under the stress scenario.
    /// </summary>
    [IsoId("_fBdIgLJPEeaYqc4G3TTwhA")]
    [DisplayName("Scenario Defaulters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScnroDfltrs")]
    #endif
    [IsoXmlTag("ScnroDfltrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CoverTwoDefaulters1 ScenarioDefaulters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CoverTwoDefaulters1 ScenarioDefaulters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CoverTwoDefaulters1 ScenarioDefaulters { get; init; } 
    #else
    public CoverTwoDefaulters1 ScenarioDefaulters { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the stressed resources and liquidity requirements under the liquidity stress test. The balance of resources are reported as of day ‘T‐1’. The requirements and any flows of resources are reported on their respective day from day ’ T’ to ‘T+5&apos;.
    /// </summary>
    [IsoId("_E8PuQLbxEeaqL_M7XFD7PQ")]
    [DisplayName("Liquidity Required And Available")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdtyReqrdAndAvlbl")]
    #endif
    [IsoXmlTag("LqdtyReqrdAndAvlbl")]
    [MinLength(6)]
    [MaxLength(6)]
    public ValueList<LiquidityRequiredAndAvailable1> LiquidityRequiredAndAvailable { get; init; } = new ValueList<LiquidityRequiredAndAvailable1>(){};
    
    
    #nullable disable
    
}
