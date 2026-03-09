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
/// Provides information about the processing status.
/// </summary>
[IsoId("_RjkpkNp-Ed-ak6NoX_4Aeg_-1988452432")]
[DisplayName("Individual Movement Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualMovementStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualMovementStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualMovementStatus1( MovementProcessingStatus1 reqProcessedStatus,DistributionRejectionStatus1 reqRejectedStatus )
    {
        ProcessedStatus = reqProcessedStatus;
        RejectedStatus = reqRejectedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the movement.
    /// </summary>
    [IsoId("_Rjkpkdp-Ed-ak6NoX_4Aeg_-1957054674")]
    [DisplayName("Movement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntId")]
    #endif
    [IsoXmlTag("MvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MovementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MovementIdentification { get; init; } 
    #else
    public System.String? MovementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the processing status of individual movement.
    /// </summary>
    [IsoId("_Rjkpktp-Ed-ak6NoX_4Aeg_-1443576010")]
    [DisplayName("Processed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdSts")]
    #endif
    [IsoXmlTag("PrcdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MovementProcessingStatus1 ProcessedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MovementProcessingStatus1 ProcessedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MovementProcessingStatus1 ProcessedStatus { get; init; } 
    #else
    public MovementProcessingStatus1 ProcessedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_Rjkpk9p-Ed-ak6NoX_4Aeg_1990813693")]
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
