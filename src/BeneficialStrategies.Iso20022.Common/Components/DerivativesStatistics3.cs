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
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
/// </summary>
[IsoId("_NHlf5VfdEeqZr5K1Woax-g")]
[DisplayName("Derivatives Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativesStatistics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativesStatistics3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativesStatistics3( StatisticsPerActionType1 reqTotalSubmitted,StatisticsPerActionType1 reqTotalRejected,StatisticsPerActionType1 reqTotalCorrectedRejections,TopReasonsForRejections2 reqTopRejectionReasons )
    {
        TotalSubmitted = reqTotalSubmitted;
        TotalRejected = reqTotalRejected;
        TotalCorrectedRejections = reqTotalCorrectedRejections;
        TopRejectionReasons = reqTopRejectionReasons;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of derivatives submitted by the report submitting entity for the reporting counterparty.
    /// </summary>
    [IsoId("_NeaEcVfdEeqZr5K1Woax-g")]
    [DisplayName("Total Submitted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSubmittd")]
    #endif
    [IsoXmlTag("TtlSubmittd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerActionType1 TotalSubmitted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerActionType1 TotalSubmitted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerActionType1 TotalSubmitted { get; init; } 
    #else
    public StatisticsPerActionType1 TotalSubmitted { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty.
    /// </summary>
    [IsoId("_NeaEc1fdEeqZr5K1Woax-g")]
    [DisplayName("Total Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRjctd")]
    #endif
    [IsoXmlTag("TtlRjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerActionType1 TotalRejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerActionType1 TotalRejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerActionType1 TotalRejected { get; init; } 
    #else
    public StatisticsPerActionType1 TotalRejected { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of rejected derivatives submitted by the report submitting entity for the reporting counterparty which were then corrected within ten business days.
    /// </summary>
    [IsoId("_NeaEdVfdEeqZr5K1Woax-g")]
    [DisplayName("Total Corrected Rejections")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCrrctdRjctns")]
    #endif
    [IsoXmlTag("TtlCrrctdRjctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticsPerActionType1 TotalCorrectedRejections { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticsPerActionType1 TotalCorrectedRejections { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticsPerActionType1 TotalCorrectedRejections { get; init; } 
    #else
    public StatisticsPerActionType1 TotalCorrectedRejections { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the most common data field in reported derivatives that has not passed the validation rule.
    /// </summary>
    [IsoId("_NeaEd1fdEeqZr5K1Woax-g")]
    [DisplayName("Top Rejection Reasons")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TopRjctnRsns")]
    #endif
    [IsoXmlTag("TopRjctnRsns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TopReasonsForRejections2 TopRejectionReasons { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TopReasonsForRejections2 TopRejectionReasons { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TopReasonsForRejections2 TopRejectionReasons { get; init; } 
    #else
    public TopReasonsForRejections2 TopRejectionReasons { get; set; } 
    #endif
    
    
    #nullable disable
    
}
