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
/// Indicates how to register a proxy.
/// </summary>
[IsoId("_T44UEdp-Ed-ak6NoX_4Aeg_-1448448855")]
[DisplayName("Proxy Appointment Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProxyAppointmentInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates how to register a proxy.
    /// </summary>
    [IsoId("_T44UEtp-Ed-ak6NoX_4Aeg_-1448448846")]
    [DisplayName("Registration Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnMtd")]
    #endif
    [IsoXmlTag("RegnMtd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? RegistrationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationMethod { get; init; } 
    #else
    public System.String? RegistrationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the intermediary.
    /// </summary>
    [IsoId("_T44UE9p-Ed-ak6NoX_4Aeg_-1448448830")]
    [DisplayName("Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ddln")]
    #endif
    [IsoXmlTag("Ddln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? Deadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? Deadline { get; init; } 
    #else
    public DateFormat2Choice_? Deadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the intermediary (STP mode).
    /// </summary>
    [IsoId("_T44UFNp-Ed-ak6NoX_4Aeg_-1447528841")]
    [DisplayName("STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="STPDdln")]
    #endif
    [IsoXmlTag("STPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? STPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? STPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? STPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the issuer.
    /// </summary>
    [IsoId("_T44UFdp-Ed-ak6NoX_4Aeg_-1447528824")]
    [DisplayName("Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktDdln")]
    #endif
    [IsoXmlTag("MktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? MarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? MarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? MarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the proxy persons which are authorised by the issuer.
    /// </summary>
    [IsoId("_T44UFtp-Ed-ak6NoX_4Aeg_2093029164")]
    [DisplayName("Authorised Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdPrxy")]
    #endif
    [IsoXmlTag("AuthrsdPrxy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Proxy1> AuthorisedProxy { get; init; } = new ValueList<Proxy1>(){};
    
    
    #nullable disable
    
}
