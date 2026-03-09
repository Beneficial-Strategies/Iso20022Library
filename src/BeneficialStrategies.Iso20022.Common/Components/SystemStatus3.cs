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
/// Status of a system and the period of time during which the status is valid.
/// </summary>
[IsoId("_xCzJx5lcEeeE1Ya-LgRsuQ")]
[DisplayName("System Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemStatus3( SystemStatus2Choice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Current status of a system.
    /// </summary>
    [IsoId("_xLYeAZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemStatus2Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemStatus2Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemStatus2Choice_ Status { get; init; } 
    #else
    public SystemStatus2Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Period of time during which the status of the system is valid.
    /// </summary>
    [IsoId("_xLYeA5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Validity Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyTm")]
    #endif
    [IsoXmlTag("VldtyTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ValidityTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ValidityTime { get; init; } 
    #else
    public DateTimePeriod1Choice_? ValidityTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
