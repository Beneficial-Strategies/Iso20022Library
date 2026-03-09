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
/// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
/// </summary>
[IsoId("_RVH95Np-Ed-ak6NoX_4Aeg_-1758177157")]
[DisplayName("Specific Instruction Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SpecificInstructionRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Request to register for participation to the meeting.
    /// </summary>
    [IsoId("_RVH95dp-Ed-ak6NoX_4Aeg_-2054390611")]
    [DisplayName("Participation Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtcptnRegn")]
    #endif
    [IsoXmlTag("PrtcptnRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ParticipationRegistration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParticipationRegistration { get; init; } 
    #else
    public System.String? ParticipationRegistration { get; set; } 
    #endif
    
    /// <summary>
    /// Request to block the securities.
    /// </summary>
    [IsoId("_RVH95tp-Ed-ak6NoX_4Aeg_-1707147689")]
    [DisplayName("Blocking Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckgScties")]
    #endif
    [IsoXmlTag("BlckgScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BlockingSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockingSecurities { get; init; } 
    #else
    public System.String? BlockingSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Request to register the securities for the meeting.
    /// </summary>
    [IsoId("_RVH959p-Ed-ak6NoX_4Aeg_-1592630247")]
    [DisplayName("Securities Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesRegn")]
    #endif
    [IsoXmlTag("SctiesRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesRegistration { get; init; } 
    #else
    public System.String? SecuritiesRegistration { get; set; } 
    #endif
    
    
    #nullable disable
    
}
