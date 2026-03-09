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
/// Detailed statistics on reconciliation per type of derivative.
/// </summary>
[IsoId("_530fYVfcEeqZr5K1Woax-g")]
[DisplayName("Reconciliation Statistics Per Derivative Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationStatisticsPerDerivativeType3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationStatisticsPerDerivativeType3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationStatisticsPerDerivativeType3( DetailedReconciliationStatistics2 reqAllDerivatives,DetailedReconciliationStatistics2 reqOutstandingDerivatives )
    {
        AllDerivatives = reqAllDerivatives;
        OutstandingDerivatives = reqOutstandingDerivatives;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed statistics on reconciliation for all derivatives.
    /// </summary>
    [IsoId("_6PTLQVfcEeqZr5K1Woax-g")]
    [DisplayName("All Derivatives")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllDerivs")]
    #endif
    [IsoXmlTag("AllDerivs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailedReconciliationStatistics2 AllDerivatives { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailedReconciliationStatistics2 AllDerivatives { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedReconciliationStatistics2 AllDerivatives { get; init; } 
    #else
    public DetailedReconciliationStatistics2 AllDerivatives { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on reconciliation for outstanding derivatives.
    /// </summary>
    [IsoId("_6PTLQ1fcEeqZr5K1Woax-g")]
    [DisplayName("Outstanding Derivatives")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngDerivs")]
    #endif
    [IsoXmlTag("OutsdngDerivs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailedReconciliationStatistics2 OutstandingDerivatives { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailedReconciliationStatistics2 OutstandingDerivatives { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedReconciliationStatistics2 OutstandingDerivatives { get; init; } 
    #else
    public DetailedReconciliationStatistics2 OutstandingDerivatives { get; set; } 
    #endif
    
    
    #nullable disable
    
}
