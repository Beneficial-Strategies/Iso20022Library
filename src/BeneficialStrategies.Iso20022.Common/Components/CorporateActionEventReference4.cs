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
/// Identification of a linked corporate action event.
/// </summary>
[IsoId("_chUcRZKQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Event Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionEventReference4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionEventReference4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionEventReference4( CorporateActionEventReference4Choice_ reqEventIdentification )
    {
        EventIdentification = reqEventIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the linked corporate action event.
    /// </summary>
    [IsoId("_chUcR5KQEeWHWpTQn1FFVg")]
    [DisplayName("Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtId")]
    #endif
    [IsoXmlTag("EvtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventReference4Choice_ EventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventReference4Choice_ EventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventReference4Choice_ EventIdentification { get; init; } 
    #else
    public CorporateActionEventReference4Choice_ EventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies when this corporate action event is to be processed relative to a linked corporate action event.
    /// </summary>
    [IsoId("_chUcT5KQEeWHWpTQn1FFVg")]
    [DisplayName("Linkage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkgTp")]
    #endif
    [IsoXmlTag("LkgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition10Choice_? LinkageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition10Choice_? LinkageType { get; init; } 
    #else
    public ProcessingPosition10Choice_? LinkageType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
