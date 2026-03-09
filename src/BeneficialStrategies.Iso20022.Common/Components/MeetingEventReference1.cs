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
/// Identification of a linked meeting event.
/// </summary>
[IsoId("_M8fK-a7rEemG7MmivSuE5g")]
[DisplayName("Meeting Event Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingEventReference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MeetingEventReference1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingEventReference1( MeetingEventReference1Choice_ reqEventIdentification )
    {
        EventIdentification = reqEventIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the linked meeting event.
    /// </summary>
    [IsoId("_M8fK-q7rEemG7MmivSuE5g")]
    [DisplayName("Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtId")]
    #endif
    [IsoXmlTag("EvtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingEventReference1Choice_ EventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingEventReference1Choice_ EventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingEventReference1Choice_ EventIdentification { get; init; } 
    #else
    public MeetingEventReference1Choice_ EventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies when the event is to be processed relative to the linked event.
    /// </summary>
    [IsoId("_M8fK-67rEemG7MmivSuE5g")]
    [DisplayName("Linkage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkgTp")]
    #endif
    [IsoXmlTag("LkgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingPosition3Code? LinkageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingPosition3Code? LinkageType { get; init; } 
    #else
    public ProcessingPosition3Code? LinkageType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
