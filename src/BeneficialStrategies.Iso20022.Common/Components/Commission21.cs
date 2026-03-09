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
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_GK8bkQavEeS3lpTattq7hg")]
[DisplayName("Commission")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Commission21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Commission21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Commission21( CommissionType5Choice_ reqCommissionType,AmountOrRate3Choice_ reqCommissionApplied )
    {
        CommissionType = reqCommissionType;
        CommissionApplied = reqCommissionApplied;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of commission.
    /// </summary>
    [IsoId("_ZCl3AAavEeS3lpTattq7hg")]
    [DisplayName("Commission Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnTp")]
    #endif
    [IsoXmlTag("ComssnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommissionType5Choice_ CommissionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommissionType5Choice_ CommissionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommissionType5Choice_ CommissionType { get; init; } 
    #else
    public CommissionType5Choice_ CommissionType { get; set; } 
    #endif
    
    /// <summary>
    /// Commission amount or commission rate applied.
    /// </summary>
    [IsoId("_1HtHkAavEeS3lpTattq7hg")]
    [DisplayName("Commission Applied")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnApld")]
    #endif
    [IsoXmlTag("ComssnApld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrRate3Choice_ CommissionApplied { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrRate3Choice_ CommissionApplied { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrRate3Choice_ CommissionApplied { get; init; } 
    #else
    public AmountOrRate3Choice_ CommissionApplied { get; set; } 
    #endif
    
    
    #nullable disable
    
}
