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
/// Identification of an order desk.
/// </summary>
[IsoId("_yxKW8F9HEeicg40_9gK9vQ")]
[DisplayName("Order Desk")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderDesk1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contact information for the order desk.
    /// </summary>
    [IsoId("_-OUWwV9HEeicg40_9gK9vQ")]
    [DisplayName("Order Desk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDsk")]
    #endif
    [IsoXmlTag("OrdrDsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactAttributes5? OrderDesk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5? OrderDesk { get; init; } 
    #else
    public ContactAttributes5? OrderDesk { get; set; } 
    #endif
    
    /// <summary>
    /// Days on which the order desk is closed.
    /// </summary>
    [IsoId("_WyRNsF9IEeicg40_9gK9vQ")]
    [DisplayName("Closure Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrDts")]
    #endif
    [IsoXmlTag("ClsrDts")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClosureDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClosureDates { get; init; } 
    #else
    public System.DateOnly? ClosureDates { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the main order desk.
    /// </summary>
    [IsoId("_6umMIbAbEeiADpd1Q5gEyQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
