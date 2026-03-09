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
/// Describes information needed to identify a change for a static data, the time when it was performed and the user requesting the change and approving it.
/// </summary>
[IsoId("_dVcQ04m7Eeipw6hHPgB4Sw")]
[DisplayName("Calendar Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CalendarData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CalendarData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CalendarData1( System.DateOnly reqSystemDate,SystemStatus3Choice_ reqSystemStatus )
    {
        SystemDate = reqSystemDate;
        SystemStatus = reqSystemStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date for which the calendar information is provided.
    /// </summary>
    [IsoId("_-zQEYom7Eeipw6hHPgB4Sw")]
    [DisplayName("System Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysDt")]
    #endif
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SystemDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SystemDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SystemDate { get; init; } 
    #else
    public System.DateOnly SystemDate { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the system.
    /// </summary>
    [IsoId("_-zQEY4m7Eeipw6hHPgB4Sw")]
    [DisplayName("System Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysSts")]
    #endif
    [IsoXmlTag("SysSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemStatus3Choice_ SystemStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemStatus3Choice_ SystemStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemStatus3Choice_ SystemStatus { get; init; } 
    #else
    public SystemStatus3Choice_ SystemStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
