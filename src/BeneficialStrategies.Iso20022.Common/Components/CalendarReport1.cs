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
/// Reports either on the risk management limit or on a business error.
/// </summary>
[IsoId("_dVcQ24m7Eeipw6hHPgB4Sw")]
[DisplayName("Calendar Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CalendarReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CalendarReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CalendarReport1( CalendarOrBusinessError1Choice_ reqCalendarOrError )
    {
        CalendarOrError = reqCalendarOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the service or system for which the calendar information is provided.
    /// </summary>
    [IsoId("_G00uIYm8Eeipw6hHPgB4Sw")]
    [DisplayName("Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svc")]
    #endif
    [IsoXmlTag("Svc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemAndCurrency1? Service { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemAndCurrency1? Service { get; init; } 
    #else
    public SystemAndCurrency1? Service { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the calendar or business error report when information has not been found.
    /// </summary>
    [IsoId("_dVcQ34m7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CalOrErr")]
    #endif
    [IsoXmlTag("CalOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CalendarOrBusinessError1Choice_ CalendarOrError { get; init; } 
    #else
    public CalendarOrBusinessError1Choice_ CalendarOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
