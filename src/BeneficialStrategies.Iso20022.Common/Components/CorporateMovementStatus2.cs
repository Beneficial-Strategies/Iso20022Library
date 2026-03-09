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
/// Provides status of the movement.
/// </summary>
[IsoId("_Ri-zttp-Ed-ak6NoX_4Aeg_728771721")]
[DisplayName("Corporate Movement Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateMovementStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateMovementStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateMovementStatus2( CorporationActionMovementProcessingStatus2 reqProcessedStatus,CorporateActionMovementRejectionStatus2 reqRejectedStatus )
    {
        ProcessedStatus = reqProcessedStatus;
        RejectedStatus = reqRejectedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the processing status of the cancellation request.
    /// </summary>
    [IsoId("_Ri-zt9p-Ed-ak6NoX_4Aeg_1547012214")]
    [DisplayName("Processed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdSts")]
    #endif
    [IsoXmlTag("PrcdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporationActionMovementProcessingStatus2 ProcessedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporationActionMovementProcessingStatus2 ProcessedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporationActionMovementProcessingStatus2 ProcessedStatus { get; init; } 
    #else
    public CorporationActionMovementProcessingStatus2 ProcessedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Ri-zuNp-Ed-ak6NoX_4Aeg_1559018048")]
    [DisplayName("Rejected Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdSts")]
    #endif
    [IsoXmlTag("RjctdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovementRejectionStatus2 RejectedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMovementRejectionStatus2 RejectedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementRejectionStatus2 RejectedStatus { get; init; } 
    #else
    public CorporateActionMovementRejectionStatus2 RejectedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
