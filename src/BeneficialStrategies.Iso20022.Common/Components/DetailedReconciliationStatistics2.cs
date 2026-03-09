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
/// Detailed statistics on reconciliation.
/// </summary>
[IsoId("_6PTLRVfcEeqZr5K1Woax-g")]
[DisplayName("Detailed Reconciliation Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedReconciliationStatistics2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedReconciliationStatistics2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedReconciliationStatistics2( System.UInt64 reqTotalAccepted,System.UInt64 reqTotalNotSubmittedToReconciliation,System.UInt64 reqTotalSingleSidedEEAUnpaired,System.UInt64 reqTotalSingleSidedEEAPaired,System.UInt64 reqTotalSingleSidedEEAMatched,System.UInt64 reqTotalDualSidedNonMatched,System.UInt64 reqTotalDualSidedMatched,System.UInt64 reqTotalSingleSidedNonEEA )
    {
        TotalAccepted = reqTotalAccepted;
        TotalNotSubmittedToReconciliation = reqTotalNotSubmittedToReconciliation;
        TotalSingleSidedEEAUnpaired = reqTotalSingleSidedEEAUnpaired;
        TotalSingleSidedEEAPaired = reqTotalSingleSidedEEAPaired;
        TotalSingleSidedEEAMatched = reqTotalSingleSidedEEAMatched;
        TotalDualSidedNonMatched = reqTotalDualSidedNonMatched;
        TotalDualSidedMatched = reqTotalDualSidedMatched;
        TotalSingleSidedNonEEA = reqTotalSingleSidedNonEEA;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Detailed statistics on derivatives accepted by trade repository since the beginning of reporting.
    /// </summary>
    [IsoId("_6lXh4VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAccptd")]
    #endif
    [IsoXmlTag("TtlAccptd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalAccepted { get; init; } 
    #else
    public System.UInt64 TotalAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on derivatives that are not single-sided non-EEA and are not included in to the inter trade repository reconciliation process due to lack of compliance with LEI or the UTI specifications.
    /// </summary>
    [IsoId("_6lXh41fcEeqZr5K1Woax-g")]
    [DisplayName("Total Not Submitted To Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNotSubmittdToRcncltn")]
    #endif
    [IsoXmlTag("TtlNotSubmittdToRcncltn")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalNotSubmittedToReconciliation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNotSubmittedToReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNotSubmittedToReconciliation { get; init; } 
    #else
    public System.UInt64 TotalNotSubmittedToReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on single-sided EEA unpaired derivatives.
    /// </summary>
    [IsoId("_6lXh5VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided EEA Unpaired")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSnglSddEEAUnprd")]
    #endif
    [IsoXmlTag("TtlSnglSddEEAUnprd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalSingleSidedEEAUnpaired { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalSingleSidedEEAUnpaired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalSingleSidedEEAUnpaired { get; init; } 
    #else
    public System.UInt64 TotalSingleSidedEEAUnpaired { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on single-sided EEA paired derivatives.
    /// </summary>
    [IsoId("_6lXh51fcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided EEA Paired")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSnglSddEEAPaird")]
    #endif
    [IsoXmlTag("TtlSnglSddEEAPaird")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalSingleSidedEEAPaired { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalSingleSidedEEAPaired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalSingleSidedEEAPaired { get; init; } 
    #else
    public System.UInt64 TotalSingleSidedEEAPaired { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on single-sided EEA matched derivatives.
    /// </summary>
    [IsoId("_6lXh6VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided EEA Matched")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSnglSddEEAMtchd")]
    #endif
    [IsoXmlTag("TtlSnglSddEEAMtchd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalSingleSidedEEAMatched { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalSingleSidedEEAMatched { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalSingleSidedEEAMatched { get; init; } 
    #else
    public System.UInt64 TotalSingleSidedEEAMatched { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on dual-sided non-matched derivatives.
    /// </summary>
    [IsoId("_6lXh61fcEeqZr5K1Woax-g")]
    [DisplayName("Total Dual Sided Non Matched")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDualSddNonMtchd")]
    #endif
    [IsoXmlTag("TtlDualSddNonMtchd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalDualSidedNonMatched { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalDualSidedNonMatched { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalDualSidedNonMatched { get; init; } 
    #else
    public System.UInt64 TotalDualSidedNonMatched { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on dual-sided matched derivatives.
    /// </summary>
    [IsoId("_6lXh7VfcEeqZr5K1Woax-g")]
    [DisplayName("Total Dual Sided Matched")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDualSddMtchd")]
    #endif
    [IsoXmlTag("TtlDualSddMtchd")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalDualSidedMatched { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalDualSidedMatched { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalDualSidedMatched { get; init; } 
    #else
    public System.UInt64 TotalDualSidedMatched { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed statistics on single-sided non-EEA derivatives.
    /// </summary>
    [IsoId("_6lXh71fcEeqZr5K1Woax-g")]
    [DisplayName("Total Single Sided Non EEA")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSnglSddNonEEA")]
    #endif
    [IsoXmlTag("TtlSnglSddNonEEA")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber TotalSingleSidedNonEEA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalSingleSidedNonEEA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalSingleSidedNonEEA { get; init; } 
    #else
    public System.UInt64 TotalSingleSidedNonEEA { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the most common data field considered as reason for paired non-matched derivatives.
    /// </summary>
    [IsoId("_6lXh8VfcEeqZr5K1Woax-g")]
    [DisplayName("Top Reasons For Paired Non Matched")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TopRsnsForPairdNonMtchd")]
    #endif
    [IsoXmlTag("TopRsnsForPairdNonMtchd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TopReasonsForPairedNonMatched { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TopReasonsForPairedNonMatched { get; init; } 
    #else
    public System.String? TopReasonsForPairedNonMatched { get; set; } 
    #endif
    
    
    #nullable disable
    
}
