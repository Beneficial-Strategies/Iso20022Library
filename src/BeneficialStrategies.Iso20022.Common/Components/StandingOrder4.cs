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
/// Defines the detailed attributes of a standing order.
/// </summary>
[IsoId("_jwIVBRbvEeOy-PlRuFSUzQ")]
[DisplayName("Standing Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingOrder4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingOrder4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingOrder4( StandingOrderIdentification2 reqStandingOrderIdentification,StandingOrderOrError4Choice_ reqStandingOrderOrError )
    {
        StandingOrderIdentification = reqStandingOrderIdentification;
        StandingOrderOrError = reqStandingOrderOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_kIiN8RbvEeOy-PlRuFSUzQ")]
    [DisplayName("Standing Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrId")]
    #endif
    [IsoXmlTag("StgOrdrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
    #else
    public StandingOrderIdentification2 StandingOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the standing order or business error when information has not been found.
    /// </summary>
    [IsoId("_kIiN8xbvEeOy-PlRuFSUzQ")]
    [DisplayName("Standing Order Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrOrErr")]
    #endif
    [IsoXmlTag("StgOrdrOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderOrError4Choice_ StandingOrderOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderOrError4Choice_ StandingOrderOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderOrError4Choice_ StandingOrderOrError { get; init; } 
    #else
    public StandingOrderOrError4Choice_ StandingOrderOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
