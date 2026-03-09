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
/// Format to express a date and a date mode.
/// </summary>
[IsoId("__ZsXMFuSEeSmO6RkXg92Lg")]
[DisplayName("Date Format")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DateFormat1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DateFormat1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DateFormat1( DateFormat3Choice_ reqDate )
    {
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date at which the event occurs.
    /// </summary>
    [IsoId("_KZJuYFuTEeSmO6RkXg92Lg")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat3Choice_ Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat3Choice_ Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat3Choice_ Date { get; init; } 
    #else
    public DateFormat3Choice_ Date { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether an event for which a date is provided occurs typically at the &quot;beginning of day&quot; or at the &quot;end of day&quot;.
    /// </summary>
    [IsoId("_NbPmYFuTEeSmO6RkXg92Lg")]
    [DisplayName("Date Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtMd")]
    #endif
    [IsoXmlTag("DtMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateMode1Code? DateMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateMode1Code? DateMode { get; init; } 
    #else
    public DateMode1Code? DateMode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
