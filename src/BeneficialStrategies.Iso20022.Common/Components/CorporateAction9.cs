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
/// An event determined by a corporation&apos;s board of directors, that changes the existing corporate capital structure or financial condition.
/// </summary>
[IsoId("_t20OQVkyEeGeoaLUQk__nA_-1416100338")]
[DisplayName("Corporate Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateAction9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateAction9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateAction9( System.String reqEventType,System.String reqEventIdentification )
    {
        EventType = reqEventType;
        EventIdentification = reqEventIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of corporate action event, in a free-text format.
    /// </summary>
    [IsoId("_t20OQlkyEeGeoaLUQk__nA_1767955539")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EventType { get; init; } 
    #else
    public System.String EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a corporate action assigned by an official central body/entity within a given market.
    /// </summary>
    [IsoId("_t20OQ1kyEeGeoaLUQk__nA_2048814500")]
    [DisplayName("Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtId")]
    #endif
    [IsoXmlTag("EvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text EventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EventIdentification { get; init; } 
    #else
    public System.String EventIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
