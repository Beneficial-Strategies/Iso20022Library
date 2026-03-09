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
[IsoId("_eamLFdcZEeqRFcf2R4bPBw")]
[DisplayName("Standing Order Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingOrderReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingOrderReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingOrderReport2( StandingOrderIdentification6 reqStandingOrderIdentification,StandingOrderOrError8Choice_ reqStandingOrderOrError )
    {
        StandingOrderIdentification = reqStandingOrderIdentification;
        StandingOrderOrError = reqStandingOrderOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_eb5yodcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrId")]
    #endif
    [IsoXmlTag("StgOrdrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderIdentification6 StandingOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderIdentification6 StandingOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderIdentification6 StandingOrderIdentification { get; init; } 
    #else
    public StandingOrderIdentification6 StandingOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the standing order or business error when information has not been found.
    /// </summary>
    [IsoId("_eb5yo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrOrErr")]
    #endif
    [IsoXmlTag("StgOrdrOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingOrderOrError8Choice_ StandingOrderOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingOrderOrError8Choice_ StandingOrderOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingOrderOrError8Choice_ StandingOrderOrError { get; init; } 
    #else
    public StandingOrderOrError8Choice_ StandingOrderOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
