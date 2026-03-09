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
/// Specifies corporate action date.
/// </summary>
[IsoId("_QUy-OV99Ee262vCSVgjImg")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate91
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [IsoId("_QUy-PV99Ee262vCSVgjImg")]
    [DisplayName("Cover Expiration Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverXprtnDdln")]
    #endif
    [IsoXmlTag("CoverXprtnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 
    #else
    public DateFormat43Choice_? CoverExpirationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    [IsoId("_QUy-RV99Ee262vCSVgjImg")]
    [DisplayName("Trading Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgDt")]
    #endif
    [IsoXmlTag("TradgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? TradingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? TradingDate { get; init; } 
    #else
    public DateFormat49Choice_? TradingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
