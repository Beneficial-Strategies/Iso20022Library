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
/// Specifies the reason for the settlement fails as defined in the relevant regulation.
/// </summary>
[IsoId("_QHUzx76YEemHTLTzJg7M-A")]
[DisplayName("Settlement Failure Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailureReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailureReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailureReason2( System.String reqMainReasons,System.String reqEfficiencyImprovement )
    {
        MainReasons = reqMainReasons;
        EfficiencyImprovement = reqEfficiencyImprovement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Main reasons for settlement fails during the reporting period.
    /// </summary>
    [IsoId("_QMoKg76YEemHTLTzJg7M-A")]
    [DisplayName("Main Reasons")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainRsns")]
    #endif
    [IsoXmlTag("MainRsns")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2048Text MainReasons { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MainReasons { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MainReasons { get; init; } 
    #else
    public System.String MainReasons { get; set; } 
    #endif
    
    /// <summary>
    /// Measures to improve settlement efficiency.
    /// </summary>
    [IsoId("_QMoKhb6YEemHTLTzJg7M-A")]
    [DisplayName("Efficiency Improvement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EffcncyImprvmt")]
    #endif
    [IsoXmlTag("EffcncyImprvmt")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2048Text EfficiencyImprovement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EfficiencyImprovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EfficiencyImprovement { get; init; } 
    #else
    public System.String EfficiencyImprovement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
