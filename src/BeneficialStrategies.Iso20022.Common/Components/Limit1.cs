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
/// Specifies the number of occurrences of a particular event and the maximum number of times this event may occur.
/// </summary>
[IsoId("_RJpGpNp-Ed-ak6NoX_4Aeg_-234268618")]
[DisplayName("Limit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Limit1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Limit1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Limit1( System.String reqCurrent,System.String reqLimit )
    {
        Current = reqCurrent;
        Limit = reqLimit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of occurrences of a particular event.
    /// </summary>
    [IsoId("_RJpGpdp-Ed-ak6NoX_4Aeg_-195483682")]
    [DisplayName("Current")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cur")]
    #endif
    [IsoXmlTag("Cur")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText Current { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Current { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Current { get; init; } 
    #else
    public System.String Current { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the maximum number of times an event may occur.
    /// </summary>
    [IsoId("_RJpGptp-Ed-ak6NoX_4Aeg_78802724")]
    [DisplayName("Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lmt")]
    #endif
    [IsoXmlTag("Lmt")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText Limit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Limit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Limit { get; init; } 
    #else
    public System.String Limit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
