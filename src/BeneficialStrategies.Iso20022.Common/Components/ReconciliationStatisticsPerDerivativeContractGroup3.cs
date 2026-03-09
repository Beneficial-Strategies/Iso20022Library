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
/// Detailed statistics on derivatives submitted for reconciliation per group of derivative contract.
/// </summary>
[IsoId("_5fxLwVfcEeqZr5K1Woax-g")]
[DisplayName("Reconciliation Statistics Per Derivative Contract Group")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationStatisticsPerDerivativeContractGroup3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationStatisticsPerDerivativeContractGroup3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationStatisticsPerDerivativeContractGroup3( ReconciliationStatisticsPerDerivativeType3 reqOTC,ReconciliationStatisticsPerDerivativeType3 reqETD )
    {
        OTC = reqOTC;
        ETD = reqETD;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed statistics on privately traded over-the-counter derivatives.
    /// </summary>
    [IsoId("_53z4UVfcEeqZr5K1Woax-g")]
    [DisplayName("OTC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OTC")]
    #endif
    [IsoXmlTag("OTC")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationStatisticsPerDerivativeType3 OTC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationStatisticsPerDerivativeType3 OTC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationStatisticsPerDerivativeType3 OTC { get; init; } 
    #else
    public ReconciliationStatisticsPerDerivativeType3 OTC { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on exchange-traded derivatives.
    /// </summary>
    [IsoId("_53z4U1fcEeqZr5K1Woax-g")]
    [DisplayName("ETD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ETD")]
    #endif
    [IsoXmlTag("ETD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationStatisticsPerDerivativeType3 ETD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationStatisticsPerDerivativeType3 ETD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationStatisticsPerDerivativeType3 ETD { get; init; } 
    #else
    public ReconciliationStatisticsPerDerivativeType3 ETD { get; set; } 
    #endif
    
    
    #nullable disable
    
}
