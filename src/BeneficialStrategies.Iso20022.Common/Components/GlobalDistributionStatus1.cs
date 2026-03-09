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
/// Provides information about the status of the global movement.
/// </summary>
[IsoId("_Ri-zsNp-Ed-ak6NoX_4Aeg_-2092963403")]
[DisplayName("Global Distribution Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GlobalDistributionStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GlobalDistributionStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GlobalDistributionStatus1( DistributionProcessingStatus1 reqProcessedStatus,DistributionRejectionStatus1 reqRejectedStatus )
    {
        ProcessedStatus = reqProcessedStatus;
        RejectedStatus = reqRejectedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the processing status of the global movement.
    /// </summary>
    [IsoId("_Ri-zsdp-Ed-ak6NoX_4Aeg_-2010770250")]
    [DisplayName("Processed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdSts")]
    #endif
    [IsoXmlTag("PrcdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DistributionProcessingStatus1 ProcessedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DistributionProcessingStatus1 ProcessedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionProcessingStatus1 ProcessedStatus { get; init; } 
    #else
    public DistributionProcessingStatus1 ProcessedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Ri-zstp-Ed-ak6NoX_4Aeg_-2008920266")]
    [DisplayName("Rejected Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdSts")]
    #endif
    [IsoXmlTag("RjctdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DistributionRejectionStatus1 RejectedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DistributionRejectionStatus1 RejectedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionRejectionStatus1 RejectedStatus { get; init; } 
    #else
    public DistributionRejectionStatus1 RejectedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
