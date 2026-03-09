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
/// Specifies the aggregated data of settlement fails instructions.
/// </summary>
[IsoId("_nUbWwSGkEeqlG_HhjTmcZg")]
[DisplayName("Settlement Fails Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsData4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsData4( SettlementTotalData1 reqTotal,SettlementFailureReason3 reqFailureReason,SettlementFailsDerogation1 reqEligibleForDerogation )
    {
        Total = reqTotal;
        FailureReason = reqFailureReason;
        EligibleForDerogation = reqEligibleForDerogation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total of all types of settlement transactions.
    /// </summary>
    [IsoId("_nWXQcSGkEeqlG_HhjTmcZg")]
    [DisplayName("Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ttl")]
    #endif
    [IsoXmlTag("Ttl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1 Total { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1 Total { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1 Total { get; init; } 
    #else
    public SettlementTotalData1 Total { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the reason for the settlement fails.
    /// </summary>
    [IsoId("_nWXQcyGkEeqlG_HhjTmcZg")]
    [DisplayName("Failure Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FailrRsn")]
    #endif
    [IsoXmlTag("FailrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailureReason3 FailureReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailureReason3 FailureReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailureReason3 FailureReason { get; init; } 
    #else
    public SettlementFailureReason3 FailureReason { get; set; } 
    #endif
    
    /// <summary>
    /// Eligible for derogation under the local regulation on settlement discipline, including the justification.
    /// </summary>
    [IsoId("_nWXQdSGkEeqlG_HhjTmcZg")]
    [DisplayName("Eligible For Derogation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblForDrgtn")]
    #endif
    [IsoXmlTag("ElgblForDrgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDerogation1 EligibleForDerogation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDerogation1 EligibleForDerogation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDerogation1 EligibleForDerogation { get; init; } 
    #else
    public SettlementFailsDerogation1 EligibleForDerogation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
