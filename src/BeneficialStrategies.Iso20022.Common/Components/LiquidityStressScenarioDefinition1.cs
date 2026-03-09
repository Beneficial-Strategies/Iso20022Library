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
/// Attributes and information that describe a scenario used to test whether a legal entity or other financial construct has sufficient liquid resources to meet its obligations as they arise.
/// </summary>
[IsoId("_ERnlwLDDEeaSl6vJk5Bd8w")]
[DisplayName("Liquidity Stress Scenario Definition")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidityStressScenarioDefinition1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidityStressScenarioDefinition1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidityStressScenarioDefinition1( GenericIdentification168 reqIdentification,System.String reqDescription,string reqStressCurrency )
    {
        Identification = reqIdentification;
        Description = reqDescription;
        StressCurrency = reqStressCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// CCP’s internal unique identifier of the stress scenario that generates the reported liquidity need.
    /// </summary>
    [IsoId("_NlwDkLDDEeaSl6vJk5Bd8w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification168 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification168 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification168 Identification { get; init; } 
    #else
    public GenericIdentification168 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the method and assumptions used for estimating operational outflows.
    /// </summary>
    [IsoId("_RlWFoLDDEeaSl6vJk5Bd8w")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2000Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    /// <summary>
    /// CCP’s internal classification of stress scenario type.
    /// </summary>
    [IsoId("_duPKELDDEeaSl6vJk5Bd8w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Stress currency, or if aggregate, report ‘XLL’.
    /// </summary>
    [IsoId("_WXiXYLDFEeaSl6vJk5Bd8w")]
    [DisplayName("Stress Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrssCcy")]
    #endif
    [IsoXmlTag("StrssCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode StressCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string StressCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string StressCurrency { get; init; } 
    #else
    public string StressCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
