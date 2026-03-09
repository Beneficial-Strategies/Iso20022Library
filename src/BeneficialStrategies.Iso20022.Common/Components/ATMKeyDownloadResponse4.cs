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
/// Information related to the response of an ATM key download from an ATM manager.
/// </summary>
[IsoId("_Zt_VgbTyEeeQy4o2AayYHg")]
[DisplayName("ATM Key Download Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMKeyDownloadResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMKeyDownloadResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMKeyDownloadResponse4( ATMEnvironment7 reqEnvironment,ATMSecurityContext3 reqATMSecurityContext,SecurityParameters10 reqHostSecurityParameters )
    {
        Environment = reqEnvironment;
        ATMSecurityContext = reqATMSecurityContext;
        HostSecurityParameters = reqHostSecurityParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_Z3LtwbTyEeeQy4o2AayYHg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment7 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment7 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment7 Environment { get; init; } 
    #else
    public ATMEnvironment7 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_Z3Ltw7TyEeeQy4o2AayYHg")]
    [DisplayName("ATM Security Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSctyCntxt")]
    #endif
    [IsoXmlTag("ATMSctyCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMSecurityContext3 ATMSecurityContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMSecurityContext3 ATMSecurityContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityContext3 ATMSecurityContext { get; init; } 
    #else
    public ATMSecurityContext3 ATMSecurityContext { get; set; } 
    #endif
    
    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    [IsoId("_Z3LtxbTyEeeQy4o2AayYHg")]
    [DisplayName("ATM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMChllng")]
    #endif
    [IsoXmlTag("ATMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? ATMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ATMChallenge { get; init; } 
    #else
    public System.Byte[]? ATMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    [IsoId("_Z3Ltx7TyEeeQy4o2AayYHg")]
    [DisplayName("Host Security Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstSctyParams")]
    #endif
    [IsoXmlTag("HstSctyParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityParameters10 HostSecurityParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityParameters10 HostSecurityParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityParameters10 HostSecurityParameters { get; init; } 
    #else
    public SecurityParameters10 HostSecurityParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_Z3LtybTyEeeQy4o2AayYHg")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand13? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand13? Command { get; init; } 
    #else
    public ATMCommand13? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
