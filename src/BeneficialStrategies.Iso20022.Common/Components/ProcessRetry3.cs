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
/// Definition of retry process if activation of an action fails.
/// </summary>
[IsoId("_M4Y0sTASEeugIJ3Gvoevmg")]
[DisplayName("Process Retry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessRetry3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProcessRetry3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessRetry3( System.String reqDelay )
    {
        Delay = reqDelay;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Time period to wait for a retry in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    [IsoId("_NGOcYTASEeugIJ3Gvoevmg")]
    [DisplayName("Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dely")]
    #endif
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax9NumericText Delay { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Delay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Delay { get; init; } 
    #else
    public System.String Delay { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of retries.
    /// </summary>
    [IsoId("_NGOcYzASEeugIJ3Gvoevmg")]
    [DisplayName("Maximum Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxNb")]
    #endif
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumNumber { get; init; } 
    #else
    public System.UInt64? MaximumNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    [IsoId("_P-GocTASEeugIJ3Gvoevmg")]
    [DisplayName("Unit Of Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfTm")]
    #endif
    [IsoXmlTag("UnitOfTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeUnit1Code? UnitOfTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeUnit1Code? UnitOfTime { get; init; } 
    #else
    public TimeUnit1Code? UnitOfTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
