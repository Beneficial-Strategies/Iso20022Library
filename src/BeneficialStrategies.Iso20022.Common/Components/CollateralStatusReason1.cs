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
/// Business status of the collateral data management request for processing in the system.
/// </summary>
[IsoId("_jBTw8e5NEeCisYr99QEiWA_246169338")]
[DisplayName("Collateral Status Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralStatusReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralStatusReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralStatusReason1( Status6Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the collateral data maintenance instruction.
    /// </summary>
    [IsoId("_jBTw8u5NEeCisYr99QEiWA_132330272")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status6Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status6Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status6Code Status { get; init; } 
    #else
    public Status6Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the status of a collateral data maintenance instruction.
    /// </summary>
    [IsoId("_jBTw8-5NEeCisYr99QEiWA_-750903015")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation10? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation10? Reason { get; init; } 
    #else
    public StatusReasonInformation10? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
