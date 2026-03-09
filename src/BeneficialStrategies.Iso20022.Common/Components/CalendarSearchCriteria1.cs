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
/// Defines the criteria used to search for calendar data.
/// </summary>
[IsoId("_w9W9hYm5Eeipw6hHPgB4Sw")]
[DisplayName("Calendar Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CalendarSearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the year for which the calendar information must be returned.
    /// </summary>
    [IsoId("_4unTUIm5Eeipw6hHPgB4Sw")]
    [DisplayName("Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Yr")]
    #endif
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYear? Year { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? Year { get; init; } 
    #else
    public System.UInt16? Year { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the month for which the calendar information must be returned.
    /// </summary>
    [IsoId("_6zc44Im5Eeipw6hHPgB4Sw")]
    [DisplayName("Month")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mnth")]
    #endif
    [IsoXmlTag("Mnth")]
    [IsoSimpleType(IsoSimpleType.ISOMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOMonth? Month { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte? Month { get; init; } 
    #else
    public System.Byte? Month { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the service or system for which the calendar information must be returned.
    /// </summary>
    [IsoId("_kKD0sIm6Eeipw6hHPgB4Sw")]
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
    
    
    #nullable disable
    
}
